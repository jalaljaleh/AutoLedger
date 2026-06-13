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
    public class CarConfiguration : EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
        {
            ToTable("Cars");

            Property(a => a.Id)
                   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.CarPlateId).HasMaxLength(20).IsRequired();
            Property(a => a.Brand).HasMaxLength(50);
            Property(a => a.Color).HasMaxLength(30);
            Property(a => a.Tip).HasMaxLength(100);

            Property(a => a.OwnerFullName).HasMaxLength(150).IsRequired();
            Property(a => a.OwnerNationalId).HasMaxLength(10).IsRequired();
            Property(a => a.OwnerPhoneNumber).HasMaxLength(15).IsRequired();


            HasIndex(a => a.CarPlateId).HasName("IX_Receptions_CarPlateId");
            HasIndex(a => a.OwnerNationalId).HasName("IX_Receptions_NationalId");
            HasIndex(a => a.OwnerPhoneNumber).HasName("IX_Receptions_PhoneNumber");

            HasIndex(a => a.OwnerFullName).HasName("IX_Receptions_FullName");

            HasMany(a => a.Receptions)
                .WithRequired(a => a.Car)
                .HasForeignKey(a => a.CarId)
                .WillCascadeOnDelete(true);

            HasMany(a => a.Requests)
              .WithRequired(a => a.Car)
              .HasForeignKey(a => a.CarId)
              .WillCascadeOnDelete(true);
        }
    }
}
