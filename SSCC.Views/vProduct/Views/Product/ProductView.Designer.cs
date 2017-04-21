namespace SSCC.Views.vProduct.Views.ProductView {
    partial class ProductView {
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
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroupLayout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiCustomize = new DevExpress.XtraBars.BarButtonItem();
						this.SalesDetailsGridControl = new DevExpress.XtraGrid.GridControl();
			this.SalesDetailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.SalesDetailsBarManager = new DevExpress.XtraBars.BarManager();
			this.SalesDetailsBar = new DevExpress.XtraBars.Bar();
			this.SalesDetailsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.SalesDetailsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiSalesDetailsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSalesDetailsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSalesDetailsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiSalesDetailsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.SalesDetailsBarManager)).BeginInit();
									this.LineLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.LineBindingSource = new System.Windows.Forms.BindingSource(this.components);
						this.MarkLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
			this.MarkBindingSource = new System.Windows.Forms.BindingSource(this.components);
			 
			this.SuspendLayout();
			// 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
			this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.bbiCustomize});
            this.mainRibbonControl.Name = "mainRibbonControl";
			this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
						DevExpress.XtraBars.BarButtonItem bbiSave = new DevExpress.XtraBars.BarButtonItem();
			bbiSave.Caption = "Save";
			bbiSave.Name = "bbiSave";
			bbiSave.ImageUri.Uri = "Save";
			this.mainRibbonControl.Items.Add(bbiSave);
						DevExpress.XtraBars.BarButtonItem bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
			bbiSaveAndClose.Caption = "Save And Close";
			bbiSaveAndClose.Name = "bbiSaveAndClose";
			bbiSaveAndClose.ImageUri.Uri = "SaveAndClose";
			this.mainRibbonControl.Items.Add(bbiSaveAndClose);
						DevExpress.XtraBars.BarButtonItem bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
			bbiSaveAndNew.Caption = "Save And New";
			bbiSaveAndNew.Name = "bbiSaveAndNew";
			bbiSaveAndNew.ImageUri.Uri = "SaveAndNew";
			this.mainRibbonControl.Items.Add(bbiSaveAndNew);
						DevExpress.XtraBars.BarButtonItem bbiReset = new DevExpress.XtraBars.BarButtonItem();
			bbiReset.Caption = "Reset Changes";
			bbiReset.Name = "bbiReset";
			bbiReset.ImageUri.Uri = "Reset";
			this.mainRibbonControl.Items.Add(bbiReset);
						DevExpress.XtraBars.BarButtonItem bbiDelete = new DevExpress.XtraBars.BarButtonItem();
			bbiDelete.Caption = "Delete";
			bbiDelete.Name = "bbiDelete";
			bbiDelete.ImageUri.Uri = "Delete";
			this.mainRibbonControl.Items.Add(bbiDelete);
						DevExpress.XtraBars.BarButtonItem bbiClose = new DevExpress.XtraBars.BarButtonItem();
			bbiClose.Caption = "Close";
			bbiClose.Name = "bbiClose";
			bbiClose.ImageUri.Uri = "Close";
			this.mainRibbonControl.Items.Add(bbiClose);
						DevExpress.XtraBars.BarButtonItem bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
			bbiSaveLayout.Caption = "Save Layout";
			bbiSaveLayout.Name = "bbiSaveLayout";
			bbiSaveLayout.ImageUri.Uri = "Save";
			this.mainRibbonControl.Items.Add(bbiSaveLayout);
						DevExpress.XtraBars.BarButtonItem bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
			bbiResetLayout.Caption = "Reset Layout";
			bbiResetLayout.Name = "bbiResetLayout";
			bbiResetLayout.ImageUri.Uri = "Reset";
			this.mainRibbonControl.Items.Add(bbiResetLayout);
			            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroupLayout});
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
			this.mainRibbonPage.MergeOrder = 0;
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
						this.mainRibbonPageGroup.ItemLinks.Add(bbiSave);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiSaveAndClose);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiSaveAndNew);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiReset);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiDelete);
						this.mainRibbonPageGroup.ItemLinks.Add(bbiClose);
			            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.ShowCaptionButton = false;
            this.mainRibbonPageGroup.Text = "Product Tasks";
			// 
            // ribbonPageGroupLayout
            //
			this.ribbonPageGroupLayout.AllowTextClipping = false; 
			this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiCustomize);
						this.ribbonPageGroupLayout.ItemLinks.Add(bbiSaveLayout);
						this.ribbonPageGroupLayout.ItemLinks.Add(bbiResetLayout);
			            this.ribbonPageGroupLayout.Name = "ribbonPageGroupLayout";
            this.ribbonPageGroupLayout.Text = "Layout";
			// 
            // bbiCustomize
            // 
            this.bbiCustomize.Caption = "Customize";
            this.bbiCustomize.ImageUri.Uri = "Customization";
            this.bbiCustomize.Name = "bbiCustomize";
			// 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.TextVisible = false;
			// 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.productViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productViewBindingSource.DataSource = typeof(SSCC.Models.POCO.Product);
			this.dataLayoutControl1.DataSource = productViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
			parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
           				//
			//SalesDetailsGridControl
			//
			this.SalesDetailsGridControl.MainView = this.SalesDetailsGridView;
			this.SalesDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesDetailsGridControl.MenuManager = this.mainRibbonControl;
            this.SalesDetailsGridControl.Name = "SalesDetailsGridControl";
            this.SalesDetailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SalesDetailsGridView});
			//
			//SalesDetailsGridView
			//
            this.SalesDetailsGridView.GridControl = this.SalesDetailsGridControl;
            this.SalesDetailsGridView.Name = "SalesDetailsGridView";
            this.SalesDetailsGridView.OptionsBehavior.Editable = false;
            this.SalesDetailsGridView.OptionsBehavior.ReadOnly = true;
			//
			//SalesDetailsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters SalesDetailsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SaleSalesDetailsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SaleSalesDetailsChildPopulateColumnParameters_NotVisible.FieldName = "Sale";
		    SaleSalesDetailsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SalesDetailsPopulateColumnsParameters.CustomColumnParameters.Add(SaleSalesDetailsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ProductSalesDetailsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ProductSalesDetailsChildPopulateColumnParameters_NotVisible.FieldName = "Product";
		    ProductSalesDetailsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			SalesDetailsPopulateColumnsParameters.CustomColumnParameters.Add(ProductSalesDetailsChildPopulateColumnParameters_NotVisible);
							
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SalesDetailsSalesDetailsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SalesDetailsSalesDetailsChildPopulateColumnParameters.FieldName = "SalesDetailsSalesDetails";
            SalesDetailsSalesDetailsChildPopulateColumnParameters.Path = "SalesDetails.DetailSaleQuantity";
			SalesDetailsPopulateColumnsParameters.CustomColumnParameters.Add(SalesDetailsSalesDetailsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters LineSalesDetailsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            LineSalesDetailsChildPopulateColumnParameters.FieldName = "LineSalesDetails";
            LineSalesDetailsChildPopulateColumnParameters.Path = "Line.LineName";
			SalesDetailsPopulateColumnsParameters.CustomColumnParameters.Add(LineSalesDetailsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters MarkSalesDetailsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            MarkSalesDetailsChildPopulateColumnParameters.FieldName = "MarkSalesDetails";
            MarkSalesDetailsChildPopulateColumnParameters.Path = "Mark.MarkName";
			SalesDetailsPopulateColumnsParameters.CustomColumnParameters.Add(MarkSalesDetailsChildPopulateColumnParameters);
			 
		    this.SalesDetailsGridView.PopulateColumns(typeof(SSCC.Models.POCO.SaleDetail),SalesDetailsPopulateColumnsParameters);
			//
			//SalesDetailsBindingSource
			//
			System.Windows.Forms.BindingSource SalesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			SalesDetailsBindingSource.DataSource = typeof(SSCC.Models.POCO.SaleDetail);
            this.SalesDetailsGridControl.DataSource = SalesDetailsBindingSource;
			//
			//SalesDetailsXtraUserControl
			//
            this.SalesDetailsXtraUserControl.Controls.Add(SalesDetailsGridControl);
			this.SalesDetailsXtraUserControl.Name = "SalesDetailsXtraUserControl";
			this.SalesDetailsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//SalesDetailsNew
			//
			this.bbiSalesDetailsNew.Caption = "New";
			this.bbiSalesDetailsNew.Name = "bbiSalesDetailsNew";
			this.bbiSalesDetailsNew.ImageUri.Uri = "New";
			this.bbiSalesDetailsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SalesDetailsBarManager.Items.Add(this.bbiSalesDetailsNew);
			this.SalesDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSalesDetailsNew));
			this.SalesDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSalesDetailsNew));
						//
			//SalesDetailsEdit
			//
			this.bbiSalesDetailsEdit.Caption = "Edit";
			this.bbiSalesDetailsEdit.Name = "bbiSalesDetailsEdit";
			this.bbiSalesDetailsEdit.ImageUri.Uri = "Edit";
			this.bbiSalesDetailsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SalesDetailsBarManager.Items.Add(this.bbiSalesDetailsEdit);
			this.SalesDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSalesDetailsEdit));
			this.SalesDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSalesDetailsEdit));
						//
			//SalesDetailsDelete
			//
			this.bbiSalesDetailsDelete.Caption = "Delete";
			this.bbiSalesDetailsDelete.Name = "bbiSalesDetailsDelete";
			this.bbiSalesDetailsDelete.ImageUri.Uri = "Delete";
			this.bbiSalesDetailsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SalesDetailsBarManager.Items.Add(this.bbiSalesDetailsDelete);
			this.SalesDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSalesDetailsDelete));
			this.SalesDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSalesDetailsDelete));
						//
			//SalesDetailsRefresh
			//
			this.bbiSalesDetailsRefresh.Caption = "Refresh";
			this.bbiSalesDetailsRefresh.Name = "bbiSalesDetailsRefresh";
			this.bbiSalesDetailsRefresh.ImageUri.Uri = "Refresh";
			this.bbiSalesDetailsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.SalesDetailsBarManager.Items.Add(this.bbiSalesDetailsRefresh);
			this.SalesDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSalesDetailsRefresh));
			this.SalesDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiSalesDetailsRefresh));
						//
			//SalesDetailsBar
			//
			this.SalesDetailsBar.BarName = "SalesDetails";
            this.SalesDetailsBar.DockCol = 0;
            this.SalesDetailsBar.DockRow = 0;
            this.SalesDetailsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.SalesDetailsBar.OptionsBar.AllowQuickCustomization = false;
            this.SalesDetailsBar.OptionsBar.DrawDragBorder = false;
            this.SalesDetailsBar.Text = "SalesDetails";
			//
			//SalesDetailsBarManager
			//
			this.SalesDetailsBarManager.AllowCustomization = false;
            this.SalesDetailsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.SalesDetailsBar});
            this.SalesDetailsBarManager.Form = SalesDetailsXtraUserControl;
            this.SalesDetailsBarManager.MainMenu = this.SalesDetailsBar;
			// 
            // SalesDetailsPopUpMenu
            // 
            this.SalesDetailsPopUpMenu.Manager = this.SalesDetailsBarManager;
            this.SalesDetailsPopUpMenu.Name = "SalesDetailsPopUpMenu";
			//
			//SalesDetailsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters SalesDetailsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            SalesDetailsRetriveFieldParameters.FieldName = "SalesDetails";
            SalesDetailsRetriveFieldParameters.ControlForField = SalesDetailsXtraUserControl;
			SalesDetailsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(SalesDetailsRetriveFieldParameters);
									//
			//LineLookUpEdit
			//
			this.LineBindingSource.DataSource = typeof(SSCC.Models.POCO.Line);
			this.LineLookUpEdit.Properties.ValueMember = "LineID"; 
			this.LineLookUpEdit.Properties.DisplayMember = "LineName";
			this.LineLookUpEdit.Properties.DataSource = this.LineBindingSource;
			this.LineLookUpEdit.Name = "LineLookUpEdit";
			this.LineLookUpEdit.DataBindings.Add("EditValue", productViewBindingSource, "LineID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters LineLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            LineLookUpEditRetrieveFieldParameters.FieldName = "LineID";
            LineLookUpEditRetrieveFieldParameters.ControlForField = this.LineLookUpEdit;
			parameters.CustomListParameters.Add(LineLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters LineLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    LineLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Line";
		    LineLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(LineLookUpEditRetrieveFieldParameters_NotGenerate);
						//
			//MarkLookUpEdit
			//
			this.MarkBindingSource.DataSource = typeof(SSCC.Models.POCO.Mark);
			this.MarkLookUpEdit.Properties.ValueMember = "MarkID"; 
			this.MarkLookUpEdit.Properties.DisplayMember = "MarkName";
			this.MarkLookUpEdit.Properties.DataSource = this.MarkBindingSource;
			this.MarkLookUpEdit.Name = "MarkLookUpEdit";
			this.MarkLookUpEdit.DataBindings.Add("EditValue", productViewBindingSource, "MarkID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			DevExpress.XtraDataLayout.RetrieveFieldParameters MarkLookUpEditRetrieveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            MarkLookUpEditRetrieveFieldParameters.FieldName = "MarkID";
            MarkLookUpEditRetrieveFieldParameters.ControlForField = this.MarkLookUpEdit;
			parameters.CustomListParameters.Add(MarkLookUpEditRetrieveFieldParameters);
			DevExpress.XtraDataLayout.RetrieveFieldParameters MarkLookUpEditRetrieveFieldParameters_NotGenerate = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
		    MarkLookUpEditRetrieveFieldParameters_NotGenerate.FieldName = "Mark";
		    MarkLookUpEditRetrieveFieldParameters_NotGenerate.GenerateField = false;
			parameters.CustomListParameters.Add(MarkLookUpEditRetrieveFieldParameters_NotGenerate);
			 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(SSCC.Views.vProduct.ViewModels.ProductViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ProductViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ProductViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ProductViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ProductViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ProductViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ProductViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ProductViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ProductViewModel), "ResetLayout", bbiResetLayout));
						this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//ProductView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "ProductView";
						((System.ComponentModel.ISupportInitialize)(this.SalesDetailsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
		private DevExpress.XtraBars.BarButtonItem bbiCustomize;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupLayout;
		private System.Windows.Forms.BindingSource productViewBindingSource;
				private DevExpress.XtraGrid.GridControl SalesDetailsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView SalesDetailsGridView;
		private DevExpress.XtraBars.BarManager SalesDetailsBarManager;
		private DevExpress.XtraBars.Bar SalesDetailsBar;
		private DevExpress.XtraEditors.XtraUserControl SalesDetailsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu SalesDetailsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiSalesDetailsNew;
				private DevExpress.XtraBars.BarButtonItem bbiSalesDetailsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiSalesDetailsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiSalesDetailsRefresh;
								private DevExpress.XtraEditors.GridLookUpEdit LineLookUpEdit;
		private System.Windows.Forms.BindingSource LineBindingSource;
				private DevExpress.XtraEditors.GridLookUpEdit MarkLookUpEdit;
		private System.Windows.Forms.BindingSource MarkBindingSource;
		 
	}
}
