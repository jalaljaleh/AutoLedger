using AutoLedger.App.Controls;
using AutoLedger.Data;
using AutoLedger.Extensions;
using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            labelVersion.Text = Program.Version;

            panelMenuMain.Visible = false;
        }

        private void BtnOpenUrl_Click(object sender, EventArgs e)
        {
            var btn = (ModernButton)sender;
            switch (btn.Name)
            {
                case "btnDeveloper":
                    Process.Start("https://github.com/jalaljaleh");
                    break;

                case "btnSourceCode":
                    Process.Start("https://github.com/jalaljaleh/AutoLedger");
                    break;

                case "btnTelegram":
                    Process.Start("https://t.me/haluntm");
                    break;
            }
        }

        public async Task InitializeAsync()
        {
            panelMenuMain.Visible = true;
        
            this.labelTime.Text = "تاریخ امروز: " + DateTime.Now.ToShamsiLong();

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
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = cbUsername.Text?.Trim();
            string password = inputPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                XtraMessageBox.Show("لطفاً یک کاربر انتخاب کنید.", "هشدار",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                XtraMessageBox.Show("لطفاً رمز عبور را وارد کنید.", "هشدار",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new AutoLedgerContext())
            {
                var user = db.Users.FirstOrDefault(u => u.FullName == username);

                if (user == null)
                {
                    XtraMessageBox.Show("کاربر یافت نشد.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

        
                if (!string.Equals(user.Password, password, StringComparison.Ordinal))
                {
                    XtraMessageBox.Show("رمز عبور اشتباه است.", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
