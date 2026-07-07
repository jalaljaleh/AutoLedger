using AutoLedger.Domain;
using System;
using System.Collections.Generic;
namespace AutoLedger.App
{
    public static class CarReceptionFactory
    {
        private static readonly Random _rand = new Random();

        private static readonly string[] RequestTitles = new[]
        {
            "تعویض روغن", "تنظیم موتور", "تعویض لنت", "بالانس و تنظیم چرخ", "تعویض باتری",
            "سرویس دوره‌ای", "رفع سروصدا", "تعویض تسمه تایم"
        };

        private static readonly string[] ExpenseTitles = new[]
        {
            "خرید قطعه", "دستمزد مکانیک", "هزینه حمل", "هزینه تست و عیب‌یابی"
        };

        private static readonly string[] People = new[]
        {
            "علی کریمی", "رضا محمدی", "مهدی حسینی", "امیر مرادی", "سارا قاسمی"
        };

        private static readonly string[] PaymentMethods = new[]
        {
            "نقدی", "کارت به کارت", "POS", "چک"
        };

        private static readonly string[] RequestDescriptions = new[]
        {
            "تعویض و تنظیم کامل با قطعات اصلی",
            "بازدید کامل و رفع عیوب گزارش شده",
            "تست رانندگی پس از تعمیر",
            "تعویض قطعه و تنظیمات نهایی"
        };

        private static readonly string[] ExpenseDescriptions = new[]
        {
            "قطعه فابریک", "قطعه غیر فابریک با کیفیت بالا", "هزینه ارسال قطعه", "هزینه تست و ابزار"
        };

        /// <summary>
        /// تولید لیست پذیرش‌های تصادفی (بدون اتصال به Car)
        /// </summary>
        public static List<CarReception> Generate(int count)
        {
            var list = new List<CarReception>();
            for (int i = 0; i < count; i++)
            {
                list.Add(CreateRandomReception());
            }
            return list;
        }

        /// <summary>
        /// تولید لیست پذیرش‌های تصادفی مرتبط با یک خودرو مشخص
        /// </summary>
        public static List<CarReception> GenerateForCar( Car car, int count)
        {
            var list = new List<CarReception>();
            for (int i = 0; i < count; i++)
            {
                var reception = CreateRandomReception();
                //   reception.Car = car;
                //      reception.CarId = car.Id;

                car.Receptions.Add(reception);
                list.Add(reception);
            }
            return list;
        }

        private static CarReception CreateRandomReception()
        {
            var created = DateTime.Now.AddDays(-_rand.Next(0, 120));
            var updated = created.AddMinutes(_rand.Next(10, 60 * 24));
            bool isRepaired = _rand.NextDouble() > 0.4;
            bool isReleased = isRepaired && (_rand.NextDouble() > 0.2);

            var reception = new CarReception
            {
                Mileage = _rand.Next(5000, 300000),
                TotalCost = 0m,
                TotalExpenses = 0m,
                IsRepaired = isRepaired,
                IsReleased = isReleased,
                CreatedAt = created,
                UpdatedAt = updated,
                RepairedAt = isRepaired ? (DateTime?)created.AddDays(_rand.Next(0, 7)) : null,
                ReleasedAt = isReleased ? (DateTime?)created.AddDays(_rand.Next(1, 10)) : null,
                Requests = new List<CarReceptionRequest>(),
                Expenses = new List<CarReceptionExpense>()
            };

            // تولید چند درخواست تصادفی
            int reqCount = _rand.Next(1, 5);
            for (int r = 0; r < reqCount; r++)
            {
                var reqCreated = created.AddMinutes(_rand.Next(0, 60 * 24));
                var req = new CarReceptionRequest
                {
                    Title = RequestTitles[_rand.Next(RequestTitles.Length)],
                    Description = RequestDescriptions[_rand.Next(RequestDescriptions.Length)],
                    Cost = Decimal.Round((decimal)(_rand.NextDouble() * 5_000_000 + 200_000), 2),
                    CreatedAt = reqCreated,
                    UpdatedAt = reqCreated.AddMinutes(_rand.Next(1, 300))
                };
                reception.Requests.Add(req);
                reception.TotalCost += req.Cost;
            }

            // تولید چند هزینه مرتبط
            int expCount = _rand.Next(0, 4);
            for (int e = 0; e < expCount; e++)
            {
                var expCreated = created.AddMinutes(_rand.Next(0, 60 * 24));
                var expense = new CarReceptionExpense
                {
                    Title = ExpenseTitles[_rand.Next(ExpenseTitles.Length)],
                    Description = ExpenseDescriptions[_rand.Next(ExpenseDescriptions.Length)],
                    PaidTo = People[_rand.Next(People.Length)],
                    PaymentMethod = PaymentMethods[_rand.Next(PaymentMethods.Length)],
                    Amount = Decimal.Round((decimal)(_rand.NextDouble() * 2_000_000 + 50_000), 2),
                    CreatedAt = expCreated,
                    UpdatedAt = expCreated.AddMinutes(_rand.Next(1, 300))
                };
                reception.Expenses.Add(expense);
                reception.TotalExpenses += expense.Amount;
            }

            // در صورت نیاز می‌توان TotalProfit را محاسبه کرد (اگر مدل آن را نگه می‌دارد)
            // reception.TotalProfit = reception.TotalCost - reception.TotalExpenses;

            return reception;
        }
    }

}
