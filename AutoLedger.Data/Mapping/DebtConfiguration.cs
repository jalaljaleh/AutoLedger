using AutoLedger.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace AutoLedger.Data
{
    public class DebtConfiguration : EntityTypeConfiguration<Debt>
    {
        public DebtConfiguration()
        {
            ToTable("Debts");
            HasKey(d => d.Id);

            Property(d => d.Title).HasMaxLength(100).IsRequired();

            Property(d => d.DebtTo)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Debt_DebtTo")));
          
            Property(d => d.Type)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Debt_Type_IsSettled", 1)));

            Property(d => d.IsSettled)
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_Debt_Type_IsSettled", 2)));
        }
    }
}