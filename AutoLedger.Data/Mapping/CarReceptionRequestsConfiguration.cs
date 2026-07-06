using AutoLedger.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace AutoLedger.Data.Mapping
{
    public class CarReceptionRequestsConfiguration : EntityTypeConfiguration<CarReceptionRequest>
    {
        public CarReceptionRequestsConfiguration()
        {
            ToTable("CarReceptionRequests");

            HasKey(a => a.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(200)
                   .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_CarReceptionRequests_Title") { IsUnique = false })); ;

            Property(a => a.Description)
                .HasMaxLength(1000);

            Property(a => a.ReceptionId)
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_CarReceptionRequests_ReceptionId") { IsUnique = false }));
        }
    }
}
