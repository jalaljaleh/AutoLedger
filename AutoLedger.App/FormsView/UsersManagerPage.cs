using AutoLedger.App.Forms; // Assuming you have a UserForm
using AutoLedger.App.FormsModal;
using AutoLedger.Data;
using AutoLedger.Domain;
using AutoLedger.Extensions;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AutoLedger.App.FormsView
{
    public partial class UsersManagerPage : UserControl
    {
        private readonly Timer _searchTimer;
        private int _usersPage = 0;
        private const int PageSize = 50;

        public UsersManagerPage()
        {
            InitializeComponent();

            _searchTimer = new Timer { Interval = 500 };
            _searchTimer.Tick += SearchTimer_Tick;
            inputSearch.TextChanged += InputSearch_TextChanged;

            btnNewUser.Click += BtnNewUser_Click;
            btnEditUser.Click += BtnEditUser_Click;
            btnRefresh.Click += BtnRefresh_Click;
            btnUsersNextPage.Click += BtnUsersNextPage_Click;
            btnUsersBackPage.Click += BtnUsersBackPage_Click;

            dgUsers.RowPostPaint += DgUsers_RowPostPaint;
            dgUsers.CellFormatting += DgUsers_CellFormatting;
            this.btnDeleteUser.Click += BtnDeleteUser_Click;
            RefreshUsers();
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            // 1. Check if a row is selected
            if (dgUsers.SelectedRows.Count < 1)
            {
                MessageBox.Show("لطفا ابتدا یک کاربر را از لیست انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = dgUsers.SelectedRows[0].DataBoundItem as User;
            if (user == null) return;

            // 2. Prevent self-deletion
            if (Program.User.Id == user.Id)
            {
                MessageBox.Show("شما نمی‌توانید حساب کاربری خود را حذف کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Permission/Security check (optional: matching your logic)
            if (Program.User.Id > user.Id)
            {
                MessageBox.Show("شما اجازه حذف این کاربر را ندارید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Confirmation dialog
            var result = MessageBox.Show($"آیا از حذف کاربر '{user.FullName}' اطمینان دارید؟\nاین عملیات غیرقابل بازگشت است.",
                                         "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var db = new AutoLedgerContext())
                    {
                        // Attach the user to the context so it can be tracked for deletion
                        db.Users.Attach(user);
                        db.Users.Remove(user);
                        db.SaveChanges();
                    }

                    // Refresh the grid to show the updated list
                    RefreshUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"خطا در حذف کاربر: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnEditUser_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedRows.Count < 1)
            {
                MessageBox.Show("لطفا یک کاربر را انتخاب کنید.");
                return;
            }

            var user = dgUsers.SelectedRows[0].DataBoundItem as User;

            if (Program.User.Id == user.Id)
            {
                MessageBox.Show("شما نمی‌توانید اطلاعات خود را از این بخش ویرایش کنید. لطفا از بخش پروفایل استفاده کنید.");
                return;
            }
            else if (Program.User.Id > user.Id)
            {
                MessageBox.Show("شما نمی‌توانید اطلاعات این کاربر را ویرایش کنید.");
                return;
            }
          
            using (var userForm = new UserForm(user))
            {
                if (userForm.ShowDialog() == DialogResult.OK)
                    RefreshUsers();
            }
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            using (var userForm = new UserForm(null))
            {
                if (userForm.ShowDialog() == DialogResult.OK)
                    RefreshUsers();
            }
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _usersPage = 0; 
            RefreshUsers();
        }

        private void InputSearch_TextChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        public void RefreshUsers()
        {
            using (var db = new AutoLedgerContext())
            {
                dgUsers.AutoGenerateColumns = false;
                string search = inputSearch.Text.Trim();

                IQueryable<User> query = db.Users;

                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(u =>
                        u.FullName.Contains(search) ||
                        u.PhoneNumber.Contains(search) ||
                        u.NationalId.Contains(search) ||
                        u.Address.Contains(search)
                    );
                }

                var list = query
                    .OrderByDescending(u => u.CreatedAt)
                    .Skip(_usersPage * PageSize)
                    .Take(PageSize)
                    .AsNoTracking()
                    .ToList();

                btnUsersBackPage.Enabled = (_usersPage > 0);
                btnUsersNextPage.Enabled = (list.Count == PageSize);

                dgUsers.DataSource = list;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            inputSearch.Text = string.Empty;
            _usersPage = 0;
            RefreshUsers();
        }

        private void BtnUsersBackPage_Click(object sender, EventArgs e)
        {
            if (_usersPage <= 0) return;
            _usersPage--;
            RefreshUsers();
        }

        private void BtnUsersNextPage_Click(object sender, EventArgs e)
        {
            _usersPage++;
            RefreshUsers();
        }

        private void DgUsers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var row = dgUsers.Rows[e.RowIndex];
            if (row.Cells.Count > 0) row.Cells[0].Value = (e.RowIndex + 1 + (_usersPage * PageSize));
        }

        private void DgUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgUsers.Columns.Count) return;
            string col = dgUsers.Columns[e.ColumnIndex].Name;

            if (col == "CreatedAt")
            {
                if (e.Value is DateTime dt)
                {
                    e.Value = dt.ToShamsi();
                    e.FormattingApplied = true;
                }
            }
        }
    }
}