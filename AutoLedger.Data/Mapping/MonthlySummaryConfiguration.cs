using AutoLedger.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AutoLedger.Data.Mapping
{
    public class MonthlySummaryConfiguration : EntityTypeConfiguration<MonthlySummary>
    {
        public MonthlySummaryConfiguration()
        {
            ToTable("MonthlySummaries");

            HasKey(m => m.Id);

            Property(m => m.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(m => m.Year)
                .IsRequired();

            Property(m => m.Month)
                .IsRequired();

            Property(m => m.Day)
                .IsRequired();

            Property(m => m.Revenue)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(m => m.Expenses)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(m => m.CreatedAt)
                .HasColumnType("datetime2")
                .IsRequired();

            Ignore(a => a.Profit);
        }
    }
}
