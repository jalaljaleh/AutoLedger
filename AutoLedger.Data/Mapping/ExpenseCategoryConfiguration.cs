using AutoLedger.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace AutoLedger.Data.Mapping
{
    public class ExpenseCategoryConfiguration : EntityTypeConfiguration<ExpenseCategory>
    {
        public ExpenseCategoryConfiguration()
        {
            ToTable("ExpenseCategories");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnAnnotation(
                    "Index",
                    new IndexAnnotation(new IndexAttribute("IX_ExpenseCategory_Name") { IsUnique = true })
                );

            // Navigation: Category → Expenses
            HasMany(c => c.Expenses)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);
        }
    }
}
