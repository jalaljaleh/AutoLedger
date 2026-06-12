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

            HasIndex(a=>a.PlateId);
            HasIndex(a=>a.NationalId);
            HasIndex(a=>a.PhoneNumber);
            HasIndex(a=>a.FullName);
            HasIndex(a=>a.IsReleased);

            HasMany(a=>a.Requests)
                .WithRequired(a=>a.Car)
                .HasForeignKey(a=>a.CarId)
                .WillCascadeOnDelete(true);
        }
    }
}
