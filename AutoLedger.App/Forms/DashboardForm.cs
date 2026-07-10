using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;

using AutoLedger.App.FormsModal;
using AutoLedger.App.FormsView;
using AutoLedger.Data;
using AutoLedger.Domain;
using AutoLedger.Extensions;

namespace AutoLedger.App.Forms
{
    public partial class DashboardForm : RibbonForm
    {
        // 1. Cache all pages to prevent memory leaks and maintain state
        private CarsManagerPage _carsManagerPage;
        private ExpensesManagerPage _expensesManagerPage;
        private CustomersInformationPage _customersInformationPage;
        private ReportsDailyPage _reportsDailyPage;
        private ReportsMonthlyPage _reportsWeeklyPage;
        private ReportsMonthlyPage _reportsMonthlyPage;
        private UsersManagerPage _usersManagerPage;

        public DashboardForm()
        {
            InitializeComponent();
            SetupEventHandlers();

            this.barLabelTime.Caption = DateTime.Now.ToShamsiLong();
            this.lblVersion.Caption = Program.Version;

            RefreshUserInfo();
        }

        private void SetupEventHandlers()
        {
            // User actions
            this.barBtnUser.ItemClick += BarBtnUser_ItemClick;
            this.btnNewReception.Click += BtnNewCar_Click;
            this.btnNewExpens.Click += BtnNewExpens_Click;

            // Navigation clicks
            this.btnAllCars.Click += ViewButtons_Click;
            this.btnCurrentCars.Click += ViewButtons_Click;
            this.btnExpenses.Click += ViewButtons_Click;
            this.btnDailySummary.Click += ViewButtons_Click;
            this.btnWeeklySummary.Click += ViewButtons_Click;
            this.btnMonthlySummary.Click += ViewButtons_Click;
            this.btnUsersInformation.Click += ViewButtons_Click;
            this.btnStuff.Click += ViewButtons_Click;

            // UI events
            this.panelView.Resize += PanelView_Resize;
        }

        private void RefreshUserInfo()
        {
            if (Program.User == null) return;

            this.barUserName.Caption = Program.User.FullName;

            // 2. Safe casting for ToolTips to prevent NullReferenceExceptions
            var btnUserTipItem1 = this.barBtnUser.SuperTip?.Items[0] as ToolTipItem;
            var btnUserTipItem2 = this.barBtnUser.SuperTip?.Items[1] as ToolTipItem;
            var userNameTipItem1 = this.barUserName.SuperTip?.Items[0] as ToolTipItem;
            var userNameTipItem2 = this.barUserName.SuperTip?.Items[1] as ToolTipItem;

            string statusText = $"کاربر {Program.User.FullName} آنلاین می‌باشد.";
            string detailsText = $"+{Program.User.PhoneNumber}\nتاریخ عضویت: {Program.User.CreatedAt.ToShamsiLong()}";

            if (btnUserTipItem1 != null) btnUserTipItem1.Text = statusText;
            if (btnUserTipItem2 != null) btnUserTipItem2.Text = detailsText;

            if (userNameTipItem1 != null) userNameTipItem1.Text = statusText;
            if (userNameTipItem2 != null) userNameTipItem2.Text = detailsText;
        }

        private void BarBtnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frm = new UserForm(Program.User))
            {
                frm.ShowDialog();

                using (var db = new AutoLedgerContext())
                {
                    Program.User = db.Users.AsNoTracking().FirstOrDefault(u => u.Id == Program.User.Id);
                }

                RefreshUserInfo();
            }
        }

        private void ViewButtons_Click(object sender, EventArgs e)
        {
            if (!(sender is AccordionControlElement btn)) return;

            // 3. Lazy initialization of cached pages
            switch (btn.Name)
            {
                case "btnAllCars":
                case "btnCurrentCars":
                    bool isCurrent = btn.Name == "btnCurrentCars";
                    if (_carsManagerPage == null)
                        _carsManagerPage = new CarsManagerPage(isCurrent);
                    else
                        _carsManagerPage.CheckCurrentCars(isCurrent);
                    ShowControl(_carsManagerPage);
                    break;

                case "btnExpenses":
                    if (_expensesManagerPage == null) _expensesManagerPage = new ExpensesManagerPage();
                    ShowControl(_expensesManagerPage);
                    break;

                case "btnDailySummary":
                    if (_reportsDailyPage == null) _reportsDailyPage = new ReportsDailyPage();
                    ShowControl(_reportsDailyPage);
                    break;

                case "btnWeeklySummary":
                    if (_reportsWeeklyPage == null) _reportsWeeklyPage = new ReportsMonthlyPage(false);
                    ShowControl(_reportsWeeklyPage);
                    break;

                case "btnMonthlySummary":
                    if (_reportsMonthlyPage == null) _reportsMonthlyPage = new ReportsMonthlyPage(true);
                    ShowControl(_reportsMonthlyPage);
                    break;

                case "btnUsersInformation":
                    if (_customersInformationPage == null) _customersInformationPage = new CustomersInformationPage();
                    ShowControl(_customersInformationPage);
                    break;

                case "btnStuff":
                    if (_usersManagerPage == null) _usersManagerPage = new UsersManagerPage();
                    ShowControl(_usersManagerPage);
                    break;
            }
        }

        private void ShowControl(UserControl control)
        {
            if (control == null || panelView.Controls.Contains(control)) return;

            panelView.SuspendLayout();

            // Clear does not dispose, which is perfect since we are caching the controls now.
            panelView.Controls.Clear();

            control.MinimumSize = new System.Drawing.Size(0, panelView.ClientSize.Height);
            if (control.Height < panelView.ClientSize.Height)
            {
                control.Height = panelView.ClientSize.Height;
            }

            control.Dock = DockStyle.Top;
            panelView.Controls.Add(control);

            panelView.AutoScroll = true;
            panelView.HorizontalScroll.Enabled = false;
            panelView.HorizontalScroll.Visible = false;
            panelView.HorizontalScroll.Maximum = 0;

            panelView.ResumeLayout(true);
            panelView.PerformLayout();
        }

        private void PanelView_Resize(object sender, EventArgs e)
        {
            if (panelView.Controls.Count > 0)
            {
                panelView.Controls[0].MinimumSize = new System.Drawing.Size(0, panelView.ClientSize.Height);
            }
        }

        private void BtnNewExpens_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new ExpenseForm())
                {
                    if (form.ShowDialog() == DialogResult.OK && _expensesManagerPage != null)
                    {
                        // TODO: Call your refresh method here
                        // _expensesManagerPage.RefreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در باز کردن فرم ثبت هزینه: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewCar_Click(object sender, EventArgs e)
        {
            using (var carPlate = new CarPlateModalForm())
            {
                if (carPlate.ShowDialog() != DialogResult.OK) return;

                using (var db = new AutoLedgerContext())
                {
                    var car = db.Cars.FirstOrDefault(a => a.PlateId == carPlate.Plate);

                    if (car == null)
                    {
                        using (var carForm = new CarForm(car).WithPlateId(carPlate.Plate))
                        {
                            if (carForm.ShowDialog() != DialogResult.OK) return;
                            car = carForm.GetCar();
                        }
                    }

                    using (var receptionForm = new CarReceptionForm(car))
                    {
                        if (receptionForm.ShowDialog() == DialogResult.OK)
                        {
                            _carsManagerPage?.RefreshCars();
                        }
                    }
                }
            }
        }
    }
}