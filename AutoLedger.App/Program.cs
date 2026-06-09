using AutoLedger.App.Forms;
using AutoLedger.Data;
using System;
using System.Collections.Generic;
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
               Application.Run(new DashboardForm());

            using (AutoLedgerContext db = new AutoLedgerContext())
            {
                if (Program.IsDebugMode() && db.Database.Exists())
                    db.Database.Delete();

                db.Database.CreateIfNotExists();
            }
        }
        public const string Version = "ویرایش بتا نسخه 1.0.0.1";
        public static bool IsDebugMode() => System.Diagnostics.Debugger.IsAttached;
    }
}
