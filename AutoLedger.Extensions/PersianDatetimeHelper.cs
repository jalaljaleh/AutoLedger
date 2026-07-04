using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Extensions
{
    public static class PersianDatetimeHelper
    {
        public static string ToShamsi(this DateTime date)
        {
            var pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
        }
        public static string ToShamsiLong(this DateTime date)
        {
            var pc = new PersianCalendar();

            int year = pc.GetYear(date);
            int month = pc.GetMonth(date);
            int day = pc.GetDayOfMonth(date);

            int dowIndex = 0;
            switch (pc.GetDayOfWeek(date))
            {
                case DayOfWeek.Saturday: dowIndex = 0; break;
                case DayOfWeek.Sunday: dowIndex = 1; break;
                case DayOfWeek.Monday: dowIndex = 2; break;
                case DayOfWeek.Tuesday: dowIndex = 3; break;
                case DayOfWeek.Wednesday: dowIndex = 4; break;
                case DayOfWeek.Thursday: dowIndex = 5; break;
                case DayOfWeek.Friday: dowIndex = 6; break;
            }

            string[] persianDays = { "شنبه", "یکشنبه",  "دوشنبه", "سه‌شنبه", "چهارشنبه",  "پنجشنبه", "جمعه"  };

            string[] persianMonths =   { "فروردین",  "اردیبهشت",  "خرداد", "تیر", "مرداد", "شهریور",  "مهر", "آبان",  "آذر",  "دی",   "بهمن", "اسفند"  };

            return persianDays[dowIndex] + " " + day + " " + persianMonths[month - 1] + " ماه " + year;
        }

    }
}
