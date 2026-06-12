using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite.EF6;
using System.Data.Entity;
using System.IO;
using AutoLedger.Domain;
using AutoLedger.Data.Mapping;

namespace AutoLedger.Data
{
    public class AutoLedgerContext : DbContext
    {
        public AutoLedgerContext() : base($@"Data Source=(LocalDB)\MSSQLLocalDB;
                      AttachDbFilename={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "IronTuning.mdf")};
                      Integrated Security=True;
                      Connect Timeout=30")
        {

        }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<ReceptionRequest> CarRequests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ReceptionConfiguration());
            modelBuilder.Configurations.Add(new ReceptionRequestsConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
