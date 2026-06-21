using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Data.Mapping
{
    using global::AutoLedger.Domain;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.ModelConfiguration;

    namespace AutoLedger.Data.Mapping
    {
        public class MonthlySummaryConfiguration : EntityTypeConfiguration<MonthlySummary>
        {
            public MonthlySummaryConfiguration()
            {
                ToTable("MonthlySummaries");

                Property(m => m.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(m => m.Year).IsRequired();
                Property(m => m.Month).IsRequired();

                Property(m => m.TotalRevenue)
                    .HasColumnType("decimal")
                    .HasPrecision(18, 2)
                    .IsRequired();

                Property(m => m.TotalExpenses)
                    .HasColumnType("decimal")
                    .HasPrecision(18, 2)
                    .IsRequired();

                Property(m => m.CreatedAt)
                    .HasColumnType("datetime2")
                    .IsRequired();

        
            }
        }
    }

}
