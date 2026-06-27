using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace AutoLedger.Extensions
{
    public static class NumberToPersianWords
    {
        private static readonly string[] Yekan =
        {
        "", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه"
    };

        private static readonly string[] Dahgan =
        {
        "", "ده", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود"
    };

        private static readonly string[] DahYekan =
        {
        "ده", "یازده", "دوازده", "سیزده", "چهارده",
        "پانزده", "شانزده", "هفده", "هجده", "نوزده"
    };

        private static readonly string[] Sadgan =
        {
        "", "یکصد", "دویست", "سیصد", "چهارصد",
        "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد"
    };

        private static readonly string[] Groups =
        {
        "", "هزار", "میلیون", "میلیارد", "تریلیون"
    };

        public static string ToPersianWords(this long number)
        {
            if (number == 0)
                return "صفر";

            if (number < 0)
                return "منفی " + ToPersianWords(Math.Abs(number));

            var parts = new List<string>();
            int groupIndex = 0;

            while (number > 0)
            {
                int threeDigits = (int)(number % 1000);

                if (threeDigits != 0)
                {
                    string groupText = ThreeDigitToWords(threeDigits);

                    if (!string.IsNullOrEmpty(Groups[groupIndex]))
                        groupText += " " + Groups[groupIndex];

                    parts.Insert(0, groupText);
                }

                number /= 1000;
                groupIndex++;
            }

            return string.Join(" و ", parts);
        }

        private static string ThreeDigitToWords(this int number)
        {
            var parts = new List<string>();

            int sad = number / 100;
            int dahgan = (number % 100) / 10;
            int yekan = number % 10;

            if (sad > 0)
                parts.Add(Sadgan[sad]);

            if (dahgan == 1) // 10–19
                parts.Add(DahYekan[yekan]);
            else
            {
                if (dahgan > 0)
                    parts.Add(Dahgan[dahgan]);

                if (yekan > 0)
                    parts.Add(Yekan[yekan]);
            }

            return string.Join(" و ", parts);
        }


        public static string ToPersianWordsToman(this long number)
        {
            return ToPersianWords(number) + " تومان";
        }
        public static string ToPersianWordsToman(this decimal number)
        {
            return ToPersianWords((int)number) + " تومان";
        }
    }

}
