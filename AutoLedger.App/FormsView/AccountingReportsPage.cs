using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class AccountingReportsPage : UserControl
    {

        public AccountingReportsPage()
        {
            InitializeComponent();

            dgExpenses.AutoGenerateColumns = false;

            this.btnRefresh.Click += BtnRefresh_Click;

            RefreshData();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            dgExpenses.DataSource = null;
            using (var db = new AutoLedgerContext())
            {
                var list = db.MonthlySummaries
                    .AsNoTracking()
                    .OrderByDescending(m => m.Year)
                    .ThenByDescending(m => m.Month)
                    .ThenByDescending(m => m.Day)
                    .ToList();

                dgExpenses.DataSource = list;
            }
        }
    }
}
