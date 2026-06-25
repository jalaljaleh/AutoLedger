using AutoLedger.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AutoLedger.Data.Mapping
{
    public class CarReceptionConfiguration : EntityTypeConfiguration<CarReception>
    {
        public CarReceptionConfiguration()
        {
            ToTable("CarReceptions");

            HasKey(a => a.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Mileage)
                .IsRequired();

            Ignore(a => a.TotalProfit);

            Property(a => a.TotalCost)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(a => a.TotalExpenses)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(a => a.RepairedAt)
                .HasColumnType("datetime2");

            Property(a => a.ReleasedAt)
                .HasColumnType("datetime2");

            Property(a => a.CreatedAt)
                .HasColumnType("datetime2");

            Property(a => a.UpdatedAt)
                .HasColumnType("datetime2");

            HasMany(a => a.Requests)
                .WithRequired(r => r.Reception)
                .HasForeignKey(r => r.ReceptionId)
                .WillCascadeOnDelete(true);

            HasMany(a => a.Expenses)
                .WithRequired(e => e.Reception)
                .HasForeignKey(e => e.ReceptionId)
                .WillCascadeOnDelete(true);
        }
    }
}
