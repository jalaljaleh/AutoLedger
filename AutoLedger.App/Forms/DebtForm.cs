using AutoLedger.Data;
using AutoLedger.Domain;
using AutoLedger.Extensions;
using System;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class DebtForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        private readonly Debt _editingDebt;
        private readonly bool _isEditMode;

     
        public DebtForm()
        {
            InitializeComponent();
            _isEditMode = false;
            WireEvents();
        }

    
        public DebtForm(Debt debtToEdit) : this()
        {
            _editingDebt = debtToEdit ?? throw new ArgumentNullException(nameof(debtToEdit));
            _isEditMode = true;
        }

        private void WireEvents()
        {
            this.Load += DebtForm_Load;
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += BtnCancel_Click;
            inputAmount.TextChanged += InputAmount_TextChanged;

      
            chReciveable.CheckedChanged += (s, e) => { if (chReciveable.Checked) chPayable.Checked = false; };
            chPayable.CheckedChanged += (s, e) => { if (chPayable.Checked) chReciveable.Checked = false; };
        }

        private async void DebtForm_Load(object sender, EventArgs e)
        {
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
            labelAmountPersian.Text = 0L.ToPersianWordsToman();

          
            inputId.Text = "جدید";
            inputCreatedAt.Text = DateTime.Now.ToShamsiLong();
            chReciveable.Checked = true; 
            chPayable.Checked = false;
        }

        private async Task PopulateForEditAsync()
        {
            try
            {
                using (var db = new AutoLedgerContext())
                {
                    var debt = await db.Debts
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.Id == _editingDebt.Id);

                    if (debt == null)
                    {
                        MessageBox.Show("رکورد مورد نظر پیدا نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                        return;
                    }

           
                    inputId.Text = debt.Id.ToString();
                    inputTitle.Text = debt.Title;
                    inputDescription.Text = debt.Description;
                    inputAmount.Text = debt.Amount.ToString("0");
                    inputPaidTo.Text = debt.DebtTo;
                    inputCreatedAt.Text = debt.CreatedAt.ToShamsiLong();
                    labelAmountPersian.Text = debt.Amount.ToPersianWordsToman();

             
                    if (debt.Type == DebtType.Payable)
                        chReciveable.Checked = true;
                    else
                        chPayable.Checked = true;

                    // تنظیم وضعیت تسویه
                    chPayable.Checked = debt.Type == DebtType.Payable;
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
        
                if (string.IsNullOrWhiteSpace(inputTitle.Text))
                {
                    MessageBox.Show("عنوان را وارد کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(inputAmount.Text, out decimal amount) || amount < 0)
                {
                    MessageBox.Show("مبلغ وارد شده معتبر نیست.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!chReciveable.Checked && !chPayable.Checked)
                {
                    MessageBox.Show("لطفاً نوع بدهی/طلب را مشخص کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

           
                var debtType = chReciveable.Checked ? DebtType.Payable : DebtType.Receivable;

             
                using (var db = new AutoLedgerContext())
                {
                    if (_isEditMode)
                    {
                 
                        var debtInDb = await db.Debts.FirstOrDefaultAsync(x => x.Id == _editingDebt.Id);
                        if (debtInDb == null)
                        {
                            MessageBox.Show("رکورد برای ویرایش پیدا نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        debtInDb.Title = inputTitle.Text.Trim();
                        debtInDb.Description = inputDescription.Text.Trim();
                        debtInDb.Amount = amount;
                        debtInDb.DebtTo = inputPaidTo.Text?.Trim(); 
                        debtInDb.Type = debtType;
                        debtInDb.IsSettled = chSettled.Checked;
                    }
                    else
                    {
                 
                        var newDebt = new Debt
                        {
                            Title = inputTitle.Text.Trim(),
                            Description = inputDescription.Text.Trim(),
                            Amount = amount,
                            DebtTo = inputPaidTo.Text?.Trim(),
                            Type = debtType,
                            IsSettled = chSettled.Checked,
                            CreatedAt = DateTime.Now
                        };

                        db.Debts.Add(newDebt);
                    }

                
                    await db.SaveChangesAsync();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}