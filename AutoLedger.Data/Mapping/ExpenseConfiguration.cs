using AutoLedger.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace AutoLedger.Data.Mapping
{
    public class ExpenseConfiguration : EntityTypeConfiguration<Expense>
    {
        public ExpenseConfiguration()
        {
            ToTable("Expenses");

            HasKey(e => e.Id);

            Property(e => e.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Description)
                .HasMaxLength(300);

            Property(e => e.Amount)
                .HasColumnType("decimal")
                .HasPrecision(18, 2)
                .IsRequired();


            // FK → Category
            Property(e => e.CategoryId)
                .IsRequired()
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_Expense_CategoryId"))
                );

            HasRequired(e => e.Category)
                .WithMany(c => c.Expenses)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            Property(e => e.CreatedAt)
                .HasColumnType("datetime2")
                .IsRequired();

            Property(e => e.UpdatedAt)
                .HasColumnType("datetime2")
                .IsRequired();
        }
    }
}
