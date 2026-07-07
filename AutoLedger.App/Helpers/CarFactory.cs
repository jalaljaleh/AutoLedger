using AutoLedger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.App
{
    public static class CarFactory
    {
        private static readonly Random _rand = new Random();

        private static readonly string[] IranianBrands = new[]
        {
            "پژو 206", "پژو 405", "پارس", "سمند", "رانا", "تیبا", "ساینا", "کوییک",
            "دنا", "دنا پلاس", "پراید 131", "پراید 132", "پراید 111"
        };

        private static readonly string[] Colors = new[]
        {
            "سفید", "مشکی", "نقره‌ای", "خاکستری", "سرمه‌ای", "آبی", "قرمز"
        };

        private static readonly string[] Tips = new[]
        {
            "بنزینی", "دوگانه‌سوز", "اتومات", "دنده‌ای"
        };

        private static readonly string[] FirstNames = new[]
        {
            "علی", "رضا", "محمد", "حسین", "سجاد", "مهدی", "نیما", "امیر", "یاسین"
        };

        private static readonly string[] LastNames = new[]
        {
            "کریمی", "محمدی", "احمدی", "جعفری", "مرادی", "قاسمی", "اکبری", "حسینی"
        };

        /// <summary>
        /// تولید لیست خودروهای ایرانی به صورت تصادفی
        /// </summary>
        public static List<Car> Generate(int count)
        {
            var list = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                var brand = IranianBrands[_rand.Next(IranianBrands.Length)];
                var color = Colors[_rand.Next(Colors.Length)];
                var tip = Tips[_rand.Next(Tips.Length)];

                var fullName = FirstNames[_rand.Next(FirstNames.Length)] + " " +
                               LastNames[_rand.Next(LastNames.Length)];

                var nationalId = _rand.Next(100000000, 999999999).ToString();
                var phone = "09" + _rand.Next(100000000, 999999999);

                var modelYear = _rand.Next(1385, 1403);

                list.Add(new Car
                {
                    PlateId = GeneratePlate(),
                    Brand = brand,
                    Model = modelYear,
                    Color = color,
                    Tip = tip,
                    OwnerFullName = fullName,
                    OwnerNationalId = nationalId,
                    OwnerPhoneNumber = phone,
                    UpdatedAt = DateTime.Now,
                    Receptions = new List<CarReception>()
                });
            }

            return list;
        }

        /// <summary>
        /// تولید پلاک ایرانی تصادفی
        /// </summary>
        private static string GeneratePlate()
        {
            string letters = "الفبپتثجچحخدذرزسشصضطظعغفقکگلمنوهی";
            return $"{_rand.Next(10, 99)}{letters[_rand.Next(letters.Length)]}{_rand.Next(100, 999)}-{"IR"}";
        }
    }
}
