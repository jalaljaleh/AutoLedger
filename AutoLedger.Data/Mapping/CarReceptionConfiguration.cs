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

            HasMany(a=>a.Requests)
                .WithRequired(a=>a.Reception)
                .HasForeignKey(a=>a.ReceptionId)
                .WillCascadeOnDelete(true);
        }
    }
}
