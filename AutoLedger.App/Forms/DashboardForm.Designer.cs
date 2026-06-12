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
            this.toolbar = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelView = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuRight = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolbar.SuspendLayout();
            this.menuRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.toolbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolbar.Size = new System.Drawing.Size(1162, 25);
            this.toolbar.TabIndex = 8;
            this.toolbar.Text = "menuStrip1";
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
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelView.BackgroundImage = global::AutoLedger.App.Properties.Resources.background1;
            this.panelView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 25);
            this.panelView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1162, 711);
            this.panelView.TabIndex = 7;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.AntiqueWhite;
            this.statusStrip.Location = new System.Drawing.Point(0, 736);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1162, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "StatusBottom";
            // 
            // menuRight
            // 
            this.menuRight.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuRight.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.menuRight.Location = new System.Drawing.Point(1029, 25);
            this.menuRight.Name = "menuRight";
            this.menuRight.Size = new System.Drawing.Size(133, 711);
            this.menuRight.TabIndex = 0;
            this.menuRight.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackgroundImage = global::AutoLedger.App.Properties.Resources.transport;
            this.toolStripButton1.Image = global::AutoLedger.App.Properties.Resources.transport;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(130, 149);
            this.toolStripButton1.Text = "پذیرش خودرو";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1162, 758);
            this.Controls.Add(this.menuRight);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolbar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار حسابداری تقویت خودرو آیرون تونینگ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.menuRight.ResumeLayout(false);
            this.menuRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip toolbar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStrip menuRight;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}