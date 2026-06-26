using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class ExpensesManagerPage : UserControl
    {

        private int _expensesPage = 0;
        private int _expensesPageSize = 50;
        private int _expensesDaysAgo = 0;

        public ExpensesManagerPage()
        {
            InitializeComponent();

            RefreshRows();


            this.btnRefresh.Click += BtnRefresh_Click;
            this.btnNextPage.Click += BtnNextPage_Click;
            this.btnBackPage.Click += BtnBackPage_Click;
            this.btnFilterToday.Click += BtnFilterToday_Click;
            this.btnFilterWeek.Click += BtnFilterWeek_Click;
            this.btnFilterMonth.Click += BtnFilterMonth_Click;
            this.btnFilterAllTimes.Click += BtnFilterAllTimes_Click;

            this.cbCount.SelectedItem = 50;
            this.cbCount.SelectedIndexChanged += CbCount_SelectedIndexChanged;

            this.dgExpenses.RowPostPaint += DgCarReceptions_RowPostPaint;

        }

        private void BtnFilterAllTimes_Click(object sender, EventArgs e)
        {
            _expensesDaysAgo = -1; 
            _expensesPage = 0;
            RefreshRows();
        }

        private void BtnFilterToday_Click(object sender, EventArgs e)
        {
            _expensesDaysAgo = 1; 
            _expensesPage = 0;
            RefreshRows();
        }

        private void BtnFilterWeek_Click(object sender, EventArgs e)
        {
            _expensesDaysAgo = 7; 
            _expensesPage = 0;
            RefreshRows();
        }

        private void BtnFilterMonth_Click(object sender, EventArgs e)
        {
            _expensesDaysAgo = 30;
            _expensesPage = 0;
            RefreshRows();
        }

        public void RefreshRows()
        {
            using (var db = new AutoLedgerContext())
            {
                dgExpenses.AutoGenerateColumns = false;

                IQueryable<CarReceptionExpense> query = db.CarReceptionsExpenses;

              
                if (_expensesDaysAgo > 0)
                {
                    DateTime fromDate = DateTime.Today.AddDays(-_expensesDaysAgo);
                    query = query.Where(x => DbFunctions.TruncateTime(x.CreatedAt) >= fromDate);
                }

                var list = query
                    .OrderByDescending(c => c.Id)
                    .Skip(_expensesPage * _expensesPageSize)
                    .Take(_expensesPageSize)
                    .AsNoTracking()
                    .ToList();

                btnBackPage.Enabled = (_expensesPage > 0);
                btnNextPage.Enabled = (list.Count >= _expensesPageSize);

                this.labelDetails.Text = $"صفحه: {_expensesPage + 1} | تعداد: {list.Count} | فیلتر: {(_expensesDaysAgo > 0 ? $"گذشته {_expensesDaysAgo} روز" : "همه زمان ها")} | جمع کل هزینه ها: {list.Sum(a=>a.Amount)}";
               
                dgExpenses.DataSource = list;
            }
        }

        private void DgCarReceptions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgExpenses.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        private void CbCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCount.SelectedItem == null) return;

            if (cbCount.SelectedItem is int i)
                _expensesPageSize = i;
            else
            {
                if (int.TryParse(cbCount.SelectedItem.ToString(), out int parsed))
                    _expensesPageSize = parsed;
            }
            _expensesPage = 0;
            RefreshRows();
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            _expensesPage = 0;
            _expensesPageSize = 50;
            RefreshRows();
        }

       

        private void BtnBackPage_Click(object sender, EventArgs e)
        {
            if (_expensesPage <= 0) return;

            _expensesPage--;
            RefreshRows();
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            _expensesPage++;
            RefreshRows();
        }
    }
}
