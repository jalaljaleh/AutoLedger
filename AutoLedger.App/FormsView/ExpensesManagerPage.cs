using AutoLedger.App.Forms;
using AutoLedger.Data;
using AutoLedger.Domain;
using AutoLedger.Extensions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class ExpensesManagerPage : UserControl
    {
        private int _pageIndex = 0;
        private int _pageSize = 200;
        private int _daysAgo = -1;

        // DTO for DataGridView binding.
        // Property 'Id' is used directly so designer auto-mapping works.
        private class ExpenseRow
        {
            public int Id { get; set; }
            public int? ReceptionId { get; set; } // Null indicates a general editable expense
            public decimal Amount { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string PaidTo { get; set; }
            public string CategoryName { get; set; }
            public string PaymentMethod { get; set; }
            public DateTime CreatedAt { get; set; }
        }

        public ExpensesManagerPage()
        {
            InitializeComponent();

            dgExpenses.AutoGenerateColumns = false;
            dgExpenses.CellFormatting += DgExpenses_CellFormatting;
            // Wire events compactly
            btnRefresh.Click += async (s, e) => await LoadDataAsync(0);
            btnNextPage.Click += async (s, e) => await LoadDataAsync(_pageIndex + 1);
            btnBackPage.Click += async (s, e) => await LoadDataAsync(_pageIndex > 0 ? _pageIndex - 1 : 0);

            btnFilterToday.Click += async (s, e) => await SetFilterAsync(1);
            btnFilterWeek.Click += async (s, e) => await SetFilterAsync(7);
            btnFilterMonth.Click += async (s, e) => await SetFilterAsync(30);
            btnFilterAllTimes.Click += async (s, e) => await SetFilterAsync(-1);

            btnNew.Click += BtnNew_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;

            cbCount.SelectedIndexChanged += async (s, e) =>
            {
                if (int.TryParse(cbCount.Text, out int size))
                    _pageSize = size;
                await LoadDataAsync(0);
            };

            dgExpenses.RowPostPaint += DgExpenses_RowPostPaint;

            // Initialize default values and load data
            cbCount.Text = "200";
            _ = LoadDataAsync(0);
        }

        private void DgExpenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;
            string cellName = dgExpenses.Columns[e.ColumnIndex].Name;

            if ((cellName == "ExpenseDate" || cellName == "CreatedAt" || cellName == "UpdatedAt"))
            {
                DateTime dt;
                if (DateTime.TryParse(e.Value.ToString(), out dt))
                {
                    e.Value = dt.ToShamsi();
                    e.FormattingApplied = true;
                }
            }
        }

        // -------------------------
        // Core Logic (Async)
        // -------------------------

        private async Task SetFilterAsync(int daysAgo)
        {
            _daysAgo = daysAgo;
            await LoadDataAsync(0);
        }

        private async Task LoadDataAsync(int pageIndex)
        {
            try
            {
                dgExpenses.Enabled = false;
                Cursor = Cursors.WaitCursor;
                _pageIndex = pageIndex;

                using (var db = new AutoLedgerContext())
                {
                    DateTime? fromDate = _daysAgo > 0 ? DateTime.Today.AddDays(-_daysAgo) : (DateTime?)null;
                    int skip = _pageIndex * _pageSize;

                    // 1. Fetch general expenses
                    var expQuery = db.Expenses.Include(e => e.Category).AsQueryable();
                    if (fromDate.HasValue)
                        expQuery = expQuery.Where(e => DbFunctions.TruncateTime(e.CreatedAt) >= fromDate.Value);

                    var expensesBatch = await expQuery
                        .OrderByDescending(e => e.CreatedAt)
                        .Skip(skip)
                        .Take(_pageSize)
                        .Select(e => new ExpenseRow
                        {
                            Id = e.Id,
                            ReceptionId = null, // General expense
                            Title = e.Title,
                            Description = e.Description,
                            Amount = e.Amount,
                            CreatedAt = e.CreatedAt,
                            CategoryName = e.Category != null ? e.Category.Name : null,
                            PaidTo = e.PaidTo,
                            PaymentMethod = e.PaymentMethod
                        })
                        .AsNoTracking()
                        .ToListAsync();

                    // 2. Fetch reception expenses
                    var recQuery = db.CarReceptionsExpenses.Include(re => re.Reception.Car).AsQueryable();
                    if (fromDate.HasValue)
                        recQuery = recQuery.Where(re => DbFunctions.TruncateTime(re.CreatedAt) >= fromDate.Value);

                    var receptionBatch = await recQuery
                        .OrderByDescending(re => re.CreatedAt)
                        .Skip(skip)
                        .Take(_pageSize)
                        .Select(re => new ExpenseRow
                        {
                            Id = re.Id,
                            ReceptionId = re.ReceptionId,
                            Title = re.Title,
                            Description = re.Description,
                            Amount = re.Amount,
                            CreatedAt = re.CreatedAt,
                            CategoryName = null,
                            PaidTo = re.PaidTo,
                            PaymentMethod = re.PaymentMethod
                        })
                        .AsNoTracking()
                        .ToListAsync();

                    // 3. Merge, sort, and paginate in memory
                    var page = expensesBatch.Concat(receptionBatch)
                        .OrderByDescending(x => x.CreatedAt)
                        .Take(_pageSize)
                        .ToList();

                    // 4. Update UI labels and controls
                    btnBackPage.Enabled = (_pageIndex > 0);
                    btnNextPage.Enabled = (page.Count == _pageSize);

                    string filterLabel = _daysAgo > 0 ? $"{_daysAgo} روز اخیر" : "تمام زمان‌ها";
                    labelDetails.Text = $"صفحه: {_pageIndex + 1} | تعداد: {page.Count} | فیلتر: {filterLabel}";

                    var totalAll = page.Sum(x => x.Amount);
                    var totalGeneral = page.Where(x => x.ReceptionId == null).Sum(x => x.Amount);
                    labelTotalExpenses.Text = $"مجموع در صفحه: {totalAll:N0} تومان  |  عمومی: {totalGeneral:N0} تومان";

                    // The explicit type allows the designer 'DataPropertyName' to bind correctly
                    dgExpenses.DataSource = page;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری اطلاعات: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                dgExpenses.Enabled = true;
            }
        }

        // -------------------------
        // CRUD Operations
        // -------------------------

        private ExpenseRow GetSelectedRow()
        {
            if (dgExpenses.SelectedRows.Count == 0) return null;
            return dgExpenses.SelectedRows[0].DataBoundItem as ExpenseRow;
        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new ExpenseForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                        await LoadDataAsync(_pageIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در باز کردن فرم ثبت هزینه: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                // If ReceptionId is null, it's a general editable expense
                if (row.ReceptionId == null)
                {
                    using (var db = new AutoLedgerContext())
                    {
                        var expense = await db.Expenses.FirstOrDefaultAsync(x => x.Id == row.Id);
                        if (expense == null)
                        {
                            MessageBox.Show("رکورد مورد نظر یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        using (var form = new ExpenseForm(expense))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                                await LoadDataAsync(_pageIndex);
                        }
                    }
                }
                else
                {
                    // Read-only view for car reception
                    using (var db = new AutoLedgerContext())
                    {
                        var reception = await db.CarReceptions
                            .Include(r => r.Car)
                            .Include(r => r.Expenses)
                            .Include(r => r.Requests)
                            .FirstOrDefaultAsync(r => r.Id == row.ReceptionId.Value);

                        if (reception == null)
                        {
                            MessageBox.Show("پذیرش مرتبط با این هزینه یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        try
                        {
                            using (var form = new CarReceptionExpenseForm(reception))
                            {
                                form.ShowDialog();
                            }
                        }
                        catch
                        {
                            MessageBox.Show($"پذیرش شماره #{reception.Id} — هزینه کل: {reception.TotalCost:N0} تومان", "جزئیات پذیرش", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

            if (row.ReceptionId != null)
            {
                MessageBox.Show("این مورد مربوط به هزینه‌های پذیرش خودرو است و از اینجا قابل حذف نیست.", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("آیا از حذف این هزینه اطمینان دارید؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new AutoLedgerContext())
                {
                    var expense = await db.Expenses.FirstOrDefaultAsync(x => x.Id == row.Id);
                    if (expense != null)
                    {
                        db.Expenses.Remove(expense);
                        await db.SaveChangesAsync();

                        MessageBox.Show("هزینه با موفقیت حذف شد.", "عملیات موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Paint the row index
        private void DgExpenses_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgExpenses.Columns.Count > 0 && dgExpenses.Rows[e.RowIndex].Cells.Count > 0)
            {
                dgExpenses.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1 + _pageIndex * _pageSize).ToString();
            }
        }
    }
}