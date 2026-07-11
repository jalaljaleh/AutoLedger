using AutoLedger.App.Forms;
using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App
{
    internal static class Program
    {
        public static User User { get; set; } = null;
        public static DateTime StartupTime { get; set; } = DateTime.Now;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                using (var loading = new LoginForm())
                {
                    loading.Enabled = false;
                    loading.Shown += async (sender, e) =>
                    {
                        await Task.Delay(150);

                        if (!await InitializeDatabaseSync())
                        {
                            MessageBox.Show("خطای اتصال دیتابیس؛ برنامه باید بسته شود. فایل لاگ را مشاهده کنید.");
                            Environment.Exit(0);
                        }
                        loading.Close();
                    };

                    Application.Run(loading);
                }

                OfflineTimeChecker.CheckSystemClock();

                using (var loginDialog = new LoginForm())
                {
                    _ = loginDialog.InitializeAsync();
                    var dialog = loginDialog.ShowDialog();

                    if (dialog == DialogResult.OK)
                        Application.Run(new DashboardForm());

                }

            }
            catch (Exception ex)
            {
                try
                {
                    string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error_log.txt");

                    string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] ERROR: {ex.Message}{Environment.NewLine}" +
                                        $"STACK TRACE: {ex.StackTrace}{Environment.NewLine}" +
                                        $"---------------------------------------------------{Environment.NewLine}";

                    File.AppendAllText(logPath, logMessage);
                }
                catch
                {
                }

                MessageBox.Show("خطای ناشناخته، برنامه باید بسته شود. جزئیات در فایل لاگ ثبت شد.");
            }
        }


        public static async Task<bool> InitializeDatabaseSync()
        {
            return await Task.Run(() =>
            {
                string localDb = $@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IronTuning.mdf")}; Integrated Security=True; Connect Timeout=30; Context Connection=false;"; Environment.SetEnvironmentVariable("connectionString", localDb);
                try
                {
                    using (AutoLedgerContext db = new AutoLedgerContext())
                    {
                        //if (db.Database.Exists())
                        //    db.Database.Delete();

                        if (db.Database.CreateIfNotExists())
                        {
                            DatabaseSeeder.SeedExpenseCategories(db);
                            DatabaseSeeder.SeedUsers(db);
                            //   DatabaseSeeder.SeedCarsAndCarReceptions(db, 100, 5);

                            db.SaveChanges();
                        }

                    }
                    return Task.FromResult(true);
                }
                catch (Exception ex)
                {
                    try
                    {
                        string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error_log.txt");

                        string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] ERROR: {ex.Message}{Environment.NewLine}" +
                                            $"STACK TRACE: {ex.StackTrace}{Environment.NewLine}" +
                                            $"---------------------------------------------------{Environment.NewLine}";

                        File.AppendAllText(logPath, logMessage);
                    }
                    catch
                    {
                    }

                    MessageBox.Show("خطای اتصال دیتابیس؛ در فایل لاگ ذخیره شد.");

                    return Task.FromResult(false);
                }

            });
        }


        public const string Version = "ویرایش بتا نسخه 1.0.3.25";
        public static bool IsDebugMode() => System.Diagnostics.Debugger.IsAttached;


    }
}
