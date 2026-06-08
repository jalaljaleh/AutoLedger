namespace AutoLedger.App.Forms
{
    partial class CarReceptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarReceptionForm));
            this.dgCarRequests = new System.Windows.Forms.DataGridView();
            this.BtnActionCurrentUser = new System.Windows.Forms.ToolStrip();
            this.btnDeleteCurrentRequest = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.modernButton1 = new AutoLedger.App.Controls.ModernButton();
            this.inputUsage = new AutoLedger.App.Controls.ModernTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.inputColor = new AutoLedger.App.Controls.ModernTextBox();
            this.inputTip = new AutoLedger.App.Controls.ModernTextBox();
            this.inputBrand = new AutoLedger.App.Controls.ModernTextBox();
            this.btnBackToUserDetails = new System.Windows.Forms.Button();
            this.carIdControl2 = new AutoLedger.App.Controls.CarIdControl();
            this.inputModel = new AutoLedger.App.Controls.ModernTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modernTextBox4 = new AutoLedger.App.Controls.ModernTextBox();
            this.modernTextBox1 = new AutoLedger.App.Controls.ModernTextBox();
            this.modernTextBox6 = new AutoLedger.App.Controls.ModernTextBox();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsFixed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarRequests)).BeginInit();
            this.BtnActionCurrentUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCarRequests
            // 
            this.dgCarRequests.AllowUserToOrderColumns = true;
            this.dgCarRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCarRequests.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgCarRequests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCarRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgCarRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgCarRequests.ColumnHeadersHeight = 35;
            this.dgCarRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Title,
            this.Description,
            this.IsChecked,
            this.IsFixed,
            this.Action,
            this.Cost});
            this.dgCarRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgCarRequests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgCarRequests.Location = new System.Drawing.Point(0, 83);
            this.dgCarRequests.Margin = new System.Windows.Forms.Padding(10);
            this.dgCarRequests.MultiSelect = false;
            this.dgCarRequests.Name = "dgCarRequests";
            this.dgCarRequests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgCarRequests.RowHeadersVisible = false;
            this.dgCarRequests.RowHeadersWidth = 40;
            this.dgCarRequests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCarRequests.RowTemplate.DividerHeight = 5;
            this.dgCarRequests.RowTemplate.Height = 40;
            this.dgCarRequests.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCarRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgCarRequests.Size = new System.Drawing.Size(814, 311);
            this.dgCarRequests.TabIndex = 15;
            // 
            // BtnActionCurrentUser
            // 
            this.BtnActionCurrentUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnActionCurrentUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BtnActionCurrentUser.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.BtnActionCurrentUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteCurrentRequest,
            this.toolStripButton1});
            this.BtnActionCurrentUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(0, 53);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(3);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(814, 30);
            this.BtnActionCurrentUser.TabIndex = 16;
            this.BtnActionCurrentUser.Text = "toolStrip1";
            // 
            // btnDeleteCurrentRequest
            // 
            this.btnDeleteCurrentRequest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteCurrentRequest.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDeleteCurrentRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCurrentRequest.Image")));
            this.btnDeleteCurrentRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCurrentRequest.Name = "btnDeleteCurrentRequest";
            this.btnDeleteCurrentRequest.Size = new System.Drawing.Size(40, 21);
            this.btnDeleteCurrentRequest.Text = "حذف";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.Color.DarkRed;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 21);
            this.toolStripButton1.Text = "حذف همه";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgCarRequests);
            this.panel1.Controls.Add(this.BtnActionCurrentUser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 761);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(814, 53);
            this.label4.TabIndex = 17;
            this.label4.Text = "خرابی و معایب بر اساس اظهارات مشتری";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.carIdControl2);
            this.panel2.Controls.Add(this.modernTextBox6);
            this.panel2.Controls.Add(this.modernTextBox1);
            this.panel2.Controls.Add(this.modernTextBox4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.inputColor);
            this.panel2.Controls.Add(this.inputTip);
            this.panel2.Controls.Add(this.inputBrand);
            this.panel2.Controls.Add(this.inputUsage);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btnBackToUserDetails);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.inputModel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.modernButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(814, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 761);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(111, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "فرم پذیرش خودرو";
            // 
            // modernButton1
            // 
            this.modernButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.modernButton1.BorderColor = System.Drawing.Color.Gray;
            this.modernButton1.FlatAppearance.BorderSize = 0;
            this.modernButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.modernButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.modernButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modernButton1.ForeColor = System.Drawing.Color.White;
            this.modernButton1.HoverBackColor = System.Drawing.Color.LightGray;
            this.modernButton1.HoverBorderColor = System.Drawing.Color.Gray;
            this.modernButton1.Location = new System.Drawing.Point(144, 681);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.PressedBackColor = System.Drawing.Color.DarkGray;
            this.modernButton1.PressedBorderColor = System.Drawing.Color.Gray;
            this.modernButton1.Size = new System.Drawing.Size(177, 40);
            this.modernButton1.TabIndex = 14;
            this.modernButton1.Text = "ثبت و تایید اطلاعات";
            this.modernButton1.UseVisualStyleBackColor = false;
            // 
            // inputUsage
            // 
            this.inputUsage.BackColor = System.Drawing.SystemColors.Window;
            this.inputUsage.BorderColor = System.Drawing.Color.LightGray;
            this.inputUsage.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputUsage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputUsage.ForeColor = System.Drawing.Color.Black;
            this.inputUsage.Location = new System.Drawing.Point(31, 576);
            this.inputUsage.Name = "inputUsage";
            this.inputUsage.Placeholder = "کارکرد فعلی (کیلومتر)";
            this.inputUsage.PlaceholderColor = System.Drawing.SystemColors.Desktop;
            this.inputUsage.Size = new System.Drawing.Size(292, 35);
            this.inputUsage.TabIndex = 13;
            this.inputUsage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 627);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ پذیرش:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 625);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // inputColor
            // 
            this.inputColor.BackColor = System.Drawing.SystemColors.Window;
            this.inputColor.BorderColor = System.Drawing.Color.LightGray;
            this.inputColor.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputColor.ForeColor = System.Drawing.Color.Black;
            this.inputColor.Location = new System.Drawing.Point(178, 393);
            this.inputColor.Name = "inputColor";
            this.inputColor.Placeholder = "رنگ";
            this.inputColor.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputColor.Size = new System.Drawing.Size(145, 35);
            this.inputColor.TabIndex = 132;
            this.inputColor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputTip
            // 
            this.inputTip.BackColor = System.Drawing.SystemColors.Window;
            this.inputTip.BorderColor = System.Drawing.Color.LightGray;
            this.inputTip.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputTip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTip.ForeColor = System.Drawing.Color.Black;
            this.inputTip.Location = new System.Drawing.Point(31, 344);
            this.inputTip.Name = "inputTip";
            this.inputTip.Placeholder = "تیپ";
            this.inputTip.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputTip.Size = new System.Drawing.Size(145, 35);
            this.inputTip.TabIndex = 130;
            this.inputTip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputBrand
            // 
            this.inputBrand.BackColor = System.Drawing.SystemColors.Window;
            this.inputBrand.BorderColor = System.Drawing.Color.LightGray;
            this.inputBrand.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputBrand.ForeColor = System.Drawing.Color.Black;
            this.inputBrand.Location = new System.Drawing.Point(178, 344);
            this.inputBrand.Name = "inputBrand";
            this.inputBrand.Placeholder = "برند";
            this.inputBrand.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputBrand.Size = new System.Drawing.Size(145, 35);
            this.inputBrand.TabIndex = 129;
            this.inputBrand.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBackToUserDetails
            // 
            this.btnBackToUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackToUserDetails.Location = new System.Drawing.Point(31, 681);
            this.btnBackToUserDetails.Name = "btnBackToUserDetails";
            this.btnBackToUserDetails.Size = new System.Drawing.Size(107, 39);
            this.btnBackToUserDetails.TabIndex = 135;
            this.btnBackToUserDetails.Text = "برگشت";
            this.btnBackToUserDetails.UseVisualStyleBackColor = true;
            // 
            // carIdControl2
            // 
            this.carIdControl2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.carIdControl2.Location = new System.Drawing.Point(31, 266);
            this.carIdControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.carIdControl2.Name = "carIdControl2";
            this.carIdControl2.Size = new System.Drawing.Size(292, 70);
            this.carIdControl2.TabIndex = 136;
            // 
            // inputModel
            // 
            this.inputModel.BackColor = System.Drawing.SystemColors.Window;
            this.inputModel.BorderColor = System.Drawing.Color.LightGray;
            this.inputModel.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.inputModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputModel.ForeColor = System.Drawing.Color.Black;
            this.inputModel.Location = new System.Drawing.Point(31, 393);
            this.inputModel.Name = "inputModel";
            this.inputModel.Placeholder = "مدل";
            this.inputModel.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputModel.Size = new System.Drawing.Size(145, 35);
            this.inputModel.TabIndex = 131;
            this.inputModel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoLedger.App.Properties.Resources.car_wash;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 137;
            this.pictureBox1.TabStop = false;
            // 
            // modernTextBox4
            // 
            this.modernTextBox4.BackColor = System.Drawing.Color.White;
            this.modernTextBox4.BorderColor = System.Drawing.Color.LightGray;
            this.modernTextBox4.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.modernTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modernTextBox4.ForeColor = System.Drawing.Color.Black;
            this.modernTextBox4.Location = new System.Drawing.Point(29, 527);
            this.modernTextBox4.Name = "modernTextBox4";
            this.modernTextBox4.Placeholder = "تلفن همراه";
            this.modernTextBox4.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modernTextBox4.Size = new System.Drawing.Size(292, 35);
            this.modernTextBox4.TabIndex = 138;
            this.modernTextBox4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modernTextBox1
            // 
            this.modernTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.modernTextBox1.BorderColor = System.Drawing.Color.LightGray;
            this.modernTextBox1.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.modernTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modernTextBox1.ForeColor = System.Drawing.Color.Black;
            this.modernTextBox1.Location = new System.Drawing.Point(29, 441);
            this.modernTextBox1.Name = "modernTextBox1";
            this.modernTextBox1.Placeholder = "نام و نام خانوادگی تحویل دهنده";
            this.modernTextBox1.PlaceholderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modernTextBox1.Size = new System.Drawing.Size(292, 35);
            this.modernTextBox1.TabIndex = 139;
            this.modernTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modernTextBox6
            // 
            this.modernTextBox6.BackColor = System.Drawing.Color.White;
            this.modernTextBox6.BorderColor = System.Drawing.Color.LightGray;
            this.modernTextBox6.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.modernTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modernTextBox6.ForeColor = System.Drawing.Color.Black;
            this.modernTextBox6.Location = new System.Drawing.Point(29, 484);
            this.modernTextBox6.Name = "modernTextBox6";
            this.modernTextBox6.Placeholder = "کد ملی";
            this.modernTextBox6.PlaceholderColor = System.Drawing.Color.Black;
            this.modernTextBox6.Size = new System.Drawing.Size(292, 35);
            this.modernTextBox6.TabIndex = 140;
            this.modernTextBox6.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Index.HeaderText = "ردیف";
            this.Index.Name = "Index";
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 67;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.HeaderText = "عنوان";
            this.Title.Name = "Title";
            this.Title.Width = 70;
            // 
            // Description
            // 
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            // 
            // IsChecked
            // 
            this.IsChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IsChecked.HeaderText = "بررسی";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsChecked.Width = 51;
            // 
            // IsFixed
            // 
            this.IsFixed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IsFixed.HeaderText = "تعمیر شده";
            this.IsFixed.Name = "IsFixed";
            this.IsFixed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsFixed.Width = 82;
            // 
            // Action
            // 
            this.Action.HeaderText = "اقدامات صورت گرفته";
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cost
            // 
            this.Cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cost.HeaderText = "هزینه";
            this.Cost.Name = "Cost";
            this.Cost.Width = 69;
            // 
            // CarReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1164, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CarReceptionForm";
            this.Text = "فرم پذیرش خودرو";
            ((System.ComponentModel.ISupportInitialize)(this.dgCarRequests)).EndInit();
            this.BtnActionCurrentUser.ResumeLayout(false);
            this.BtnActionCurrentUser.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgCarRequests;
        private System.Windows.Forms.ToolStrip BtnActionCurrentUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Controls.ModernTextBox inputUsage;
        private Controls.ModernButton modernButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton btnDeleteCurrentRequest;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private Controls.ModernTextBox inputColor;
        private Controls.ModernTextBox inputTip;
        private Controls.ModernTextBox inputBrand;
        private System.Windows.Forms.Button btnBackToUserDetails;
        private Controls.CarIdControl carIdControl2;
        private Controls.ModernTextBox inputModel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.ModernTextBox modernTextBox4;
        private Controls.ModernTextBox modernTextBox1;
        private Controls.ModernTextBox modernTextBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsFixed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}