using AutoLedger.Domain;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class DailyReportPage : UserControl
    {
        private DailyLedgerSummary _ledger;

        public DailyReportPage(DailyLedgerSummary ledger = null)
        {
            InitializeComponent();
            _ledger = ledger ?? new DailyLedgerSummary();

            // تنظیمات فرمت ارز (تومان) برای کنترل‌های مالی
            SetupCurrencyEditors();
        }

        private void FrmDailyLedgerSummary_Load(object sender, EventArgs e)
        {
            BindDataToUI();
        }

        private void SetupCurrencyEditors()
        {
            SpinEdit[] currencyEditors = { spnShopExpenses, spnReceptionExpenses, spnReceptionRevenue };
            foreach (var editor in currencyEditors)
            {
                editor.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
                editor.Properties.MaskSettings.Set("mask", "N0");
                editor.Properties.UseMaskAsDisplayFormat = true;

                // افزودن پسوند "تومان" در زمان نمایش
                editor.CustomDisplayText += (s, ev) =>
                {
                    if (ev.Value != null && decimal.TryParse(ev.Value.ToString(), out decimal val))
                        ev.DisplayText = $"{val:N0} تومان";
                };

                // بروزرسانی خودکار سود در صورت تغییر مقادیر
                editor.EditValueChanged += CalculateTotals;
            }
        }

        private void BindDataToUI()
        {
            // اطلاعات زمانی
            txtShamsiDate.Text = _ledger.Date.ToShamsi();
            spnYear.Value = _ledger.Year;
            spnMonth.Value = _ledger.Month;
            spnDay.Value = _ledger.Day;

            // اطلاعات مالی
            spnShopExpenses.Value = _ledger.ShopExpenses;
            spnReceptionExpenses.Value = _ledger.ReceptionExpenses;
            spnReceptionRevenue.Value = _ledger.ReceptionRevenue;

            // آمار عملیات
            spnShopExpensesCount.Value = _ledger.ShopExpensesCount;
            spnNewCars.Value = _ledger.NewCarsRegistered;
            spnReceptionsOpened.Value = _ledger.ReceptionsOpened;
            spnReceptionsRepaired.Value = _ledger.ReceptionsRepaired;
            spnReceptionsReleased.Value = _ledger.ReceptionsReleased;

            CalculateTotals(null, null);
        }

        private void CalculateTotals(object sender, EventArgs e)
        {
            // آپدیت موقت مقادیر برای محاسبه
            _ledger.ShopExpenses = spnShopExpenses.Value;
            _ledger.ReceptionExpenses = spnReceptionExpenses.Value;
            _ledger.ReceptionRevenue = spnReceptionRevenue.Value;

            // نمایش فیلدهای محاسبه شده (Read-Only)
            txtTotalRevenue.Text = $"{_ledger.TotalRevenue:N0} تومان";
            txtTotalExpenses.Text = $"{_ledger.TotalExpenses:N0} تومان";
            txtProfit.Text = $"{_ledger.Profit:N0} تومان";

            // تغییر رنگ سود (سبز برای مثبت، قرمز برای منفی)
            txtProfit.ForeColor = _ledger.Profit >= 0 ? System.Drawing.Color.DarkGreen : System.Drawing.Color.DarkRed;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // نگاشت مقادیر UI به آبجکت قبل از ذخیره در LocalDB
            _ledger.ShopExpensesCount = (int)spnShopExpensesCount.Value;
            _ledger.NewCarsRegistered = (int)spnNewCars.Value;
            _ledger.ReceptionsOpened = (int)spnReceptionsOpened.Value;
            _ledger.ReceptionsRepaired = (int)spnReceptionsRepaired.Value;
            _ledger.ReceptionsReleased = (int)spnReceptionsReleased.Value;
            _ledger.UpdatedAt = DateTime.Now;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void grpFinance_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



