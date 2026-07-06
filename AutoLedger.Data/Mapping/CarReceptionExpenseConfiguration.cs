using AutoLedger.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace AutoLedger.Data.Mapping
{
    public class CarReceptionExpenseConfiguration : EntityTypeConfiguration<CarReceptionExpense>
    {
        public CarReceptionExpenseConfiguration()
        {
            ToTable("CarReceptionExpenses");

            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.Title)
                .HasMaxLength(100)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CarReceptionExpenses_Title")) );

            Property(e => e.Description)
                .HasMaxLength(200);

            Property(e => e.PaidTo)
              .HasMaxLength(100)
              .HasColumnAnnotation(
                  IndexAnnotation.AnnotationName,
                  new IndexAnnotation(new IndexAttribute("IX_CarReceptionExpenses_PaidTo")));

            Property(e => e.PaymentMethod)
              .HasMaxLength(100)
              .HasColumnAnnotation(
                  IndexAnnotation.AnnotationName,
                  new IndexAnnotation(new IndexAttribute("IX_CarReceptionExpenses_PaymentMethod")));


            Property(e => e.Amount)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(e => e.CreatedAt)
                .HasColumnType("datetime2")
                .IsRequired();

            Property(e => e.UpdatedAt)
                .HasColumnType("datetime2")
                .IsRequired();
        }
    }
}
