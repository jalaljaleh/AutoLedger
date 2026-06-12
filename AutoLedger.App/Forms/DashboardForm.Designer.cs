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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panelView = new System.Windows.Forms.Panel();
            this.panelActions = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBtnCarReception = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCarReception = new System.Windows.Forms.Button();
            this.labelBtnCarReception = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolbar.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelBtnCarReception.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.NavajoWhite;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.toolbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolbar.Size = new System.Drawing.Size(973, 25);
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
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.AntiqueWhite;
            this.statusStrip.Location = new System.Drawing.Point(0, 712);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(973, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "StatusBottom";
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelView.BackgroundImage = global::AutoLedger.App.Properties.Resources.background1;
            this.panelView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 115);
            this.panelView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(973, 597);
            this.panelView.TabIndex = 7;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.Transparent;
            this.panelActions.Controls.Add(this.panelBtnCarReception);
            this.panelActions.Controls.Add(this.flowLayoutPanel1);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelActions.Location = new System.Drawing.Point(0, 25);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(973, 90);
            this.panelActions.TabIndex = 0;
            // 
            // panelBtnCarReception
            // 
            this.panelBtnCarReception.AutoSize = true;
            this.panelBtnCarReception.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBtnCarReception.Controls.Add(this.btnCarReception);
            this.panelBtnCarReception.Controls.Add(this.labelBtnCarReception);
            this.panelBtnCarReception.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelBtnCarReception.Location = new System.Drawing.Point(893, 3);
            this.panelBtnCarReception.Name = "panelBtnCarReception";
            this.panelBtnCarReception.Size = new System.Drawing.Size(77, 81);
            this.panelBtnCarReception.TabIndex = 4;
            // 
            // btnCarReception
            // 
            this.btnCarReception.BackgroundImage = global::AutoLedger.App.Properties.Resources.add_car;
            this.btnCarReception.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarReception.FlatAppearance.BorderSize = 0;
            this.btnCarReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarReception.Location = new System.Drawing.Point(3, 3);
            this.btnCarReception.Name = "btnCarReception";
            this.btnCarReception.Size = new System.Drawing.Size(60, 60);
            this.btnCarReception.TabIndex = 2;
            this.btnCarReception.UseVisualStyleBackColor = true;
            // 
            // labelBtnCarReception
            // 
            this.labelBtnCarReception.AutoSize = true;
            this.labelBtnCarReception.Location = new System.Drawing.Point(3, 66);
            this.labelBtnCarReception.Name = "labelBtnCarReception";
            this.labelBtnCarReception.Size = new System.Drawing.Size(71, 15);
            this.labelBtnCarReception.TabIndex = 1;
            this.labelBtnCarReception.Text = "پذیرش خودرو";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(810, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(77, 81);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AutoLedger.App.Properties.Resources.production_order_320px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "پذیرش خودرو";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(973, 734);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelActions);
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
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.panelBtnCarReception.ResumeLayout(false);
            this.panelBtnCarReception.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel panelActions;
        private System.Windows.Forms.FlowLayoutPanel panelBtnCarReception;
        private System.Windows.Forms.Button btnCarReception;
        private System.Windows.Forms.Label labelBtnCarReception;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}