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
                    new IndexAnnotation(new IndexAttribute("IX_Car_CarPlateId") { IsUnique = false }));

            Property(a => a.Brand)
                .HasMaxLength(20);


            Property(a => a.Color)
                .HasMaxLength(20);

            Property(a => a.Tip)
                .HasMaxLength(20);

            Property(a => a.OwnerFullName)
                .IsRequired()
                .HasMaxLength(25)
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_Car_FullName") { IsUnique = false }));

            Property(a => a.OwnerNationalId)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_Car_NationalId") { IsUnique = false}));

            Property(a => a.OwnerPhoneNumber)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_Car_PhoneNumber") { IsUnique = false }));

            HasMany(a => a.Receptions)
                .WithRequired(r => r.Car)
                .HasForeignKey(r => r.CarId)
                .WillCascadeOnDelete(true);
        }
    }
}
