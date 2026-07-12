using AutoLedger.App.Controls;
using AutoLedger.Data;
using AutoLedger.Extensions;
using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AutoLedger.App.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //   pbLoading.Dispose();   ??

            HideMenu(".. منتظر بمانید", "در حال اتصال به پایگاه داده !");
        }
        void ShowMenu()
        {
            panelMenuMain.Visible = true;
        }
        void HideMenu(string caption, string descriptin)
        {

            pbLoading.Caption = caption;
            pbLoading.Description = descriptin;
            panelMenuMain.Visible = false;
        }
        private void BtnOpenUrl_Click(object sender, EventArgs e)
        {
            var btn = (ModernButton)sender;
            switch (btn.Name)
            {
                case "btnDeveloper":
                    Process.Start(Global.JalalJalehGithub);
                    Process.Start(Global.JalalJalehWebsite);
                    break;

                case "btnSourceCode":
                    Process.Start(Global.SourceCode);
                    break;

                case "btnTelegram":
                    Process.Start(Global.HaluntmTelegram);
                    break;
            }
        }

        public async Task InitializeAsync()
        {
            ShowMenu();

            this.labelTime.Text = "تاریخ امروز: " + DateTime.Now.ToShamsiLong();
            this.labelVersion.Text = "ورژن: " + Program.Version;

            this.btnTelegram.Click += BtnOpenUrl_Click;
            this.btnSourceCode.Click += BtnOpenUrl_Click;
            this.btnDeveloper.Click += BtnOpenUrl_Click;

            try
            {
                using (var db = new AutoLedgerContext())
                {
                    var users = await Task.Run(() => db.Users.ToList());

                    foreach (var user in users)
                        cbUsername.Properties.Items.Add(user.FullName);

                    cbUsername.SelectedIndex = 1;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(
                    "خطا در بارگذاری کاربران:\n" + ex.Message,
                    "خطا",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            btnLogin.Click += BtnLogin_Click;
            this.btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            _ = Task.Run(() => Environment.Exit(0));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            HideMenu("در حال ورود", ".. در حال اتصال به حساب کاربری");
            labelError.Text = "";

            if (!Login())
            {
                ShowMenu();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        bool Login()
        {

            string username = cbUsername.Text?.Trim();
            string password = inputPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                labelError.Text = "لطفاً یک کاربر انتخاب کنید.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                labelError.Text = "لطفاً رمز عبور را وارد کنید.";
                return false;
            }

            using (var db = new AutoLedgerContext())
            {
                var user = db.Users
                    .AsNoTracking()
                    .FirstOrDefault(u => u.FullName == username);

                if (user == null)
                {
                    labelError.Text = "کاربر یافت نشد.";
                    return false;
                }


                if (!string.Equals(user.Password, password, StringComparison.Ordinal))
                {
                    labelError.Text = "رمز عبور اشتباه است.";
                    return false;
                }
                Program.User = user;
            }
            return true;
        }
    }
}
