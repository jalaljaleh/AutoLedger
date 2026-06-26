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
            this.panelActions = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBtnCarReception = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCarReception = new System.Windows.Forms.Button();
            this.labelBtnCarReception = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCarsAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelView = new System.Windows.Forms.Panel();
            this.toolbar.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelBtnCarReception.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.OldLace;
            this.toolbar.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.toolbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolbar.Size = new System.Drawing.Size(960, 32);
            this.toolbar.TabIndex = 8;
            this.toolbar.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 26);
            this.toolStripMenuItem1.Text = "فایل";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(109, 26);
            this.toolStripMenuItem2.Text = "خروج";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(59, 26);
            this.toolStripMenuItem3.Text = "ویرایش";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(51, 26);
            this.toolStripMenuItem4.Text = "راهنما";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.OldLace;
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(960, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "StatusBottom";
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.OldLace;
            this.panelActions.Controls.Add(this.panelBtnCarReception);
            this.panelActions.Controls.Add(this.flowLayoutPanel1);
            this.panelActions.Controls.Add(this.flowLayoutPanel4);
            this.panelActions.Controls.Add(this.flowLayoutPanel5);
            this.panelActions.Controls.Add(this.flowLayoutPanel3);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelActions.Location = new System.Drawing.Point(0, 32);
            this.panelActions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(960, 81);
            this.panelActions.TabIndex = 0;
            this.panelActions.Paint += new System.Windows.Forms.PaintEventHandler(this.panelActions_Paint);
            // 
            // panelBtnCarReception
            // 
            this.panelBtnCarReception.AutoSize = true;
            this.panelBtnCarReception.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBtnCarReception.Controls.Add(this.btnCarReception);
            this.panelBtnCarReception.Controls.Add(this.labelBtnCarReception);
            this.panelBtnCarReception.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelBtnCarReception.Location = new System.Drawing.Point(869, 3);
            this.panelBtnCarReception.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBtnCarReception.Name = "panelBtnCarReception";
            this.panelBtnCarReception.Size = new System.Drawing.Size(87, 68);
            this.panelBtnCarReception.TabIndex = 4;
            // 
            // btnCarReception
            // 
            this.btnCarReception.BackgroundImage = global::AutoLedger.App.Properties.Resources.maintenance;
            this.btnCarReception.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarReception.FlatAppearance.BorderSize = 0;
            this.btnCarReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarReception.Location = new System.Drawing.Point(4, 3);
            this.btnCarReception.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCarReception.Name = "btnCarReception";
            this.btnCarReception.Size = new System.Drawing.Size(79, 42);
            this.btnCarReception.TabIndex = 2;
            this.btnCarReception.UseVisualStyleBackColor = true;
            // 
            // labelBtnCarReception
            // 
            this.labelBtnCarReception.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelBtnCarReception.Location = new System.Drawing.Point(4, 48);
            this.labelBtnCarReception.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBtnCarReception.Name = "labelBtnCarReception";
            this.labelBtnCarReception.Size = new System.Drawing.Size(79, 20);
            this.labelBtnCarReception.TabIndex = 1;
            this.labelBtnCarReception.Text = "پذیرش خودرو";
            this.labelBtnCarReception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btnCarsAll);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(774, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(87, 70);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnCarsAll
            // 
            this.btnCarsAll.BackgroundImage = global::AutoLedger.App.Properties.Resources.engine_room128;
            this.btnCarsAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCarsAll.FlatAppearance.BorderSize = 0;
            this.btnCarsAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarsAll.Location = new System.Drawing.Point(4, 3);
            this.btnCarsAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCarsAll.Name = "btnCarsAll";
            this.btnCarsAll.Size = new System.Drawing.Size(79, 42);
            this.btnCarsAll.TabIndex = 2;
            this.btnCarsAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "همه خودروها";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Controls.Add(this.btnExpenses);
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(694, 3);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(72, 71);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackgroundImage = global::AutoLedger.App.Properties.Resources.passbook;
            this.btnExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Location = new System.Drawing.Point(4, 3);
            this.btnExpenses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(64, 43);
            this.btnExpenses.TabIndex = 2;
            this.btnExpenses.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "هزینه ها";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.button3);
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(627, 3);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(59, 70);
            this.flowLayoutPanel5.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::AutoLedger.App.Properties.Resources.budget;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(4, 3);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 42);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "گزارشات حسابداری";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.button1);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(548, 3);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(71, 70);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AutoLedger.App.Properties.Resources.develop_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 42);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "تنظیمات";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.Transparent;
            this.panelView.BackgroundImage = global::AutoLedger.App.Properties.Resources.background;
            this.panelView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 113);
            this.panelView.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(960, 594);
            this.panelView.TabIndex = 7;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(960, 729);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolbar);
            this.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار حسابداری تقویت خودرو آیرون تونینگ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.panelBtnCarReception.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btnCarsAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
    }
}