using AutoLedger.App.Forms;
using AutoLedger.Data;
using AutoLedger.Domain;
using AutoLedger.Extensions;
using DevExpress.XtraBars.Customization;
using System;
using System.Data.Entity;
using System.Drawing; // اضافه شد برای کلاس Color
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class DebtsManagerPage : UserControl
    {
        private int _pageIndex = 0;
        private int _pageSize = 200;

        public DebtsManagerPage()
        {
            InitializeComponent();

            dgDebts.AutoGenerateColumns = false;

            // اتصال رویدادهای گرید
            dgDebts.CellFormatting += DgDebts_CellFormatting;
            dgDebts.RowPostPaint += DgDebts_RowPostPaint;
            dgDebts.DataBindingComplete += DgDebts_DataBindingComplete; // اضافه شد برای رنگ‌بندی بهینه سطرها

            btnRefresh.Click += async (s, e) => await LoadDataAsync(0);
            btnNextPage.Click += async (s, e) => await LoadDataAsync(_pageIndex + 1);
            btnBackPage.Click += async (s, e) => await LoadDataAsync(_pageIndex > 0 ? _pageIndex - 1 : 0);

            btnNew.Click += BtnNew_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;

            inputSearch.TextChanged += async (s, e) => await LoadDataAsync(0);
            chkIsSettled.CheckStateChanged += async (s, e) => await LoadDataAsync(0);
            chkType.CheckStateChanged += async (s, e) => await LoadDataAsync(0);

            cbCount.SelectedIndexChanged += async (s, e) =>
            {
                if (int.TryParse(cbCount.Text, out int size)) _pageSize = size;
                await LoadDataAsync(0);
            };

            cbCount.Text = "100";
            _ = LoadDataAsync(0);
        }

        // -------------------------
        // Core Logic (Async & High Performance)
        // -------------------------

        private async Task LoadDataAsync(int pageIndex)
        {
            try
            {
                dgDebts.Enabled = false;
                Cursor = Cursors.WaitCursor;
                _pageIndex = pageIndex;

                using (var db = new AutoLedgerContext())
                {
                    var query = db.Debts.AsNoTracking().AsQueryable();

                    string search = inputSearch.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(search))
                    {
                        bool isNumeric = decimal.TryParse(search, out decimal searchAmount);
                        query = query.Where(d =>
                            d.Title.Contains(search) ||
                            d.DebtTo.Contains(search) ||
                            (isNumeric && d.Amount == searchAmount));
                    }

                    if (chkIsSettled.CheckState == CheckState.Checked)
                        query = query.Where(d => d.IsSettled == false);

                    if (chkType.CheckState == CheckState.Checked)
                        query = query.Where(d => d.Type == DebtType.Payable);

                    var page = await query
                        .OrderByDescending(d => d.CreatedAt)
                        .Skip(_pageIndex * _pageSize)
                        .Take(_pageSize)
                        .ToListAsync();

                    int totalRecordsInPage = page.Count;

                    btnBackPage.Enabled = (_pageIndex > 0);
                    btnNextPage.Enabled = (totalRecordsInPage == _pageSize);

                    var totalPayable = page.Where(x => x.Type == DebtType.Payable).Sum(x => x.Amount);
                    var totalReceivable = page.Where(x => x.Type == DebtType.Receivable).Sum(x => x.Amount);

                    labelDetails.Text = $"صفحه: {_pageIndex + 1} | تعداد در صفحه: {totalRecordsInPage}";
                    labelTotalExpenses.Text = $"پرداختنی‌ها: {totalPayable:N0} تومان | دریافتنی‌ها: {totalReceivable:N0} تومان";

                    dgDebts.DataSource = page;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری اطلاعات: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                dgDebts.Enabled = true;
            }
        }

        // -------------------------
        // DataGridView Formatting
        // -------------------------

        // متد جدید برای رنگی کردن ردیف‌ها بر اساس دیتا (بسیار روان و استاندارد)
        private void DgDebts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgDebts.Rows)
            {
                var debt = row.DataBoundItem as Debt;
                if (debt == null) continue;

                if (debt.IsSettled)
                {
                    // تسویه شده: خاکستری کمرنگ (نشان‌دهنده بایگانی/بسته شدن)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
                    row.DefaultCellStyle.ForeColor = Color.DimGray;
                }
                else if (debt.Type == DebtType.Payable)
                {
                    // پرداختنی (بدهی): قرمز/صورتی کمرنگ
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238);
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (debt.Type == DebtType.Receivable)
                {
                    // دریافتنی (طلب): سبز کمرنگ
                    row.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233);
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void DgDebts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;
            string cellName = dgDebts.Columns[e.ColumnIndex].Name;

            if (cellName == "CreatedAt")
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dt))
                {
                    e.Value = dt.ToShamsi();
                    e.FormattingApplied = true;
                }
            }
            else if (cellName == "Type")
            {
                if ((DebtType)e.Value == DebtType.Payable)
                    e.Value = "پرداختنی (بدهی)";
                else
                    e.Value = "دریافتنی (طلب)";
                e.FormattingApplied = true;
            }
            else if (cellName == "IsSettled")
            {
                e.Value = (bool)e.Value ? "تسویه شده" : "تسویه نشده";
                e.FormattingApplied = true;
            }
            else if (cellName == "Amount")
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal amount))
                {
                    e.Value = amount.ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }

        private void DgDebts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgDebts.Columns.Count > 0 && dgDebts.Rows[e.RowIndex].Cells.Count > 0)
            {
                dgDebts.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1 + _pageIndex * _pageSize).ToString();
            }
        }

        // -------------------------
        // CRUD Operations
        // -------------------------

        private Debt GetSelectedRow()
        {
            if (dgDebts.SelectedRows.Count == 0) return null;
            return dgDebts.SelectedRows[0].DataBoundItem as Debt;
        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new DebtForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                        await LoadDataAsync(_pageIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در باز کردن فرم ثبت بدهی: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow();
            if (row == null)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new AutoLedgerContext())
                {
                    var debt = await db.Debts.FirstOrDefaultAsync(x => x.Id == row.Id);
                    if (debt == null)
                    {
                        MessageBox.Show("رکورد مورد نظر یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (var form = new DebtForm(debt))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                            await LoadDataAsync(_pageIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در باز کردن فرم ویرایش: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow();
            if (row == null)
            {
                MessageBox.Show("لطفاً یک ردیف را انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"آیا از حذف '{row.Title}' اطمینان دارید؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new AutoLedgerContext())
                {
                    var debt = await db.Debts.FirstOrDefaultAsync(x => x.Id == row.Id);
                    if (debt != null)
                    {
                        db.Debts.Remove(debt);
                        await db.SaveChangesAsync();

                        MessageBox.Show("رکورد با موفقیت حذف شد.", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadDataAsync(_pageIndex);
                    }
                    else
                    {
                        MessageBox.Show("رکورد مورد نظر یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در حذف رکورد: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}