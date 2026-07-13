using AutoLedger.Data;
using AutoLedger.Domain;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class UserForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
     
        private readonly User _user;

        public UserForm(User user = null)
        {
            InitializeComponent();
            _user = user;

            SetupForm();
            SetupEventHandlers();
        }

        private void SetupEventHandlers()
        {
            this.btnCancel.Click += BtnCancel_Click;
            this.btnConfirm.Click += BtnConfirm_Click;
        }

        private void SetupForm()
        {
            if (_user != null)
            {
                // Populate fields for existing user
                this.inputCreatedAt.Text = _user.CreatedAt.ToShamsiLong();
                this.inputId.Text = _user.Id.ToString();
                this.inputFullName.Text = _user.FullName;
                this.inputNationalId.Text = _user.NationalId;
                this.InputPhoneNumber.Text = _user.PhoneNumber;
                this.inputDescription.Text = _user.Description;
                this.InputAddress.Text = _user.Address;

                this.HtmlText = _user.FullName;
            }
            else
            {
                // Setup defaults for a new user
                this.inputCreatedAt.Text = DateTime.Now.ToShamsiLong();
                this.HtmlText = "ثبت کاربر جدید";
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            // Extract text values and trim white spaces
            string newPassword = inputPasswordNew.Text.Trim();
            string repeatPassword = inputPasswordNewRepeat.Text.Trim();
            string currentPassword = inputPasswordCurrent.Text.Trim();

            // 1. Password Matching Validation (Applies to both New and Existing users)
            if (!string.IsNullOrWhiteSpace(newPassword))
            {
                if (newPassword != repeatPassword)
                {
                    XtraMessageBox.Show("تکرار رمز عبور با رمز جدید یکسان نیست.", "خطا در اعتبارسنجی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                using (var db = new AutoLedgerContext())
                {
                    if (_user == null)
                    {
                        // --- Create New User ---
                        var newUser = new User
                        {
                            FullName = inputFullName.Text.Trim(),
                            NationalId = inputNationalId.Text.Trim(),
                            PhoneNumber = InputPhoneNumber.Text.Trim(),
                            Description = inputDescription.Text.Trim(),
                            Address = InputAddress.Text.Trim(),
                            CreatedAt = DateTime.Now
                        };

                        if (!string.IsNullOrWhiteSpace(newPassword))
                        {
                            newUser.Password = newPassword;
                        }

                        db.Users.Add(newUser);
                    }
                    else
                    {
                        // --- Update Existing User ---
                        var existingUser = db.Users.Find(_user.Id);

                        if (existingUser == null)
                        {
                            XtraMessageBox.Show("کاربر مورد نظر در پایگاه داده یافت نشد.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // 2. Validate Current Password (Only if attempting to change it)
                        if (!string.IsNullOrWhiteSpace(newPassword))
                        {
                            // If logged-in user has a lower ID (higher privilege), bypass the current password check
                            bool requiresCurrentPassword = Program.User.Id >= existingUser.Id;

                            if (requiresCurrentPassword && currentPassword != existingUser.Password)
                            {
                                XtraMessageBox.Show("رمز عبور فعلی صحیح نیست.", "خطا در اعتبارسنجی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // If validation passes, apply the new password
                            existingUser.Password = newPassword;
                        }

                        // Update other properties
                        existingUser.FullName = inputFullName.Text.Trim();
                        existingUser.NationalId = inputNationalId.Text.Trim();
                        existingUser.PhoneNumber = InputPhoneNumber.Text.Trim();
                        existingUser.Description = inputDescription.Text.Trim();
                        existingUser.Address = InputAddress.Text.Trim();
                    }

                    // Save all changes to the database
                    db.SaveChanges();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Include exception message for easier debugging
                XtraMessageBox.Show("خطای ناشناخته رخ داد:\n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}