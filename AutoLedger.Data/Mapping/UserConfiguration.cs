using AutoLedger.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLedger.Data.Mapping
{

    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");

            HasKey(m => m.Id);

            Property(e => e.FullName)
              .IsRequired()
              .HasMaxLength(100);

            Property(e => e.PhoneNumber)
             .HasMaxLength(15);

            Property(e => e.NationalId)
             .HasMaxLength(11);

            Property(e => e.Password)
            .HasMaxLength(15);

            Property(e => e.Address)
           .HasMaxLength(200);

            Property(e => e.Description)
            .HasMaxLength(500);
        }

    }
}
