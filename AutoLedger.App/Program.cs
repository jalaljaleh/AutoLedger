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

                bool connected = false;

                using (var loading = new LoginForm())
                {
                    loading.Enabled = false;

                    loading.Shown += async (sender, e) =>
                    {
                        connected = await InitializeDatabaseSync();

                        loading.Close();
                    };

                    Application.Run(loading);
                }

                OfflineTimeChecker.CheckSystemClock();

                if (IsDebugMode())
                {
                    using (var db = new AutoLedgerContext())
                    {
                        User = db.Users.AsNoTracking().FirstOrDefault();
                    }

                    Application.Run(new DashboardForm());
                    return;
                }

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
                    // Define a path for the log file (e.g., in the application folder)
                    string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error_log.txt");

                    // Format the error message
                    string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] ERROR: {ex.Message}{Environment.NewLine}" +
                                        $"STACK TRACE: {ex.StackTrace}{Environment.NewLine}" +
                                        $"---------------------------------------------------{Environment.NewLine}";

                    // Write to the file
                    File.AppendAllText(logPath, logMessage);
                }
                catch
                {
                    // Silently fail if even the logging fails to avoid crashing the error handler
                }

                MessageBox.Show("خطای ناشناخته، برنامه باید بسته شود. جزئیات در فایل لاگ ثبت شد.");
            }
        }


        public static Task<bool> InitializeDatabaseSync()
        {
            //try
            //{
            string localDb = $@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IronTuning.mdf")}; Integrated Security=True; Connect Timeout=30";
            Environment.SetEnvironmentVariable("connectionString", localDb);

            using (AutoLedgerContext db = new AutoLedgerContext())
            {
                //if (db.Database.Exists())
                //    db.Database.Delete();

                bool isCreated = db.Database.CreateIfNotExists();
                if (isCreated)
                {
                    db.Users.Add(new User()
                    {
                        FullName = "محمدجلال ژاله",
                        Password = "jj",
                    });
                    db.Users.Add(new User()
                    {
                        FullName = "فرید عزیزی",
                        Password = "admin",
                    });

                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("هزینه‌های عمومی"));
                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("مواد مصرفی"));
                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("اجاره بها"));
                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("قبوض و خدمات"));
                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("حمل‌ونقل و جابه‌جایی"));
                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("حقوق و دستمزد"));
                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("ابزار و تجهیزات"));
                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("قطعات و لوازم یدکی"));
                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("نظافت و بهداشت"));
                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("مالیات و امور قانونی"));
                    db.ExpenseCategories.Add(new ExpenseCategory().WithName("بازاریابی و تبلیغات"));

                    db.SaveChanges();
                }
                //var data = CarFactory.Generate(1000);
                //foreach (var item in data)
                //{
                //    var re = CarReceptionFactory.GenerateForCar(item, 5);
                //    Console.WriteLine($"{data.IndexOf(item)} added");
                //}
                //db.Cars.AddRange(data);
                //db.SaveChanges();
            }
            return Task.FromResult(true);
            //}
            //catch
            //{
            //    return Task.FromResult(false);
            //}
        }



        public const string Version = "ویرایش بتا نسخه 1.0.2.25";
        public static bool IsDebugMode() => System.Diagnostics.Debugger.IsAttached;


    }
}
