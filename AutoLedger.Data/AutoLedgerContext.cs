using AutoLedger.Data.Mapping;
using AutoLedger.Data.Services;
using AutoLedger.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite.EF6;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Data
{
    public class AutoLedgerContext : DbContext
    {
        private readonly SummaryService _summaryService;
        public AutoLedgerContext() : base($@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IronTuning.mdf")}; Integrated Security=True; Connect Timeout=30; Context Connection=false;")
        {
            _summaryService = new SummaryService(this);
        }

        public DbSet<User> Users { get; set; }


        public DbSet<Car> Cars { get; set; }
        public DbSet<CarReception> CarReceptions { get; set; }
        public DbSet<CarReceptionRequest> CarReceptionsRequests { get; set; }
        public DbSet<CarReceptionExpense> CarReceptionsExpenses { get; set; }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }

        public DbSet<Debt> Debts { get; set; }


        public DbSet<DailyLedgerSummary> DailySummaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());

            modelBuilder.Configurations.Add(new CarConfiguration());
            modelBuilder.Configurations.Add(new CarReceptionConfiguration());
            modelBuilder.Configurations.Add(new CarReceptionRequestsConfiguration());
            modelBuilder.Configurations.Add(new CarReceptionExpenseConfiguration());

            modelBuilder.Configurations.Add(new ExpenseConfiguration());
            modelBuilder.Configurations.Add(new ExpenseCategoryConfiguration());

            modelBuilder.Configurations.Add(new DebtConfiguration());

            modelBuilder.Configurations.Add(new DailyLedgerSummaryConfiguration());

            this.Configuration.LazyLoadingEnabled = false;

            base.OnModelCreating(modelBuilder);
        }


        public override int SaveChanges()
        {
            var validStates = new[] { EntityState.Added, EntityState.Modified, EntityState.Deleted };

            var changedEntries = ChangeTracker.Entries()
                .Where(e => (e.Entity is Expense || e.Entity is CarReception || e.Entity is Car) && // <-- ADDED CAR HERE
                            validStates.Contains(e.State))
                .ToList();

            if (changedEntries.Any())
            {
                _summaryService.ProcessChanges(changedEntries);
            }

            return base.SaveChanges();
        }




    }
}
