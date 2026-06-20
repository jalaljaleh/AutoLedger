using AutoLedger.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.labelVersion.Text = Program.Version;

            Task.Run(()=> InitializeDatabase());
        }

        private async Task InitializeDatabase()
        {
            try
            {
                using (AutoLedgerContext db = new AutoLedgerContext())
                {
                    if (Program.IsDebugMode() && db.Database.Exists())
                        ;// db.Database.Delete();
                    else
                        db.Database.CreateIfNotExists();
                }
                
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                this.DialogResult = DialogResult.No;
            }
         //   await Task.Delay(4000);
            this.Close();

        }
    }
}
