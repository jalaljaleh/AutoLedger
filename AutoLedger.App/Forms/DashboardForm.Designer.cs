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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem2 = new DevExpress.Utils.ToolTipSeparatorItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barUserName = new DevExpress.XtraBars.BarStaticItem();
            this.barBtnUser = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnInformations = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnUsersInformation = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionBarItemLinks.Add(this.barUserName);
            this.ribbonControl1.CaptionBarItemLinks.Add(this.barBtnUser);
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Vazirmatn", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barUserName,
            this.barBtnUser,
            this.ribbonControl1.ExpandCollapseItem,
            this.barLabelTime});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsStubGlyphs.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.OptionsStubGlyphs.UseFont = true;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Left;
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(960, 49);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barUserName
            // 
            this.barUserName.Caption = "کاربر آنلاین می باشد";
            toolTipTitleItem1.ImageOptions.Alignment = DevExpress.Utils.ToolTipImageAlignment.Right;
            toolTipTitleItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barUserName.DropDownSuperTip = superToolTip1;
            this.barUserName.Id = 6;
            this.barUserName.Name = "barUserName";
            this.barUserName.ShowImageInToolbar = false;
            toolTipTitleItem2.ImageOptions.Alignment = DevExpress.Utils.ToolTipImageAlignment.Right;
            toolTipTitleItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            superToolTip2.Items.Add(toolTipSeparatorItem1);
            this.barUserName.SuperTip = superToolTip2;
            // 
            // barBtnUser
            // 
            this.barBtnUser.ActAsDropDown = true;
            this.barBtnUser.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown;
            this.barBtnUser.Caption = "حساب کاربری";
            this.barBtnUser.Description = "حساب کاربری";
            this.barBtnUser.Id = 5;
            this.barBtnUser.ImageOptions.AllowStubGlyph = DevExpress.Utils.DefaultBoolean.False;
            this.barBtnUser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnUser.ImageOptions.SvgImage")));
            this.barBtnUser.Name = "barBtnUser";
            this.barBtnUser.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            toolTipTitleItem3.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipTitleItem3.Appearance.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Bold);
            toolTipTitleItem3.Appearance.Options.UseFont = true;
            toolTipTitleItem3.Appearance.Options.UseTextOptions = true;
            toolTipTitleItem3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            toolTipTitleItem3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            toolTipTitleItem3.ImageOptions.Alignment = DevExpress.Utils.ToolTipImageAlignment.Right;
            toolTipTitleItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage2")));
            toolTipTitleItem3.Text = "کاربر انلاین می باشد";
            toolTipItem3.Text = "کاربر انلاین می باشد";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            superToolTip3.Items.Add(toolTipSeparatorItem2);
            this.barBtnUser.SuperTip = superToolTip3;
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
            this.panelView.BackgroundImage = global::AutoLedger.App.Properties.Resources.background;
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 49);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(737, 602);
            this.panelView.TabIndex = 12;
            // 
            // Menu
            // 
            this.Menu.Appearance.AccordionControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Menu.Appearance.AccordionControl.Options.UseBackColor = true;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.btnInformations});
            this.Menu.Location = new System.Drawing.Point(737, 49);
            this.Menu.Name = "Menu";
            this.Menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.Menu.Size = new System.Drawing.Size(223, 602);
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
            this.accordionControlElement1.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            this.accordionControlElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement1.ImageOptions.SvgImage")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "خودرو";
            // 
            // btnNewReception
            // 
            this.btnNewReception.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReception.Appearance.Default.Options.UseFont = true;
            this.btnNewReception.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            this.btnNewReception.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNewReception.ImageOptions.SvgImage")));
            this.btnNewReception.Name = "btnNewReception";
            this.btnNewReception.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNewReception.Text = "پذیرش خودرو";
            // 
            // btnCurrentCars
            // 
            this.btnCurrentCars.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentCars.Appearance.Default.Options.UseFont = true;
            this.btnCurrentCars.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCurrentCars.ImageOptions.SvgImage")));
            this.btnCurrentCars.Name = "btnCurrentCars";
            this.btnCurrentCars.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCurrentCars.Text = "پذیرش های جاری";
            // 
            // btnAllCars
            // 
            this.btnAllCars.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCars.Appearance.Default.Options.UseFont = true;
            this.btnAllCars.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAllCars.ImageOptions.SvgImage")));
            this.btnAllCars.Name = "btnAllCars";
            this.btnAllCars.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnAllCars.Text = "تاریخچه پذیرش ها";
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
            this.accordionControlElement2.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            this.accordionControlElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement2.ImageOptions.SvgImage")));
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "مالی و حسابداری";
            // 
            // btnNewExpens
            // 
            this.btnNewExpens.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewExpens.Appearance.Default.Options.UseFont = true;
            this.btnNewExpens.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNewExpens.ImageOptions.SvgImage")));
            this.btnNewExpens.Name = "btnNewExpens";
            this.btnNewExpens.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnNewExpens.Text = "هزینه جدید";
            // 
            // btnExpenses
            // 
            this.btnExpenses.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.Appearance.Default.Options.UseFont = true;
            this.btnExpenses.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExpenses.ImageOptions.SvgImage")));
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnExpenses.Text = "تاریخچه مخارج";
            // 
            // btnSummary
            // 
            this.btnSummary.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummary.Appearance.Default.Options.UseFont = true;
            this.btnSummary.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSummary.ImageOptions.SvgImage")));
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSummary.Text = "نمودار ماهانه";
            // 
            // btnInformations
            // 
            this.btnInformations.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformations.Appearance.Default.Options.UseFont = true;
            this.btnInformations.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnUsersInformation});
            this.btnInformations.Expanded = true;
            this.btnInformations.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInformations.ImageOptions.SvgImage")));
            this.btnInformations.Name = "btnInformations";
            this.btnInformations.Text = "اطلاعات";
            // 
            // btnUsersInformation
            // 
            this.btnUsersInformation.Appearance.Default.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersInformation.Appearance.Default.Options.UseFont = true;
            this.btnUsersInformation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUsersInformation.ImageOptions.SvgImage")));
            this.btnUsersInformation.Name = "btnUsersInformation";
            this.btnUsersInformation.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnUsersInformation.Text = "مشتری ها";
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
            this.IconOptions.LargeImage = global::AutoLedger.App.Properties.Resources.irontuning_icon1;
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnInformations;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnUsersInformation;
        private DevExpress.XtraBars.BarButtonItem barBtnUser;
        private DevExpress.XtraBars.BarStaticItem barUserName;
    }
}