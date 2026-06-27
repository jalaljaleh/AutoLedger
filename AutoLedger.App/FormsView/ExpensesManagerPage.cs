using AutoLedger.App.Forms;
using AutoLedger.Data;
using AutoLedger.Domain;
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
        private int _expensesPage = 0;
        private int _expensesPageSize = 200;
        private int _expensesDaysAgo = -1;

        // DTO used to bind to DataGridView. Contains fields for both sources.
        private class ExpenseRow
        {
            public int RowId { get; set; }            // Id in its source table
            public string Source { get; set; }       // "Expense" or "Reception"
            public int? ReceptionId { get; set; }    // Reception id when Source == "Reception"

            // Common display fields
            public string Title { get; set; }
            public string Description { get; set; }
            public decimal Amount { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsEditable { get; set; }     // true for general Expenses, false for reception expenses

            // General expense specific
            public string CategoryName { get; set; }
            public string PaidTo { get; set; }
            public string PaymentMethod { get; set; }

            // Reception specific (car info)
            public string CarOwner { get; set; }
            public string Plate { get; set; }
            public string CarColor { get; set; }
            public string ReceptionInvoice { get; set; } // e.g., reception id or invoice number
        }

        public ExpensesManagerPage()
        {
            InitializeComponent();

            // Designer should define columns; do not auto-generate
            dgExpenses.AutoGenerateColumns = false;

            // Wire events
            this.btnRefresh.Click += BtnRefresh_Click;
            this.btnNextPage.Click += BtnNextPage_Click;
            this.btnBackPage.Click += BtnBackPage_Click;
            this.btnFilterToday.Click += BtnFilterToday_Click;
            this.btnFilterWeek.Click += BtnFilterWeek_Click;
            this.btnFilterMonth.Click += BtnFilterMonth_Click;
            this.btnFilterAllTimes.Click += BtnFilterAllTimes_Click;

            this.btnNew.Click += BtnNew_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnDelete.Click += BtnDelete_Click;

            // Set default page size from combobox if available
            if (cbCount.Items.Cast<object>().Any(i => i.ToString() == "200"))
                cbCount.SelectedItem = cbCount.Items.Cast<object>().First(i => i.ToString() == "200");
            else
                cbCount.Text = "200";

            this.cbCount.SelectedIndexChanged += CbCount_SelectedIndexChanged;
            this.dgExpenses.RowPostPaint += DgCarReceptions_RowPostPaint;

            _ = RefreshRowsAsync();
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            // Delete only allowed for general Expenses (IsEditable == true)
            if (dgExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgExpenses.SelectedRows[0].DataBoundItem as ExpenseRow;
            if (row == null)
            {
                MessageBox.Show("Selected row is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!row.IsEditable)
            {
                MessageBox.Show("This item belongs to a car reception and cannot be deleted here. Use reception screen to manage it.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new AutoLedgerContext())
                {
                    var expense = db.Expenses.FirstOrDefault(x => x.Id == row.RowId);
                    if (expense == null)
                    {
                        MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    db.Expenses.Remove(expense);
                    db.SaveChanges();
                }

                MessageBox.Show("Expense deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await RefreshRowsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            // Edit behavior depends on source
            if (dgExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgExpenses.SelectedRows[0].DataBoundItem as ExpenseRow;
            if (row == null)
            {
                MessageBox.Show("Selected row is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (row.IsEditable)
                {
                    // Edit general expense
                    using (var db = new AutoLedgerContext())
                    {
                        var expense = db.Expenses.FirstOrDefault(x => x.Id == row.RowId);
                        if (expense == null)
                        {
                            MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        using (var form = new ExpenseForm(expense))
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                                await RefreshRowsAsync();
                        }
                    }
                }
                else
                {
                    // Open reception form (read-only view). Load reception with related car and expenses.
                    if (!row.ReceptionId.HasValue)
                    {
                        MessageBox.Show("Invalid reception id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (var db = new AutoLedgerContext())
                    {
                        var reception = db.CarReceptions
                            .Include(r => r.Car)
                            .Include(r => r.Expenses)
                            .Include(r => r.Requests)
                            .FirstOrDefault(r => r.Id == row.ReceptionId.Value);

                        if (reception == null)
                        {
                            MessageBox.Show("Reception not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Try to open a reception form. If not available, show a simple info dialog.
                        try
                        {
                            using (var form = new CarReceptionExpenseForm(reception)) // adjust constructor if needed
                            {
                                form.ShowDialog();
                            }
                        }
                        catch
                        {
                            MessageBox.Show($"Reception #{reception.Id} — Total cost: {reception.TotalCost:N0} Toman", "Reception details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening editor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new ExpenseForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                        await RefreshRowsAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening new expense form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnFilterAllTimes_Click(object sender, EventArgs e)
        {
            _expensesDaysAgo = -1;
            _expensesPage = 0;
            await RefreshRowsAsync();
        }

        private async void BtnFilterToday_Click(object sender, EventArgs e)
        {
            _expensesDaysAgo = 1;
            _expensesPage = 0;
            await RefreshRowsAsync();
        }

        private async void BtnFilterWeek_Click(object sender, EventArgs e)
        {
            _expensesDaysAgo = 7;
            _expensesPage = 0;
            await RefreshRowsAsync();
        }

        private async void BtnFilterMonth_Click(object sender, EventArgs e)
        {
            _expensesDaysAgo = 30;
            _expensesPage = 0;
            await RefreshRowsAsync();
        }

        /// <summary>
        /// Load a page of combined rows from Expenses and CarReceptionExpenses.
        /// This method fetches small batches from each source (DB-side paging),
        /// merges them in memory, sorts and returns the requested page.
        /// </summary>
        public async Task RefreshRowsAsync()
        {
            try
            {
                dgExpenses.Enabled = false;
                Cursor = Cursors.WaitCursor;

                using (var db = new AutoLedgerContext())
                {
                    // prepare date filter
                    DateTime? fromDate = null;
                    if (_expensesDaysAgo > 0)
                        fromDate = DateTime.Today.AddDays(-_expensesDaysAgo);

                    // page size split strategy: try half from each source
                    int pageSize = Math.Max(1, _expensesPageSize);
                    int half = Math.Max(1, pageSize / 2);

                    // compute offsets for each source based on current page.
                    // Simple approach: use same page index for both sources.
                    int offset = _expensesPage * half;

                    // helper local lists
                    var combined = new List<ExpenseRow>(pageSize);

                    // fetch batches in rounds until we fill the page or reach a safety limit
                    int rounds = 0;
                    int maxRounds = 3; // safety: avoid many DB calls; adjust if needed
                    int expenseSkip = _expensesPage * half;
                    int receptionSkip = _expensesPage * half;

                    while (combined.Count < pageSize && rounds < maxRounds)
                    {
                        // fetch expenses batch
                        var expensesQuery = db.Expenses.Include(e => e.Category).AsQueryable();
                        if (fromDate.HasValue)
                            expensesQuery = expensesQuery.Where(e => DbFunctions.TruncateTime(e.CreatedAt) >= fromDate.Value);

                        var expensesBatch = await expensesQuery
                            .OrderByDescending(e => e.CreatedAt)
                            .ThenByDescending(e => e.Id)
                            .Skip(expenseSkip)
                            .Take(half)
                            .Select(e => new ExpenseRow
                            {
                                RowId = e.Id,
                                Source = "Expense",
                                ReceptionId = (int?)null,
                                Title = e.Title,
                                Description = e.Description,
                                Amount = e.Amount,
                                CreatedAt = e.CreatedAt,
                                IsEditable = true,
                                CategoryName = e.Category != null ? e.Category.Name : string.Empty,
                                PaidTo = e.PaidTo,
                                PaymentMethod = e.PaymentMethod,
                                CarOwner = null,
                                Plate = null,
                                CarColor = null,
                                ReceptionInvoice = null
                            })
                            .AsNoTracking()
                            .ToListAsync();

                        // fetch reception batch
                        var receptionQuery = db.CarReceptionsExpenses.Include(re => re.Reception.Car).AsQueryable();
                        if (fromDate.HasValue)
                            receptionQuery = receptionQuery.Where(re => DbFunctions.TruncateTime(re.CreatedAt) >= fromDate.Value);

                        var receptionBatch = await receptionQuery
                            .OrderByDescending(re => re.CreatedAt)
                            .ThenByDescending(re => re.Id)
                            .Skip(receptionSkip)
                            .Take(half)
                            .Select(re => new ExpenseRow
                            {
                                RowId = re.Id,
                                Source = "Reception",
                                ReceptionId = re.ReceptionId,
                                Title = re.Title,
                                Description = re.Description,
                                Amount = re.Amount,
                                CreatedAt = re.CreatedAt,
                                IsEditable = false,
                                CategoryName = null,
                                PaidTo = null,
                                PaymentMethod = null,
                                CarOwner = re.Reception.Car.OwnerFullName,
                                Plate = re.Reception.Car.PlateId,
                                CarColor = re.Reception.Car.Color,
                                ReceptionInvoice = re.ReceptionId.ToString()
                            })
                            .AsNoTracking()
                            .ToListAsync();

                        // merge batches
                        combined.AddRange(expensesBatch);
                        combined.AddRange(receptionBatch);

                        // if still not enough, advance offsets to fetch next batches in next round
                        expenseSkip += half;
                        receptionSkip += half;
                        rounds++;
                    }

                    // final sort and take the requested page size
                    var page = combined
                        .OrderByDescending(x => x.CreatedAt)
                        .ThenByDescending(x => x.RowId)
                        .Take(pageSize)
                        .ToList();

                    // totals for displayed page
                    var totalAll = page.Sum(x => x.Amount);
                    var totalGeneral = page.Where(x => x.IsEditable).Sum(x => x.Amount);

                    // update UI
                    btnBackPage.Enabled = (_expensesPage > 0);
                    btnNextPage.Enabled = (page.Count == pageSize); // approximate

                    this.labelDetails.Text = $"Page: {_expensesPage + 1} | Count: {page.Count} | Filter: {(_expensesDaysAgo > 0 ? $"last {_expensesDaysAgo} days" : "all time")}";
                    this.labelTotalExpenses.Text = $"Shown total: {totalAll:N0} Toman  |  General: {totalGeneral:N0} Toman";

                    // bind to grid
                    dgExpenses.DataSource = null;
                    dgExpenses.DataSource = page;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                dgExpenses.Enabled = true;
            }
        }



        private void DgCarReceptions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgExpenses.Columns.Count > 0 && dgExpenses.Rows[e.RowIndex].Cells.Count > 0)
            {
                dgExpenses.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1 + _expensesPage * _expensesPageSize).ToString();
            }
        }

        private async void CbCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCount.SelectedItem == null) return;

            var selected = cbCount.SelectedItem.ToString();
            if (int.TryParse(selected, out int parsed))
                _expensesPageSize = parsed;
            else if (int.TryParse(cbCount.Text, out parsed))
                _expensesPageSize = parsed;

            _expensesPage = 0;
            await RefreshRowsAsync();
        }

        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            _expensesPage = 0;
            await RefreshRowsAsync();
        }

        private async void BtnBackPage_Click(object sender, EventArgs e)
        {
            if (_expensesPage <= 0) return;
            _expensesPage--;
            await RefreshRowsAsync();
        }

        private async void BtnNextPage_Click(object sender, EventArgs e)
        {
            _expensesPage++;
            await RefreshRowsAsync();
        }
    }
}
