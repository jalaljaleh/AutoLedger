using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App
{
    public static class OfflineTimeChecker
    {
        public static bool IsTimeTampered()
        {
            DateTime currentTime = DateTime.Now;

            DateTime lastKnownTime = AutoLedger.App.Properties.Settings.Default.LastKnownTime;

            if (currentTime < lastKnownTime)
            {
                return true; 
            }

            AutoLedger.App.Properties.Settings.Default.LastKnownTime = currentTime;
            AutoLedger.App.Properties.Settings.Default.Save();

            return false;
        }

        public static void CheckSystemClock()
        {
            if (IsTimeTampered())
            {
                MessageBox.Show(
                    "خطای زمان! به نظر می‌رسد تاریخ سیستم به عقب کشیده شده است. لطفاً تاریخ ویندوز را اصلاح کنید.",
                    "اخطار دستکاری ساعت",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );


            }
        }
    }
}
