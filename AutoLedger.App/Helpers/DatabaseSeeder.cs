using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Collections.Generic;

namespace AutoLedger.App
{
    public static class DatabaseSeeder
    {

        public static void SeedCarsAndCarReceptions(AutoLedgerContext db, int carsCount = 100, int receptionsCount = 5)
        {
            var cars = CarFactory.Generate(carsCount);
           
            foreach (var car in cars)
             CarReceptionFactory.GenerateForCar(car, receptionsCount);
            
            db.Cars.AddRange(cars);
        }
        public static void SeedUsers(AutoLedgerContext db)
        {
            db.Users.AddRange(new List<User>
            {
                new User { FullName = "محمدجلال ژاله", Password = "jj" },
                new User { FullName = "فرید عزیزی", Password = "admin" }
            });
        }

        public static void SeedExpenseCategories(AutoLedgerContext db)
        {
            var categories = new List<string>
            {
                "هزینه‌های عمومی", "مواد مصرفی", "اجاره بها", "قبوض و خدمات",
                "حمل‌ونقل و جابه‌جایی", "حقوق و دستمزد", "ابزار و تجهیزات",
                "قطعات و لوازم یدکی", "نظافت و بهداشت", "مالیات و امور قانونی",
                "بازاریابی و تبلیغات"
            };

            foreach (var name in categories)
            {
                db.ExpenseCategories.Add(new ExpenseCategory().WithName(name));
            }
        }
    }
}