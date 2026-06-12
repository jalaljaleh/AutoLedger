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
    public class CarRequestsConfiguration : EntityTypeConfiguration<CarRequest>
    {
        public CarRequestsConfiguration()
        {
            ToTable("CarRequests");

            Property(a => a.Id)
                   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasIndex(a=>a.CarId);
            HasIndex(a=>a.Title);
        }
    }
}
