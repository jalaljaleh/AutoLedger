using AutoLedger.Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace AutoLedger.Data.Services
{
    public class SummaryService 
    {
        private readonly DbContext _context;

        public SummaryService(DbContext context)
        {
            _context = context;
        }

        public void ApplyEntrySummary(DbEntityEntry entry)
        {
            if (entry == null) return;

            if (entry.Entity is Expense)
            {
                ApplyExpenseSummary(entry);
            }
            else if (entry.Entity is CarReception)
            {
                ApplyCarReceptionSummary(entry);
            }
        }

        private void ApplyExpenseSummary(DbEntityEntry entry)
        {
            var expense = (Expense)entry.Entity;

            DateTime date;
            decimal delta = 0m;

            if (entry.State == EntityState.Added)
            {
                date = expense.ExpenseDate;
                delta = expense.Amount; // افزایش هزینه
            }
            else if (entry.State == EntityState.Deleted)
            {
                // در حذف از OriginalValues استفاده می‌کنیم
                object origDateObj = entry.OriginalValues["ExpenseDate"];
                date = origDateObj is DateTime ? (DateTime)origDateObj : expense.ExpenseDate;

                object origAmountObj = entry.OriginalValues["Amount"];
                decimal origAmount = origAmountObj != null ? Convert.ToDecimal(origAmountObj) : 0m;
                delta = -origAmount; // کاهش هزینه
            }
            else if (entry.State == EntityState.Modified)
            {
                // تاریخ فعلی را از موجودیت می‌گیریم
                date = expense.ExpenseDate;

                object origAmountObj = entry.OriginalValues["Amount"];
                decimal origAmount = origAmountObj != null ? Convert.ToDecimal(origAmountObj) : 0m;
                decimal currentAmount = expense.Amount;
                delta = currentAmount - origAmount; // مثبت یا منفی
            }
            else
            {
                return;
            }

            if (delta == 0m) return;

            ApplyToMonthlySummary(date, expenseDelta: delta, revenueDelta: 0m);

        }

        private void ApplyCarReceptionSummary(DbEntityEntry entry)
        {
            var reception = (CarReception)entry.Entity;

            DateTime date;
            decimal revenueDelta = 0m;
            decimal expensesDelta = 0m;

            if (entry.State == EntityState.Added)
            {
                // در زمان ایجاد، فرض می‌کنیم TotalCost و TotalExpenses مقداردهی اولیه شده‌اند
                date = reception.CreatedAt;
                revenueDelta = reception.TotalCost;
                expensesDelta = reception.TotalExpenses;
            }
            else if (entry.State == EntityState.Deleted)
            {
                object origCreatedObj = entry.OriginalValues.PropertyNames.Contains("CreatedAt") ? entry.OriginalValues["CreatedAt"] : null;
                date = origCreatedObj is DateTime ? (DateTime)origCreatedObj : reception.CreatedAt;

                object origCostObj = entry.OriginalValues.PropertyNames.Contains("TotalCost") ? entry.OriginalValues["TotalCost"] : null;
                decimal origCost = origCostObj != null ? Convert.ToDecimal(origCostObj) : 0m;
                revenueDelta = -origCost;

                object origExpObj = entry.OriginalValues.PropertyNames.Contains("TotalExpenses") ? entry.OriginalValues["TotalExpenses"] : null;
                decimal origExp = origExpObj != null ? Convert.ToDecimal(origExpObj) : 0m;
                expensesDelta = -origExp;
            }
            else if (entry.State == EntityState.Modified)
            {
                // برای تغییرات، مقادیر فعلی و اصلی را مقایسه می‌کنیم
                date = reception.UpdatedAt != DateTime.MinValue ? reception.UpdatedAt : DateTime.Now;

                object origCostObj = entry.OriginalValues.PropertyNames.Contains("TotalCost") ? entry.OriginalValues["TotalCost"] : null;
                decimal origCost = origCostObj != null ? Convert.ToDecimal(origCostObj) : 0m;
                decimal currentCost = reception.TotalCost;
                revenueDelta = currentCost - origCost;

                object origExpObj = entry.OriginalValues.PropertyNames.Contains("TotalExpenses") ? entry.OriginalValues["TotalExpenses"] : null;
                decimal origExp = origExpObj != null ? Convert.ToDecimal(origExpObj) : 0m;
                decimal currentExp = reception.TotalExpenses;
                expensesDelta = currentExp - origExp;

                // اگر وضعیت انتشار (مثلاً IsReleased) تغییر کرده و می‌خواهی فقط هنگام Release درآمد را ثبت کنی،
                // می‌توانی اینجا بررسی کنی:
                // object origReleased = entry.OriginalValues["IsReleased"];
                // bool origIsReleased = origReleased != null && Convert.ToBoolean(origReleased);
                // if (!origIsReleased && reception.IsReleased) { /* push revenue */ }
            }
            else
            {
                return;
            }

            // اگر هیچ دلتا وجود ندارد، کاری انجام نده
            if (revenueDelta == 0m && expensesDelta == 0m) return;

            ApplyToMonthlySummary(date, expenseDelta: expensesDelta, revenueDelta: revenueDelta);
        }

        private void ApplyToMonthlySummary(DateTime date, decimal expenseDelta, decimal revenueDelta)
        {
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;

            var summaries = _context.Set<MonthlySummary>();
            var summary = summaries.FirstOrDefault(s => s.Year == year && s.Month == month && s.Day == day);

            if (summary == null)
            {
                summary = new MonthlySummary
                {
                    Year = year,
                    Month = month,
                    Day = day,
                   Expenses = 0m,
                    Revenue = 0m,
                    CreatedAt = DateTime.Now
                };
                summaries.Add(summary);
            }

            summary.Expenses += expenseDelta;
            summary.Revenue += revenueDelta;
        }
    }

}