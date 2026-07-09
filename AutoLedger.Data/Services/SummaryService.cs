using AutoLedger.Domain;
using System;
using System.Collections.Generic;
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

        public void ProcessChanges(IEnumerable<DbEntityEntry> entries)
        {
            var deltas = new Dictionary<DateTime, SummaryDelta>();

            foreach (var entry in entries)
            {
                if (entry.Entity is Expense expense)
                    ProcessExpense(entry, expense, deltas);

                else if (entry.Entity is CarReception reception)
                    ProcessCarReception(entry, reception, deltas);

                else if (entry.Entity is Car car)
                    ProcessCar(entry, car, deltas); // NEW: Track new customers
            }

            if (!deltas.Any()) return;

            var datesToUpdate = deltas.Keys.ToList();
            var existingSummaries = _context.Set<DailyLedgerSummary>()
                .Where(s => datesToUpdate.Contains(s.Date))
                .ToList();

            foreach (var kvp in deltas)
            {
                var date = kvp.Key;
                var delta = kvp.Value;
                var summary = existingSummaries.FirstOrDefault(s => s.Date == date);

                if (summary == null)
                {
                    summary = new DailyLedgerSummary
                    {
                        Date = date,
                        Year = date.Year,
                        Month = date.Month,
                        Day = date.Day,
                        CreatedAt = DateTime.Now
                    };
                    _context.Set<DailyLedgerSummary>().Add(summary);
                    existingSummaries.Add(summary);
                }

                // Apply Financials
                summary.ShopExpenses += delta.ShopExpenseDelta;
                summary.ReceptionRevenue += delta.ReceptionRevenueDelta;
                summary.ReceptionExpenses += delta.ReceptionExpenseDelta;

                // Apply Activity Counts
                summary.ShopExpensesCount += delta.ExpenseCountDelta;
                summary.NewCarsRegistered += delta.NewCarsDelta;
                summary.ReceptionsOpened += delta.ReceptionsOpenedDelta;
                summary.ReceptionsRepaired += delta.ReceptionsRepairedDelta;
                summary.ReceptionsReleased += delta.ReceptionsReleasedDelta;

                summary.UpdatedAt = DateTime.Now;
            }
        }

        // --- PROCESSING METHODS ---

        private void ProcessCar(DbEntityEntry entry, Car car, Dictionary<DateTime, SummaryDelta> deltas)
        {
            if (entry.State == EntityState.Added)
                AddDelta(deltas, car.CreatedAt.Date, newCars: 1);
            else if (entry.State == EntityState.Deleted)
                AddDelta(deltas, GetOriginalValue<DateTime>(entry, "CreatedAt").Date, newCars: -1);
        }

        private void ProcessExpense(DbEntityEntry entry, Expense expense, Dictionary<DateTime, SummaryDelta> deltas)
        {
            if (entry.State == EntityState.Added)
            {
                AddDelta(deltas, expense.ExpenseDate.Date, shopExp: expense.Amount, expCount: 1);
            }
            else if (entry.State == EntityState.Deleted)
            {
                // When deleted, we must subtract the original amount and decrement the count
                var origDate = GetOriginalValue<DateTime>(entry, "ExpenseDate").Date;
                var origAmount = GetOriginalValue<decimal>(entry, "Amount");

                AddDelta(deltas, origDate, shopExp: -origAmount, expCount: -1);
            }
            else if (entry.State == EntityState.Modified)
            {
                var origDate = GetOriginalValue<DateTime>(entry, "ExpenseDate").Date;
                var origAmount = GetOriginalValue<decimal>(entry, "Amount");

                var newDate = expense.ExpenseDate.Date;
                var newAmount = expense.Amount;

                if (origDate == newDate)
                {
                    // If the date is the same, just calculate the difference in the amount
                    decimal amountDiff = newAmount - origAmount;

                    if (amountDiff != 0)
                    {
                        // Count doesn't change, just the monetary difference
                        AddDelta(deltas, newDate, shopExp: amountDiff, expCount: 0);
                    }
                }
                else
                {
                    // If the date changed, remove the record from the old date entirely...
                    AddDelta(deltas, origDate, shopExp: -origAmount, expCount: -1);

                    // ...and add it to the new date
                    AddDelta(deltas, newDate, shopExp: newAmount, expCount: 1);
                }
            }
        }

        private void ProcessCarReception(DbEntityEntry entry, CarReception reception, Dictionary<DateTime, SummaryDelta> deltas)
        {
            if (entry.State == EntityState.Added)
            {
                AddDelta(deltas, reception.CreatedAt.Date,
                    recRev: reception.TotalCost,
                    recExp: reception.TotalExpenses,
                    recOpened: 1,
                    recRepaired: reception.IsRepaired ? 1 : 0,
                    recReleased: reception.IsReleased ? 1 : 0);
            }
            else if (entry.State == EntityState.Modified)
            {
                var date = reception.UpdatedAt.Date; // Record activity on the day it happened

                var origCost = GetOriginalValue<decimal>(entry, "TotalCost");
                var origExp = GetOriginalValue<decimal>(entry, "TotalExpenses");

                // Track Status Changes (Did they just click "IsRepaired = true" today?)
                var origRepaired = GetOriginalValue<bool>(entry, "IsRepaired");
                int repairedDelta = 0;
                if (!origRepaired && reception.IsRepaired) repairedDelta = 1;       // Status changed to true
                else if (origRepaired && !reception.IsRepaired) repairedDelta = -1; // Status changed to false (undo)

                var origReleased = GetOriginalValue<bool>(entry, "IsReleased");
                int releasedDelta = 0;
                if (!origReleased && reception.IsReleased) releasedDelta = 1;
                else if (origReleased && !reception.IsReleased) releasedDelta = -1;

                AddDelta(deltas, date,
                    recRev: reception.TotalCost - origCost,
                    recExp: reception.TotalExpenses - origExp,
                    recRepaired: repairedDelta,
                    recReleased: releasedDelta);
            }
        }

        // --- HELPERS ---
        private T GetOriginalValue<T>(DbEntityEntry entry, string propertyName)
        {
            if (entry.OriginalValues.PropertyNames.Contains(propertyName))
            {
                var val = entry.OriginalValues[propertyName];
                if (val != null) return (T)Convert.ChangeType(val, typeof(T));
            }
            return default(T);
        }

        private void AddDelta(Dictionary<DateTime, SummaryDelta> deltas, DateTime date,
            decimal shopExp = 0, decimal recRev = 0, decimal recExp = 0,
            int expCount = 0, int newCars = 0, int recOpened = 0, int recRepaired = 0, int recReleased = 0)
        {
            if (!deltas.ContainsKey(date)) deltas[date] = new SummaryDelta();

            deltas[date].ShopExpenseDelta += shopExp;
            deltas[date].ReceptionRevenueDelta += recRev;
            deltas[date].ReceptionExpenseDelta += recExp;
            deltas[date].ExpenseCountDelta += expCount;
            deltas[date].NewCarsDelta += newCars;
            deltas[date].ReceptionsOpenedDelta += recOpened;
            deltas[date].ReceptionsRepairedDelta += recRepaired;
            deltas[date].ReceptionsReleasedDelta += recReleased;
        }

        private class SummaryDelta
        {
            public decimal ShopExpenseDelta { get; set; }
            public decimal ReceptionRevenueDelta { get; set; }
            public decimal ReceptionExpenseDelta { get; set; }
            public int ExpenseCountDelta { get; set; }
            public int NewCarsDelta { get; set; }
            public int ReceptionsOpenedDelta { get; set; }
            public int ReceptionsRepairedDelta { get; set; }
            public int ReceptionsReleasedDelta { get; set; }
        }
    }
}