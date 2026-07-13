using AutoLedger.App.Properties;
using DevExpress.Utils.CommonDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class SettingsForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public SettingsForm()
        {
            InitializeComponent();

            this.input7Diag.Text = Settings.Default.SevenDiagPath;
            this.btn7Diag.Click += Btn7Diag_Click;

            this.lblUserProfile.Text = "نام کاربری: " + Program.User.FullName + "  |  تاریخ عضویت: " + Program.User.CreatedAt.ToRelativeTime();
            this.btnEditProfile.Click += Program.MainForm.BarBtnUser_ItemClick;

            this.lblStatup.Text = "زمان اجرای برنامه: " + Program.StartupTime.ToRelativeTime();

            this.btnExit.Click += (s, e) => this.Close();
        }



        private void Btn7Diag_Click(object sender, EventArgs e)
        {
            try
            {
                string exePath = Properties.Settings.Default.SevenDiagPath;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "لطفاً فایل اجرایی برنامه (SevenDiag.exe) را انتخاب کنید";
                    openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        exePath = openFileDialog.FileName;
                        Properties.Settings.Default.SevenDiagPath = exePath;
                        Properties.Settings.Default.Save();


                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch { }
            finally
            {
                this.input7Diag.Text = Settings.Default.SevenDiagPath;
            }

        }
    }
}
