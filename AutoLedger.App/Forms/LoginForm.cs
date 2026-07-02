using AutoLedger.Data;
using DevExpress.XtraEditors;
using System;
using System.Linq;
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

            inputPassword.Visible = false;
            cbUsername.Visible = false;
            btnLogin.Visible = false;
        }

        public async Task InitializeAsync()
        {
            inputPassword.Visible = true;
            cbUsername.Visible = true;
            btnLogin.Visible = true;

            try
            {
                using (var db = new AutoLedgerContext())
                {
                    var users = await Task.Run(() => db.Users.ToList());

                    foreach (var user in users)
                        cbUsername.Properties.Items.Add(user.FullName);
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
