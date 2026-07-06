using AutoLedger.Data;
using AutoLedger.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLedger.App.Forms
{
    public partial class UserForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        private User _user;

        public UserForm(User user = null)
        {
            InitializeComponent();
            _user = user;

            if (user != null)
            {
                this.inputCreatedAt.Text = user.CreatedAt.ToShamsiLong();
                this.inputId.Text = user.Id.ToString();

                this.inputFullName.Text = user.FullName;
                this.inputNationalId.Text = user.NationalId;
                this.InputPhoneNumber.Text = user.PhoneNumber;
                this.inputDescription.Text = user.Description;
                this.InputAddress.Text = user.Address;

                this.HtmlText = user.FullName;
            }
            else
            {
                this.inputCreatedAt.Text = DateTime.Now.ToShamsiLong();
                this.HtmlText = "ثبت کاربر جدید";

            }

            this.btnCancel.Click += BtnCancel_Click;
            this.btnConfirm.Click += BtnConfirm_Click;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (AutoLedgerContext db = new AutoLedgerContext())
                {
                    if (_user == null)
                    {
                        User newUser = new User
                        {
                            FullName = inputFullName.Text,
                            NationalId = inputNationalId.Text,
                            PhoneNumber = InputPhoneNumber.Text,
                            Description = inputDescription.Text,
                            Address = InputAddress.Text,
                            CreatedAt = DateTime.Now
                        };

                        if (!string.IsNullOrWhiteSpace(inputPasswordNew.Text))
                        {
                            newUser.Password = inputPasswordNew.Text.Trim().GetHashCode().ToString();
                        }

                        db.Users.Add(newUser);
                    }
                    else
                    {
                        var existingUser = db.Users.Find(_user.Id);

                        if (!string.IsNullOrWhiteSpace(inputPasswordNew.Text))
                        {
                            if (inputPasswordCurrent.Text != existingUser.Password)
                            {
                                MessageBox.Show("رمز عبور فعلی صحیح نیست.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (inputPasswordNew.Text != inputPasswordNewRepeat.Text)
                            {
                                MessageBox.Show("تکرار رمز عبور صحیح نیست.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        if (existingUser != null)
                        {
                            existingUser.FullName = inputFullName.Text;
                            existingUser.NationalId = inputNationalId.Text;
                            existingUser.PhoneNumber = InputPhoneNumber.Text;
                            existingUser.Description = inputDescription.Text;
                            existingUser.Address = InputAddress.Text;

                            existingUser.Password = inputPasswordNew.Text;
                        }
                    }

                    db.SaveChanges();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("خطای ناشناخته رخ داد.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}