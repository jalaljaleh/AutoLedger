using System;
using System.Globalization;

public static class PersianDatetimeHelper
{
    private static readonly PersianCalendar pc = new PersianCalendar();

    public static string ToShamsi(this DateTime date)
    {
        if (!IsValidPersianDate(date))
            return "تاریخ نامعتبر";

        return $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
    }
    public static string ToShamsiDayMonth(this DateTime date)
    {
        if (!IsValidPersianDate(date))
            return "تاریخ نامعتبر";

        int month = pc.GetMonth(date.Date);
        int day = pc.GetDayOfMonth(date.Date);

        return $"{month:00}/{day:00}";
    }

    public static string ToShamsiLong(this DateTime date)
    {
        if (!IsValidPersianDate(date))
            return "تاریخ نامعتبر";

        int year = pc.GetYear(date);
        int month = pc.GetMonth(date);
        int day = pc.GetDayOfMonth(date);

        string[] persianDays = { "شنبه", "یکشنبه", "دوشنبه", "سه‌شنبه", "چهارشنبه", "پنجشنبه", "جمعه" };
        string[] persianMonths = { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };

        int dowIndex = (int)pc.GetDayOfWeek(date);

        return $"{persianDays[dowIndex]} {day} {persianMonths[month - 1]} ماه {year}";
    }

    private static bool IsValidPersianDate(DateTime date)
    {
        if (date.Year < 622)
            return false;

        try
        {
            pc.GetYear(date);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
