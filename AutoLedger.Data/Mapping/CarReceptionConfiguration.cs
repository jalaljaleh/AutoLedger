using AutoLedger.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Data.Mapping
{
    public class CarReceptionConfiguration : EntityTypeConfiguration<CarReception>
    {
        public CarReceptionConfiguration()
        {
            ToTable("CarReceptions");

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Mileage).IsRequired();

   
            Property(a => a.TotalCost)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            this.Property(a => a.RepairedAt).HasColumnType("datetime2");
            this.Property(a => a.ReleasedAt).HasColumnType("datetime2");

            this.Property(a => a.CreatedAt).HasColumnType("datetime2");
            this.Property(a => a.UpdatedAt).HasColumnType("datetime2");

            HasMany(a => a.Requests)
                .WithRequired(a => a.Reception)
                .HasForeignKey(a => a.ReceptionId)
                .WillCascadeOnDelete(true);

   
            HasMany(a => a.Expenses)
                .WithOptional(e => e.RelatedReception)
                .HasForeignKey(e => e.RelatedReceptionId)
                .WillCascadeOnDelete(false);
        }

    }
}
