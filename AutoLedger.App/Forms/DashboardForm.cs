using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.Animation;
using AutoLedger.App.FormsModal;
using AutoLedger.App.FormsView;
using AutoLedger.Data;
using AutoLedger.Domain;
using AutoLedger.Extensions;
using System.Diagnostics;
using System.IO;

namespace AutoLedger.App.Forms
{
    public partial class DashboardForm : RibbonForm
    {

        private CarsManagerPage _carsManagerPage;
        private ExpensesManagerPage _expensesManagerPage;
        private CustomersInformationPage _customersInformationPage;
        private ReportsDailyPage _reportsDailyPage;
        private ReportsMonthlyPage _reportsWeeklyPage;
        private ReportsMonthlyPage _reportsMonthlyPage;
        private UsersManagerPage _usersManagerPage;
        private DebtsManagerPage _debtsManagerPage;
        private TransitionManager _transitionManager;
   
        public DashboardForm()
        {
            InitializeComponent();
            SetupAnimation();

            SetupEventHandlers();
            this.lblVersion.Caption = Program.Version;
            this.lblPrayOfDay.Caption = IslamicContentHelper.GetTodayZikr();
            RefreshUserInfo();
        }
        private void SetupAnimation()
        {
            _transitionManager = new TransitionManager();

            var transition = new Transition();
            transition.Control = panelView;

            var effect = new FadeTransition();

            transition.TransitionType = effect;
            _transitionManager.Transitions.Add(transition);
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
            this.btnDebts.Click += ViewButtons_Click;
            this.btnDashboard.Click += ViewButtons_Click;



            this.btnSevenDiag.Click += BtnSevenDiag_Click;
            this.btnSettings.Click += (s, e) => new SettingsForm().ShowDialog();
            this.btnDeveloper.Click += (s, e) => Process.Start(Global.JalalJalehGithub);
     


            this.btnRefreshSentenceOfDay.ItemClick += (s, e) => RefreshSentences();
            this.panelView.Resize += PanelView_Resize;
        }


        private void BtnSevenDiag_Click(object sender, EventArgs e)
        {
            string exePath = Properties.Settings.Default.SevenDiagPath;

            if (string.IsNullOrWhiteSpace(exePath) || !File.Exists(exePath))
            {
                MessageBox.Show("قایل یافت نشد؛ از طریق تنظیمات، نرم افزار پروگرامر را اضافه نمائید.");
                return;
            }


            try
            {
                Process.Start(exePath);

                // نکته: اگر برنامه نیاز به دسترسی ادمین (Run as Administrator) دارد، به جای خط بالا از این استفاده کنید:
                // ProcessStartInfo startInfo = new ProcessStartInfo(exePath);
                // startInfo.Verb = "runas";
                // Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در اجرای برنامه:\n{ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshSentences()
        {
            this.barLabelTime.Caption = "تاریخ امروز: " + DateTime.Now.ToShamsiLong();
            this.lblSentenceOfDay.Caption = IslamicContentHelper.GetRandomQuranVerse();
        }
        private void RefreshUserInfo()
        {
            RefreshSentences();

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
        private void BtnNewExpens_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new ExpenseForm())
                {
                    if (form.ShowDialog() == DialogResult.OK && _expensesManagerPage != null)
                    {

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

        private void ShowControl(UserControl control)
        {

            if (_transitionManager != null)
                _transitionManager.StartTransition(panelView);

            try
            {
                panelView.SuspendLayout();


                if (panelView.Controls.Count > 0 && panelView.Controls[0] == control)
                    return;

                panelView.Controls.Clear();

                if (control != null)
                {
                    control.MinimumSize = new System.Drawing.Size(0, panelView.ClientSize.Height);
                    control.MaximumSize = new System.Drawing.Size(panelView.ClientSize.Width, 0);

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
                }

                panelView.ResumeLayout(true);
                panelView.PerformLayout();
            }
            finally
            {

                if (_transitionManager != null)
                    _transitionManager.EndTransition();
            }
        }
        private void ViewButtons_Click(object sender, EventArgs e)
        {
            RefreshSentences();

            if (!(sender is AccordionControlElement btn)) return;


            switch (btn.Name)
            {
                case "btnDashboard":
                    ShowControl(null);
                    break;

                case "btnAllCars":
                case "btnCurrentCars":
                    bool isCurrent = btn.Name == "btnCurrentCars";
                    if (_carsManagerPage == null)
                        _carsManagerPage = new CarsManagerPage(isCurrent);
                    else
                        _carsManagerPage.CheckCurrentCars(isCurrent);
                    ShowControl(_carsManagerPage);
                    break;

                case "btnDebts":
                    if (_debtsManagerPage == null) _debtsManagerPage = new DebtsManagerPage();
                    ShowControl(_debtsManagerPage);
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

                case "btnSevenDiag":
                    if (_usersManagerPage == null) _usersManagerPage = new UsersManagerPage();
                    ShowControl(_usersManagerPage);
                    break;
            }
        }



        private void PanelView_Resize(object sender, EventArgs e)
        {
            if (panelView.Controls.Count > 0)
            {
                panelView.Controls[0].MinimumSize = new System.Drawing.Size(0, panelView.ClientSize.Height);
                panelView.Controls[0].MaximumSize = new System.Drawing.Size(panelView.ClientSize.Width, 0);
            }
        }

    }
}