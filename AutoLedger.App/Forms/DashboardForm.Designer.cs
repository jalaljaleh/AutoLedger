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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barLabelUser = new DevExpress.XtraBars.BarStaticItem();
            this.barLabelTime = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.panelView = new System.Windows.Forms.Panel();
            this.Menu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNewReception = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCurrentCars = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnAllCars = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnNewExpens = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnExpenses = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSummary = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionBarItemLinks.Add(this.barLabelUser);
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Vazirmatn", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barLabelUser,
            this.ribbonControl1.ExpandCollapseItem,
            this.barLabelTime});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsStubGlyphs.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.OptionsStubGlyphs.UseFont = true;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(960, 49);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barLabelUser
            // 
            this.barLabelUser.Caption = "[کاربر]";
            this.barLabelUser.Description = "کاربر آنلاین است !";
            this.barLabelUser.Id = 4;
            this.barLabelUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barLabelUser.ImageOptions.SvgImage")));
            this.barLabelUser.ItemAppearance.Hovered.BackColor = System.Drawing.Color.Silver;
            this.barLabelUser.ItemAppearance.Hovered.Options.UseBackColor = true;
            this.barLabelUser.ItemAppearance.Normal.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barLabelUser.ItemAppearance.Normal.Options.UseFont = true;
            this.barLabelUser.Name = "barLabelUser";
            this.barLabelUser.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barLabelTime
            // 
            this.barLabelTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barLabelTime.Caption = "[زمان]";
            this.barLabelTime.Id = 1;
            this.barLabelTime.ItemAppearance.Hovered.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barLabelTime.ItemAppearance.Hovered.Options.UseFont = true;
            this.barLabelTime.ItemAppearance.Normal.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barLabelTime.ItemAppearance.Normal.Options.UseFont = true;
            this.barLabelTime.Name = "barLabelTime";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.barLabelTime);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 651);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(960, 45);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 49);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(756, 602);
            this.panelView.TabIndex = 12;
            // 
            // Menu
            // 
            this.Menu.Appearance.AccordionControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu.Appearance.AccordionControl.Options.UseBackColor = true;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2});
            this.Menu.Location = new System.Drawing.Point(756, 49);
            this.Menu.Name = "Menu";
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.Menu.Size = new System.Drawing.Size(204, 602);
            this.Menu.TabIndex = 0;
            this.Menu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnNewReception,
            this.btnCurrentCars,
            this.btnAllCars});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = global::AutoLedger.App.Properties.Resources.add_car;
            this.accordionControlElement1.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "خودرو";
            // 
            // btnNewReception
            // 
            this.btnNewReception.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReception.Appearance.Default.Options.UseFont = true;
            this.btnNewReception.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            this.btnNewReception.Name = "btnNewReception";
            this.btnNewReception.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNewReception.Text = "پذیرش خودرو";
            // 
            // btnCurrentCars
            // 
            this.btnCurrentCars.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentCars.Appearance.Default.Options.UseFont = true;
            this.btnCurrentCars.Name = "btnCurrentCars";
            this.btnCurrentCars.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCurrentCars.Text = "خودرو های موجود";
            // 
            // btnAllCars
            // 
            this.btnAllCars.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCars.Appearance.Default.Options.UseFont = true;
            this.btnAllCars.Name = "btnAllCars";
            this.btnAllCars.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAllCars.Text = "همه خودرو ها";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement2.Appearance.Default.Options.UseFont = true;
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnNewExpens,
            this.btnExpenses,
            this.btnSummary});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.ImageOptions.Image = global::AutoLedger.App.Properties.Resources.credit_card_1281;
            this.accordionControlElement2.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "مالی و حسابداری";
            // 
            // btnNewExpens
            // 
            this.btnNewExpens.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewExpens.Appearance.Default.Options.UseFont = true;
            this.btnNewExpens.Name = "btnNewExpens";
            this.btnNewExpens.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNewExpens.Text = "هزینه جدید";
            // 
            // btnExpenses
            // 
            this.btnExpenses.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.Appearance.Default.Options.UseFont = true;
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnExpenses.Text = "تاریخچه مخارج";
            // 
            // btnSummary
            // 
            this.btnSummary.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Appearance.Default.Options.UseFont = true;
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSummary.Text = "نمودار ماهانه";
            // 
            // DashboardForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 696);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DashboardForm.IconOptions.Icon")));
            this.IconOptions.Image = global::AutoLedger.App.Properties.Resources.irontuning_icon;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "DashboardForm";
            this.Ribbon = this.ribbonControl1;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "نرم افزار حسابداری تقویت خودرو آیرون تونینگ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private System.Windows.Forms.Panel panelView;
        private DevExpress.XtraBars.Navigation.AccordionControl Menu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNewReception;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCurrentCars;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnAllCars;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnExpenses;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSummary;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnNewExpens;
        private DevExpress.XtraBars.BarStaticItem barLabelTime;
        private DevExpress.XtraBars.BarStaticItem barLabelUser;
    }
}