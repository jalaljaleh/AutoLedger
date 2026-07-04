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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var loading = new LoginForm())
            {
                loading.Show();
                loading.Refresh();
                loading.Enabled = false;

                bool connected = InitializeDatabaseSync().Result;

                loading.Close();

                if (!connected)
                {
                    MessageBox.Show(
                        "خطا در اتصال به پایگاه داده رخ داده است.",
                        "خطا",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }

            using (var loginDialog = new LoginForm())
            {
                _ = loginDialog.InitializeAsync();
                var dialog = loginDialog.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    Application.Run(new DashboardForm());
                }
            }
        }



        public static Task<bool> InitializeDatabaseSync()
        {
            //try
            //{
                string express = @"Data Source=.\SQLEXPRESS2014; Initial Catalog=IronTuning; Integrated Security=True; MultipleActiveResultSets=True; Connect Timeout=30";
                string localDb = $@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IronTuning.mdf")}; Integrated Security=True; Connect Timeout=30";

                Environment.SetEnvironmentVariable("connectionString", localDb);

                using (AutoLedgerContext db = new AutoLedgerContext())
                {
                    if (db.Database.Exists())
                        db.Database.Delete();

                    bool isCreated = db.Database.CreateIfNotExists();
                    if (isCreated)
                    {
                        db.Users.Add(new User()
                        {
                            FullName = "محمدجلال ژاله",
                            Password = "jj"
                        });
                        db.Users.Add(new User()
                        {
                            FullName = "فرید عزیزی",
                            Password = "admin"
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


                }
                return Task.FromResult(true);
            //}
            //catch
            //{
            //    return Task.FromResult(false);
            //}
        }



        public const string Version = "ویرایش بتا نسخه 1.0.1.20";
        public static bool IsDebugMode() => System.Diagnostics.Debugger.IsAttached;


    }
}
