namespace AutoLedger.App.Forms
{
    partial class DashboardForm
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
            this.BtnActionCurrentUser = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewReception = new System.Windows.Forms.ToolStripButton();
            this.panelView = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnActionCurrentUser.SuspendLayout();
            this.panelView.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnActionCurrentUser
            // 
            this.BtnActionCurrentUser.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BtnActionCurrentUser.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BtnActionCurrentUser.ImageScalingSize = new System.Drawing.Size(80, 80);
            this.BtnActionCurrentUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.NewReception,
            this.toolStripSeparator2});
            this.BtnActionCurrentUser.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.BtnActionCurrentUser.Location = new System.Drawing.Point(0, 25);
            this.BtnActionCurrentUser.Name = "BtnActionCurrentUser";
            this.BtnActionCurrentUser.Padding = new System.Windows.Forms.Padding(6);
            this.BtnActionCurrentUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnActionCurrentUser.Size = new System.Drawing.Size(1397, 105);
            this.BtnActionCurrentUser.TabIndex = 5;
            this.BtnActionCurrentUser.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::AutoLedger.App.Properties.Resources.checked_user;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(90, 90);
            this.toolStripButton1.Text = "[کاربر]";
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 93);
            // 
            // NewReception
            // 
            this.NewReception.AutoSize = false;
            this.NewReception.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReception.Image = global::AutoLedger.App.Properties.Resources.transport;
            this.NewReception.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewReception.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.NewReception.Name = "NewReception";
            this.NewReception.RightToLeftAutoMirrorImage = true;
            this.NewReception.Size = new System.Drawing.Size(75, 90);
            this.NewReception.Text = "پذیرش خودرو";
            this.NewReception.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.NewReception.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panelView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelView.Controls.Add(this.statusStrip1);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 130);
            this.panelView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1397, 533);
            this.panelView.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1397, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "StatusBottom";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1397, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 21);
            this.toolStripMenuItem1.Text = "فایل";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(104, 22);
            this.toolStripMenuItem2.Text = "خروج";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(58, 21);
            this.toolStripMenuItem3.Text = "ویرایش";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(51, 21);
            this.toolStripMenuItem4.Text = "راهنما";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(10);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1397, 663);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.BtnActionCurrentUser);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BtnActionCurrentUser.ResumeLayout(false);
            this.BtnActionCurrentUser.PerformLayout();
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip BtnActionCurrentUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton NewReception;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}