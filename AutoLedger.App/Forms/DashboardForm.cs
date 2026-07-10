using AutoLedger.App.FormsModal;
using AutoLedger.App.FormsView;
using AutoLedger.Data;
using AutoLedger.Domain;
using AutoLedger.Extensions;
using DevExpress.Utils;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace AutoLedger.App.Forms
{
    public partial class DashboardForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CarsManagerPage _carsManagerPage;
        private ExpensesManagerPage _expensesManagerPage;
        private CustomersInformationPage _customersInformationPage;

        public DashboardForm()
        {
            InitializeComponent();

            this.barLabelTime.Caption = DateTime.Now.ToShamsiLong();

            barBtnUser.ItemClick += BarBtnUser_ItemClick;

            this.btnNewReception.Click += BtnNewCar_Click;
            this.btnNewExpens.Click += BtnNewExpens_Click;


            this.btnAllCars.Click += ViewButtons_Click;
            this.btnCurrentCars.Click += ViewButtons_Click;
            this.btnExpenses.Click += ViewButtons_Click;

            this.btnDailySummary.Click += ViewButtons_Click;
            this.btnWeeklySummary.Click += ViewButtons_Click;
            this.btnMonthlySummary.Click += ViewButtons_Click;

            this.btnUsersInformation.Click += ViewButtons_Click;

            this.panelView.Resize += panelView_Resize;

            RefreshUserInfo();
        }
        void RefreshUserInfo()
        {
            this.barUserName.Caption = Program.User.FullName;

            (this.barBtnUser.SuperTip.Items[0] as ToolTipItem).Text = $"کاربر {Program.User.FullName} انلاین می باشد.";
            (this.barBtnUser.SuperTip.Items[1] as ToolTipItem).Text = $"+{Program.User.PhoneNumber} \n" +
                                                                      $"تاریخ عضویت: " + Program.User.CreatedAt.ToShamsiLong();

            (this.barUserName.SuperTip.Items[0] as ToolTipItem).Text = (this.barBtnUser.SuperTip.Items[0] as ToolTipItem).Text;
            (this.barUserName.SuperTip.Items[1] as ToolTipItem).Text = (this.barBtnUser.SuperTip.Items[1] as ToolTipItem).Text;

        }
        private void BarBtnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (UserForm frm = new UserForm(Program.User))
            {
                frm.ShowDialog();

                using (AutoLedgerContext db = new AutoLedgerContext())
                    Program.User = db.Users.AsNoTracking().FirstOrDefault(u => u.Id == Program.User.Id);

                RefreshUserInfo();
            }
        }

        private void ViewButtons_Click(object sender, EventArgs e)
        {
            var btn = sender as AccordionControlElement;
            if (btn == null) return;

            switch (btn.Name)
            {
                case "btnAllCars":
                case "btnCurrentCars":

                    if (_carsManagerPage == null)
                        _carsManagerPage = new CarsManagerPage(btn.Name == "btnCurrentCars"); // all cars
                    else
                        _carsManagerPage.CheckCurrentCars(btn.Name == "btnCurrentCars");

                    ShowControl(_carsManagerPage);
                    break;

                case "btnExpenses":
                    if (_expensesManagerPage == null)
                        _expensesManagerPage = new ExpensesManagerPage();
                    ShowControl(_expensesManagerPage);
                    break;


                case "btnDailySummary":
                    ShowControl(new ReportsDailyPage());
                    break;
                case "btnWeeklySummary":
                    ShowControl(new ReportsMonthlyPage(false));
                    break;
                case "btnMonthlySummary":
                    ShowControl(new ReportsMonthlyPage(true));
                    break;


                case "btnUsersInformation":
                    if (_customersInformationPage == null)
                        _customersInformationPage = new CustomersInformationPage();
                    ShowControl(_customersInformationPage);
                    break;
            }
        }

        private void ShowControl(UserControl control)
        {
            panelView.SuspendLayout();

            if (panelView.Controls.Count > 0)
                panelView.Controls.Clear();
            

            if (control != null)
            {
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
            }

            panelView.ResumeLayout(true);
            panelView.PerformLayout();
        }
        private void panelView_Resize(object sender, EventArgs e)
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
                    if (form.ShowDialog() == DialogResult.OK)
                        if (_expensesManagerPage != null)
                        {
                            //      _expensesManagerPage.
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در باز کردن فرم ثبت هزینه: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnNewCar_Click(object sender, EventArgs e)
        {
            var carPlate = new CarPlateModalForm();
            if (carPlate.ShowDialog() != DialogResult.OK)
                return;

            using (var db = new AutoLedgerContext())
            {
                var car = db.Cars.FirstOrDefault(a => a.PlateId == carPlate.Plate);
                if (car is null)
                {
                    var carForm = new CarForm(car)
                      .WithPlateId(carPlate.Plate);

                    if (carForm.ShowDialog() != DialogResult.OK)
                        return;

                    car = carForm.GetCar();
                }

                var receptionForm = new CarReceptionForm(car);
                if (receptionForm.ShowDialog() == DialogResult.OK)
                {
                    _carsManagerPage?.RefreshCars();
                }
            }
        }


    }
}
