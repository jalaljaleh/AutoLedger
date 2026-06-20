using AutoLedger.App.Forms;
using AutoLedger.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

            var loginResult = new LoginForm()
                .ShowDialog();

            if (loginResult == DialogResult.OK)
                Application.Run(new DashboardForm());
            else
                MessageBox.Show("خطا در اتصال به پایگاه داده رخ داده است. لطفا تنظیمات اتصال را بررسی کنید یا با توسعه دهنده نرم افزار تماس بگیرید..", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public const string Version = "ویرایش بتا نسخه 1.0.0.1";
        public static bool IsDebugMode() => System.Diagnostics.Debugger.IsAttached;
    }
}
