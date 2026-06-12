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
    public class ReceptionRequestsConfiguration : EntityTypeConfiguration<ReceptionRequest>
    {
        public ReceptionRequestsConfiguration()
        {
            ToTable("ReceptionRequests");

            Property(a => a.Id)
                   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          
            Property(a => a.Title).HasMaxLength(200).IsRequired();
            Property(a => a.Description).HasMaxLength(1000);

            HasIndex(a => a.ReceptionId).HasName("IX_ReceptionRequests_ReceptionId");
        }
    }
}
