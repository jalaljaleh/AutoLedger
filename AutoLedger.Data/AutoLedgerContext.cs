using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite.EF6;
using System.Data.Entity;
using System.IO;

namespace AutoLedger.Data
{
    public class AutoLedgerContext : DbContext
    {
        public AutoLedgerContext() : base($@"Data Source=(LocalDB)\MSSQLLocalDB;
                      AttachDbFilename={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HalunDb.mdf")};
                      Integrated Security=True;
                      Connect Timeout=30")
        {

        }
      //  public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // modelBuilder.Configurations.Add(new UserConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
