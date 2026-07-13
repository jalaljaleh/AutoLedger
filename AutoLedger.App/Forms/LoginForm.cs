using AutoLedger.App.Controls;
using AutoLedger.Data;
using AutoLedger.Extensions;
using DevExpress.XtraEditors;
using System;
using System.Data.Entity;
using System.Diagnostics;
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
            SetupEventHandlers();

            // Note on pbLoading.Dispose(): Do not dispose controls here. 
            // The garbage collector and the Form's base Dispose method will handle it 
            // when the form closes. Disposing it early will crash the UI.

            // Initial state: Hide menu and show loading screen
            HideMenu(".. منتظر بمانید", "در حال اتصال به پایگاه داده !");
        }

        private void SetupEventHandlers()
        {
            // Attach event handlers once during initialization to prevent multiple triggers
            this.btnTelegram.Click += BtnOpenUrl_Click;
            this.btnSourceCode.Click += BtnOpenUrl_Click;
            this.btnDeveloper.Click += BtnOpenUrl_Click;
            this.btnLogin.Click += BtnLogin_Click;
            this.btnExit.Click += BtnExit_Click;

            this.inputPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    BtnLogin_Click(null, null);
            };
        }

        private void ShowMenu()
        {
            panelMenuMain.Visible = true;
        }

        private void HideMenu(string caption, string description)
        {
            pbLoading.Caption = caption;
            pbLoading.Description = description;
            panelMenuMain.Visible = false;
        }

        private void BtnOpenUrl_Click(object sender, EventArgs e)
        {
            // Safely cast sender to ModernButton to avoid exceptions
            if (sender is ModernButton btn)
            {
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
        }

        public async Task InitializeAsync()
        {
            ShowMenu();

            this.labelTime.Text = "تاریخ امروز: " + DateTime.Now.ToShamsiLong();
            this.labelVersion.Text = " " + Program.Version;

            try
            {
                using (var db = new AutoLedgerContext())
                {
                    // Optimize query: Fetch only FullName to reduce memory usage and increase speed
                    var userNames = await db.Users
                        .AsNoTracking()
                        .Select(u => u.FullName)
                        .ToListAsync();

                    cbUsername.Properties.Items.Clear();
                    cbUsername.Properties.Items.AddRange(userNames);

                    if (cbUsername.Properties.Items.Count > 0)
                    {
                        if (cbUsername.Properties.Items.Count > 1)
                            cbUsername.SelectedIndex = 1;
                        else
                            cbUsername.SelectedIndex = 0;
                    }
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
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Application.Exit is the standard way to close a WinForms application gracefully
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            HideMenu("در حال ورود", ".. در حال اتصال به حساب کاربری");
            labelError.Text = string.Empty;

            if (!TryLogin())
            {
                ShowMenu();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool TryLogin()
        {
            string username = cbUsername.Text?.Trim();
            string password = inputPassword.Text;

            // 1. Validate inputs
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

            // 2. Authenticate user
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

                // Store authenticated user in global application state
                Program.User = user;
            }

            return true;
        }
    }
}