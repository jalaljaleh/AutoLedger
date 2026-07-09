using AutoLedger.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AutoLedger.Data.Mapping
{
    public class DailyLedgerSummaryConfiguration : EntityTypeConfiguration<DailyLedgerSummary>
    {
        public DailyLedgerSummaryConfiguration()
        {
            ToTable("DailySummaries");

            // --- Primary Key ---
            HasKey(m => m.Id);

            Property(m => m.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // --- Date Tracking ---
            Property(m => m.Date)
                .HasColumnType("date") // 'date' is better than 'datetime2' here since time doesn't matter
                .IsRequired();

            // Safety net: Guarantee only one summary row per day at the database level
            HasIndex(m => m.Date)
                .IsUnique()
                .HasName("IX_DailySummaries_Date");

            Property(m => m.Year).IsRequired();
            Property(m => m.Month).IsRequired();
            Property(m => m.Day).IsRequired();

            // --- Financials ---
            Property(m => m.ShopExpenses)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(m => m.ReceptionExpenses)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(m => m.ReceptionRevenue)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            // --- Activity Counters ---
            Property(m => m.ShopExpensesCount).IsRequired();
            Property(m => m.NewCarsRegistered).IsRequired();
            Property(m => m.ReceptionsOpened).IsRequired();
            Property(m => m.ReceptionsRepaired).IsRequired();
            Property(m => m.ReceptionsReleased).IsRequired();

            // --- Timestamps ---
            Property(m => m.CreatedAt)
                .HasColumnType("datetime2")
                .IsRequired();

            Property(m => m.UpdatedAt)
                .HasColumnType("datetime2")
                .IsRequired();

            // --- Ignored Computed Properties ---
            Ignore(m => m.TotalRevenue);
            Ignore(m => m.TotalExpenses);
            Ignore(m => m.Profit);
        }
    }
}