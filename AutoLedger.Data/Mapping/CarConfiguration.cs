using AutoLedger.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;

namespace AutoLedger.Data.Mapping
{
    public class CarConfiguration : EntityTypeConfiguration<Car>
    {
        public CarConfiguration()
        {
            ToTable("Cars");

            HasKey(a => a.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.PlateId)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_Receptions_CarPlateId") { IsUnique = false }));

            Property(a => a.Brand)
                .HasMaxLength(50);

            Property(a => a.Color)
                .HasMaxLength(30);

            Property(a => a.Tip)
                .HasMaxLength(100);

            Property(a => a.OwnerFullName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_Receptions_FullName") { IsUnique = false }));

            Property(a => a.OwnerNationalId)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_Receptions_NationalId") { IsUnique = false }));

            Property(a => a.OwnerPhoneNumber)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_Receptions_PhoneNumber") { IsUnique = false }));

            HasMany(a => a.Receptions)
                .WithRequired(r => r.Car)
                .HasForeignKey(r => r.CarId)
                .WillCascadeOnDelete(true);
        }
    }
}
