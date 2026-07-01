using AutoLedger.App.Forms;
using AutoLedger.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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
            ApplyPersianCultureSafely();

            using (var loading = new LoginForm())
            {
                loading.Show();
                loading.Refresh();

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

            Application.Run(new DashboardForm());
        }


        private static void ApplyPersianCultureSafely()
        {
            var fa = new CultureInfo("fa-IR");
            var persianCal = new PersianCalendar();

            bool canUsePersianCalendar = fa.OptionalCalendars
                .Any(c => c.GetType() == typeof(PersianCalendar));

            try
            {
                if (canUsePersianCalendar)
                {
                    // Safe: OptionalCalendars contains PersianCalendar
                    fa.DateTimeFormat.Calendar = persianCal;
                    Thread.CurrentThread.CurrentCulture = fa;
                    Thread.CurrentThread.CurrentUICulture = fa;
                }
                else
                {
                    var safe = (CultureInfo)CultureInfo.InvariantCulture.Clone();
                    safe.NumberFormat = fa.NumberFormat;
                    Thread.CurrentThread.CurrentCulture = safe;
                    Thread.CurrentThread.CurrentUICulture = fa; 
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Failed to set fa-IR calendar: " + ex.Message);
            }
        }

        public static Task<bool> InitializeDatabaseSync()
        {
            try
            {
                using (AutoLedgerContext db = new AutoLedgerContext())
                {
                    //if (db.Database.Exists())
                    //    db.Database.Delete();

                    db.Database.CreateIfNotExists();

                }
                return Task.FromResult(true);
            }
            catch
            {
                return Task.FromResult(false);
            }
        }



        public const string Version = "ویرایش بتا نسخه 1.0.0.1";
        public static bool IsDebugMode() => System.Diagnostics.Debugger.IsAttached;


    }
}
