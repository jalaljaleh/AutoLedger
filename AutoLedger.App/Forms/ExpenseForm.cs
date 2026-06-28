using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLedger.Extensions;

namespace AutoLedger.App.Forms
{
    public partial class ExpenseForm : Form
    {
        private readonly Expense _editingExpense;
        private readonly bool _isEditMode;

        public ExpenseForm()
        {
            InitializeComponent();
            _isEditMode = false;
            WireEvents();

            // اطمینان از اینکه کاربر می‌تواند متن جدید وارد کند
            cbCategory.DropDownStyle = ComboBoxStyle.DropDown;
            cbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public ExpenseForm(Expense expenseToEdit) : this()
        {
            if (expenseToEdit == null) throw new ArgumentNullException(nameof(expenseToEdit));
            _editingExpense = expenseToEdit;
            _isEditMode = true;
        }

        private void WireEvents()
        {
            this.Load += ExpenseForm_Load;
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += BtnCancel_Click;
            inputAmount.TextChanged += InputAmount_TextChanged;

            // اگر خواستی Enter در ComboBox دسته، رفتار خاصی داشته باشد:
            cbCategory.KeyDown += CbCategory_KeyDown;
        }

        private void CbCategory_KeyDown(object sender, KeyEventArgs e)
        {
            // اگر کاربر Enter زد، فوکوس را به دکمه تایید منتقل کن تا تجربه کاربری بهتر شود
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private async void ExpenseForm_Load(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();

            if (_isEditMode)
                await PopulateForEditAsync();
            else
                PrepareForNew();
        }

        private void PrepareForNew()
        {
            inputTitle.Text = string.Empty;
            inputDescription.Text = string.Empty;
            inputAmount.Text = "0";
            inputPaidTo.Text = string.Empty;
            InputPaymentMethod.Text = string.Empty;
            labelAmountPersian.Text = ((long)0).ToPersianWordsToman();

            if (cbCategory.Items.Count > 0)
                cbCategory.SelectedIndex = 0;
            else
                cbCategory.Text = string.Empty;
        }

        private async Task LoadCategoriesAsync()
        {
            try
            {
                using (var db = new AutoLedgerContext())
                {
                    var categories = await db.ExpenseCategories
                        .OrderBy(c => c.Name)
                        .ToListAsync();

                    cbCategory.DisplayMember = "Name";
                    cbCategory.ValueMember = "Id";
                    cbCategory.DataSource = categories;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری دسته‌بندی‌ها: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task PopulateForEditAsync()
        {
            try
            {
                using (var db = new AutoLedgerContext())
                {
                    var expense = await db.Expenses
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.Id == _editingExpense.Id);

                    if (expense == null)
                    {
                        MessageBox.Show("رکورد مورد نظر پیدا نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                        return;
                    }

                    inputTitle.Text = expense.Title;
                    inputDescription.Text = expense.Description;
                    inputAmount.Text = expense.Amount.ToString("0");
                    inputPaidTo.Text = expense.PaidTo;
                    InputPaymentMethod.Text = expense.PaymentMethod;
                    labelAmountPersian.Text = expense.Amount.ToPersianWordsToman();

                    // تلاش برای انتخاب دسته موجود
                    if (cbCategory.Items.Count > 0)
                    {
                        var item = cbCategory.Items.Cast<ExpenseCategory>().FirstOrDefault(c => c.Id == expense.CategoryId);
                        if (item != null)
                        {
                            cbCategory.SelectedItem = item;
                        }
                        else
                        {
                            // دسته در لیست نیست (مثلاً حذف شده) — متن دسته را نمایش بده تا کاربر تصمیم بگیرد
                            var cat = await db.ExpenseCategories.AsNoTracking().FirstOrDefaultAsync(c => c.Id == expense.CategoryId);
                            if (cat != null)
                                cbCategory.Text = cat.Name;
                            else
                                cbCategory.Text = string.Empty;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بارگذاری اطلاعات برای ویرایش: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InputAmount_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(inputAmount.Text, out long val))
            {
                labelAmountPersian.Text = val.ToPersianWordsToman();
            }
            else
            {
                labelAmountPersian.Text = "0 تومان";
            }
        }

        private async void BtnConfirm_Click(object sender, EventArgs e)
        {
            btnConfirm.Enabled = false;
            try
            {
                // اعتبارسنجی ساده
                if (string.IsNullOrWhiteSpace(inputTitle.Text))
                {
                    MessageBox.Show("عنوان را وارد کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(inputAmount.Text, out decimal amount) || amount < 0)
                {
                    MessageBox.Show("مبلغ نامعتبر است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // دریافت یا ایجاد دسته‌بندی از ورودی کاربر
                var category = await EnsureCategoryAsync(cbCategory.Text?.Trim());
                if (category == null)
                {
                    MessageBox.Show("دسته‌بندی نامعتبر است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new AutoLedgerContext())
                {
                    if (_isEditMode)
                    {
                        var expense = await db.Expenses.FirstOrDefaultAsync(x => x.Id == _editingExpense.Id);
                        if (expense == null)
                        {
                            MessageBox.Show("رکورد برای ویرایش پیدا نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DialogResult = DialogResult.Cancel;
                            this.Close();
                            return;
                        }

                        expense.Title = inputTitle.Text.Trim();
                        expense.Description = inputDescription.Text.Trim();
                        expense.Amount = amount;
                        expense.PaidTo = inputPaidTo.Text?.Trim();
                        expense.PaymentMethod = InputPaymentMethod.Text?.Trim();
                        expense.CategoryId = category.Id;
                        expense.UpdatedAt = DateTime.Now;

                         db.SaveChanges();
                    }
                    else
                    {
                        var expense = new Expense
                        {
                            Title = inputTitle.Text.Trim(),
                            Description = inputDescription.Text.Trim(),
                            Amount = amount,
                            PaidTo = inputPaidTo.Text?.Trim(),
                            PaymentMethod = InputPaymentMethod.Text?.Trim(),
                            CategoryId = category.Id,
                            ExpenseDate = DateTime.Now,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                        };

                        db.Expenses.Add(expense);
                         db.SaveChanges();
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ذخیره‌سازی: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConfirm.Enabled = true;
            }
        }

        private async Task<ExpenseCategory> EnsureCategoryAsync(string categoryText)
        {
            if (string.IsNullOrWhiteSpace(categoryText))
                return null;

            // اگر کاربر از لیست انتخاب کرده باشد، cbCategory.SelectedItem را بررسی کن
            if (cbCategory.SelectedItem is ExpenseCategory selected && string.Equals(selected.Name, categoryText, StringComparison.OrdinalIgnoreCase))
                return selected;

            // در غیر این صورت، سعی کن دسته را در دیتابیس پیدا کنی؛ اگر نبود، ایجاد کن
            try
            {
                using (var db = new AutoLedgerContext())
                {
                    var existing = await db.ExpenseCategories.FirstOrDefaultAsync(c => c.Name == categoryText);
                    if (existing != null)
                        return existing;

                    // ایجاد دسته جدید
                    var newCat = new ExpenseCategory { Name = categoryText };
                    db.ExpenseCategories.Add(newCat);
                    await db.SaveChangesAsync();

                    // بعد از ایجاد، مقدار جدید را به ComboBox اضافه کن تا دفعه بعدی در لیست باشد
                    // چون این متد در کانتکست جدید اجرا می‌شود، برای به‌روزرسانی UI باید در ترد UI انجام شود
                    this.Invoke(new Action(() =>
                    {
                        // اگر DataSource لیست از ExpenseCategory است، آن را به‌روزرسانی کن
                        if (cbCategory.DataSource is System.Collections.IList list)
                        {
                            list.Add(newCat);
                            cbCategory.SelectedItem = newCat;
                        }
                        else
                        {
                            cbCategory.Items.Add(newCat);
                            cbCategory.SelectedItem = newCat;
                        }
                    }));

                    return newCat;
                }
            }
            catch (Exception ex)
            {
                // لاگ یا نمایش خطا
                MessageBox.Show("خطا در ایجاد یا بازیابی دسته‌بندی: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
