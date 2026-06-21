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
    public class ExpenseConfiguration : EntityTypeConfiguration<Expense>
    {
        public ExpenseConfiguration()
        {
            ToTable("Expenses");

            Property(e => e.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.Title)
                .HasMaxLength(200)
                .IsRequired();

            Property(e => e.Description)
                .IsOptional();

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

  
            HasOptional(e => e.RelatedReception)
                .WithMany(r => r.Expenses)
                .HasForeignKey(e => e.RelatedReceptionId)
                .WillCascadeOnDelete(false);

          
            HasIndex(e => e.RelatedReceptionId).HasName("IX_Expenses_RelatedReceptionId");
        }
    }
}
