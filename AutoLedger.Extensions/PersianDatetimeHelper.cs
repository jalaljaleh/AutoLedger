using System;
using System.Globalization;

public static class PersianDatetimeHelper
{
    private static readonly PersianCalendar pc = new PersianCalendar();

    #region Original Methods (Structure and output remain unchanged)

    public static string ToShamsi(this DateTime date)
    {
        if (!IsValidPersianDate(date))
            return "Invalid Date";

        return $"{pc.GetYear(date)}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
    }

    public static string ToShamsiDayMonth(this DateTime date)
    {
        if (!IsValidPersianDate(date))
            return "Invalid Date";

        int month = pc.GetMonth(date.Date);
        int day = pc.GetDayOfMonth(date.Date);

        return $"{month:00}/{day:00}";
    }

    public static string ToShamsiLong(this DateTime date)
    {
        if (!IsValidPersianDate(date))
            return "Invalid Date";

        int year = pc.GetYear(date);
        int month = pc.GetMonth(date);
        int day = pc.GetDayOfMonth(date);

        // Fixing mapping of weekdays (DayOfWeek starts from 0 for Sunday)
        string[] persianDays = { "یکشنبه", "دوشنبه", "سه‌شنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه" };
        string[] persianMonths = { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };

        int dowIndex = (int)pc.GetDayOfWeek(date);

        return $"{persianDays[dowIndex]} {day} {persianMonths[month - 1]} ماه {year}";
    }

    #endregion

    #region New Methods for Date and Time (Hour, Minute, Second)

    /// <summary>
    /// Output format: 1402/05/12 14:30:15
    /// </summary>
    public static string ToShamsiDateTime(this DateTime date, bool includeSeconds = true)
    {
        if (!IsValidPersianDate(date))
            return "Invalid Date";

        string datePart = date.ToShamsi();
        string timePart = includeSeconds
            ? $"{date.Hour:00}:{date.Minute:00}:{date.Second:00}"
            : $"{date.Hour:00}:{date.Minute:00}";

        return $"{datePart} {timePart}";
    }

    /// <summary>
    /// Output format: Monday 12 Mordad 1402 - 14:30
    /// </summary>
    public static string ToShamsiLongDateTime(this DateTime date, bool includeSeconds = false)
    {
        if (!IsValidPersianDate(date))
            return "Invalid Date";

        string longDatePart = date.ToShamsiLong();
        string timePart = includeSeconds
            ? $"{date.Hour:00}:{date.Minute:00}:{date.Second:00}"
            : $"{date.Hour:00}:{date.Minute:00}";

        return $"{longDatePart} - ساعت {timePart}";
    }

    /// <summary>
    /// Extract time only (Output: 14:30 or 14:30:15)
    /// </summary>
    public static string ToTimeOnly(this DateTime date, bool includeSeconds = true)
    {
        return includeSeconds
            ? $"{date.Hour:00}:{date.Minute:00}:{date.Second:00}"
            : $"{date.Hour:00}:{date.Minute:00}";
    }

    #endregion

    #region Special Utilities for Dashboards and Reports

    /// <summary>
    /// Display relative time (e.g., 5 minutes ago, 2 hours ago)
    /// </summary>
    public static string ToRelativeTime(this DateTime date)
    {
        var timeSpan = DateTime.Now - date;

        if (timeSpan <= TimeSpan.FromSeconds(60))
            return "همین الان";
        if (timeSpan <= TimeSpan.FromMinutes(60))
            return timeSpan.Minutes > 1 ? $"{timeSpan.Minutes} دقیقه پیش" : "دقایقی پیش";
        if (timeSpan <= TimeSpan.FromHours(24))
            return timeSpan.Hours > 1 ? $"{timeSpan.Hours} ساعت پیش" : "ساعت گذشته";
        if (timeSpan <= TimeSpan.FromDays(30))
            return timeSpan.Days > 1 ? $"{timeSpan.Days} روز پیش" : "دیروز";
        if (timeSpan <= TimeSpan.FromDays(365))
            return timeSpan.Days > 30 ? $"{timeSpan.Days / 30} ماه گذشته" : "ماه گذشته";

        return $"{timeSpan.Days / 365} سال پیش";
    }

    /// <summary>
    /// Get the start of the day (00:00:00) for database queries
    /// </summary>
    public static DateTime GetStartOfDay(this DateTime date)
    {
        return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
    }

    /// <summary>
    /// Get the end of the day (23:59:59) for database queries
    /// </summary>
    public static DateTime GetEndOfDay(this DateTime date)
    {
        return new DateTime(date.Year, date.Month, date.Day, 23, 59, 59, 999);
    }

    #endregion

    #region Validation Methods

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

    #endregion
}