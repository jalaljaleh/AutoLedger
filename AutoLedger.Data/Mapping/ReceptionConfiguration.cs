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
    public class ReceptionConfiguration : EntityTypeConfiguration<Reception>
    {
        public ReceptionConfiguration()
        {
            ToTable("Receptions");

            Property(a => a.Id)
                   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

       
            Property(a => a.CarPlateId).HasMaxLength(20).IsRequired();
            Property(a => a.CarBrand).HasMaxLength(50);
            Property(a => a.CarColor).HasMaxLength(30);
            Property(a => a.CarTip).HasMaxLength(100);

            Property(a => a.FullName).HasMaxLength(150).IsRequired();
            Property(a => a.NationalId).HasMaxLength(10).IsRequired();
            Property(a => a.PhoneNumber).HasMaxLength(15).IsRequired();

    
            HasIndex(a => a.CarPlateId).HasName("IX_Receptions_CarPlateId");
            HasIndex(a => a.NationalId).HasName("IX_Receptions_NationalId");
            HasIndex(a => a.PhoneNumber).HasName("IX_Receptions_PhoneNumber");
        
            HasIndex(a => a.FullName).HasName("IX_Receptions_FullName");

            HasMany(a=>a.Requests)
                .WithRequired(a=>a.Reception)
                .HasForeignKey(a=>a.ReceptionId)
                .WillCascadeOnDelete(true);
        }
    }
}
