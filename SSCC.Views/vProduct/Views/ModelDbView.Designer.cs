namespace SSCC.Views.vProduct.Views.ModelDbView {
    partial class ModelDbView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.ribbonPageGroupNavigation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.barSubItemNavigation = new DevExpress.XtraBars.BarSubItem();
			this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
			this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
									this.navigationBarItemCustomerCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemCustomerCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemSaleCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemSaleCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemSaleDetailCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemSaleDetailCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemProductCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemProductCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemLineCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemLineCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemMarkCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemMarkCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemReceiptCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemReceiptCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemReceiptAdvanceCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemReceiptAdvanceCollectionView = new DevExpress.XtraBars.BarButtonItem();
						this.navigationBarItemReceiptDetailCollectionView = new DevExpress.XtraBars.Navigation.NavigationBarItem();
			this.barButtonItemReceiptDetailCollectionView = new DevExpress.XtraBars.BarButtonItem();
						            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            this.SuspendLayout();
			// 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.MaxItemId = 14;
            this.ribbonControl.Name = "ribbonControl";
			this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.skinRibbonGalleryBarItem, this.barSubItemNavigation });
			this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
			this.ribbonControl.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
			this.ribbonPageGroupNavigation,
            this.ribbonPageGroup});
			this.ribbonPage.MergeOrder = -1;
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "View";
			// 
            // ribbonPageGroupNavigation
            // 
            this.ribbonPageGroupNavigation.ItemLinks.Add(this.barSubItemNavigation);
            this.ribbonPageGroupNavigation.Name = "ribbonPageGroupNavigation";
            this.ribbonPageGroupNavigation.Text = "Module";
			 // 
            // barSubItemNavigation
            // 
            this.barSubItemNavigation.Caption = "Navigation";
            this.barSubItemNavigation.ImageUri.Uri = "NavigationBar";
            this.barSubItemNavigation.Name = "barSubItemNavigation";
			            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
			this.ribbonPageGroup.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.ShowCaptionButton = false;
            this.ribbonPageGroup.Text = "Appearance";
			// 
            // ribbonStatusBar
            // 
			this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
			// 
            // officeNavigationBar
            //
			this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom; 
            this.officeNavigationBar.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            			this.navigationBarItemCustomerCollectionView,
						this.navigationBarItemSaleCollectionView,
						this.navigationBarItemSaleDetailCollectionView,
						this.navigationBarItemProductCollectionView,
						this.navigationBarItemLineCollectionView,
						this.navigationBarItemMarkCollectionView,
						this.navigationBarItemReceiptCollectionView,
						this.navigationBarItemReceiptAdvanceCollectionView,
						this.navigationBarItemReceiptDetailCollectionView,
									
			});
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.Text = "officeNavigationBar";
						// 
            // navigationBarItemCustomerCollectionView
            // 
			this.navigationBarItemCustomerCollectionView.Name = "navigationBarItemCustomerCollectionView";
            this.navigationBarItemCustomerCollectionView.Text = "Customers";
			// 
            // barButtonItemCustomerCollectionView
            // 
			this.barButtonItemCustomerCollectionView.Name = "barButtonItemCustomerCollectionView";
            this.barButtonItemCustomerCollectionView.Caption = "Customers";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemCustomerCollectionView));
					
						// 
            // navigationBarItemSaleCollectionView
            // 
			this.navigationBarItemSaleCollectionView.Name = "navigationBarItemSaleCollectionView";
            this.navigationBarItemSaleCollectionView.Text = "Sales";
			// 
            // barButtonItemSaleCollectionView
            // 
			this.barButtonItemSaleCollectionView.Name = "barButtonItemSaleCollectionView";
            this.barButtonItemSaleCollectionView.Caption = "Sales";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSaleCollectionView));
					
						// 
            // navigationBarItemSaleDetailCollectionView
            // 
			this.navigationBarItemSaleDetailCollectionView.Name = "navigationBarItemSaleDetailCollectionView";
            this.navigationBarItemSaleDetailCollectionView.Text = "Sales Details";
			// 
            // barButtonItemSaleDetailCollectionView
            // 
			this.barButtonItemSaleDetailCollectionView.Name = "barButtonItemSaleDetailCollectionView";
            this.barButtonItemSaleDetailCollectionView.Caption = "Sales Details";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemSaleDetailCollectionView));
					
						// 
            // navigationBarItemProductCollectionView
            // 
			this.navigationBarItemProductCollectionView.Name = "navigationBarItemProductCollectionView";
            this.navigationBarItemProductCollectionView.Text = "Products";
			// 
            // barButtonItemProductCollectionView
            // 
			this.barButtonItemProductCollectionView.Name = "barButtonItemProductCollectionView";
            this.barButtonItemProductCollectionView.Caption = "Products";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemProductCollectionView));
					
						// 
            // navigationBarItemLineCollectionView
            // 
			this.navigationBarItemLineCollectionView.Name = "navigationBarItemLineCollectionView";
            this.navigationBarItemLineCollectionView.Text = "Lines";
			// 
            // barButtonItemLineCollectionView
            // 
			this.barButtonItemLineCollectionView.Name = "barButtonItemLineCollectionView";
            this.barButtonItemLineCollectionView.Caption = "Lines";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemLineCollectionView));
					
						// 
            // navigationBarItemMarkCollectionView
            // 
			this.navigationBarItemMarkCollectionView.Name = "navigationBarItemMarkCollectionView";
            this.navigationBarItemMarkCollectionView.Text = "Marks";
			// 
            // barButtonItemMarkCollectionView
            // 
			this.barButtonItemMarkCollectionView.Name = "barButtonItemMarkCollectionView";
            this.barButtonItemMarkCollectionView.Caption = "Marks";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemMarkCollectionView));
					
						// 
            // navigationBarItemReceiptCollectionView
            // 
			this.navigationBarItemReceiptCollectionView.Name = "navigationBarItemReceiptCollectionView";
            this.navigationBarItemReceiptCollectionView.Text = "Receipts";
			// 
            // barButtonItemReceiptCollectionView
            // 
			this.barButtonItemReceiptCollectionView.Name = "barButtonItemReceiptCollectionView";
            this.barButtonItemReceiptCollectionView.Caption = "Receipts";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemReceiptCollectionView));
					
						// 
            // navigationBarItemReceiptAdvanceCollectionView
            // 
			this.navigationBarItemReceiptAdvanceCollectionView.Name = "navigationBarItemReceiptAdvanceCollectionView";
            this.navigationBarItemReceiptAdvanceCollectionView.Text = "Receipts Advances";
			// 
            // barButtonItemReceiptAdvanceCollectionView
            // 
			this.barButtonItemReceiptAdvanceCollectionView.Name = "barButtonItemReceiptAdvanceCollectionView";
            this.barButtonItemReceiptAdvanceCollectionView.Caption = "Receipts Advances";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemReceiptAdvanceCollectionView));
					
						// 
            // navigationBarItemReceiptDetailCollectionView
            // 
			this.navigationBarItemReceiptDetailCollectionView.Name = "navigationBarItemReceiptDetailCollectionView";
            this.navigationBarItemReceiptDetailCollectionView.Text = "Receipts Details";
			// 
            // barButtonItemReceiptDetailCollectionView
            // 
			this.barButtonItemReceiptDetailCollectionView.Name = "barButtonItemReceiptDetailCollectionView";
            this.barButtonItemReceiptDetailCollectionView.Caption = "Receipts Details";
											this.barSubItemNavigation.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemReceiptDetailCollectionView));
					
							
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(SSCC.Views.vProduct.ViewModels.ModelDbViewModel);
			 // 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.navigationFrame.Text = "navigationFrame";
			// 
            // ModelDbView
            // 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "ModelDbView";
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
		}
		
        #endregion

		private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupNavigation;
		private DevExpress.XtraBars.BarSubItem barSubItemNavigation;
		private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
		private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame; 
						private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemCustomerCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemCustomerCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemSaleCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemSaleCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemSaleDetailCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemSaleDetailCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemProductCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemProductCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemLineCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemLineCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemMarkCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemMarkCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemReceiptCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemReceiptCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemReceiptAdvanceCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemReceiptAdvanceCollectionView;
				private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItemReceiptDetailCollectionView;
		private DevExpress.XtraBars.BarButtonItem  barButtonItemReceiptDetailCollectionView;
					}
}
