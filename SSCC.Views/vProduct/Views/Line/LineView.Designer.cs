namespace SSCC.Views.vProduct.Views.LineView {
    partial class LineView {
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
						this.ProductsGridControl = new DevExpress.XtraGrid.GridControl();
			this.ProductsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ProductsBarManager = new DevExpress.XtraBars.BarManager();
			this.ProductsBar = new DevExpress.XtraBars.Bar();
			this.ProductsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.ProductsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiProductsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiProductsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiProductsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiProductsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.ProductsBarManager)).BeginInit();
						 
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
            this.mainRibbonPageGroup.Text = "Line Tasks";
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
			this.lineViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lineViewBindingSource.DataSource = typeof(SSCC.Models.POCO.Line);
			this.dataLayoutControl1.DataSource = lineViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
			parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
           				//
			//ProductsGridControl
			//
			this.ProductsGridControl.MainView = this.ProductsGridView;
			this.ProductsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsGridControl.MenuManager = this.mainRibbonControl;
            this.ProductsGridControl.Name = "ProductsGridControl";
            this.ProductsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ProductsGridView});
			//
			//ProductsGridView
			//
            this.ProductsGridView.GridControl = this.ProductsGridControl;
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.OptionsBehavior.Editable = false;
            this.ProductsGridView.OptionsBehavior.ReadOnly = true;
			//
			//ProductsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters ProductsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters MarkProductsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            MarkProductsChildPopulateColumnParameters_NotVisible.FieldName = "Mark";
		    MarkProductsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ProductsPopulateColumnsParameters.CustomColumnParameters.Add(MarkProductsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters LineProductsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            LineProductsChildPopulateColumnParameters_NotVisible.FieldName = "Line";
		    LineProductsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ProductsPopulateColumnsParameters.CustomColumnParameters.Add(LineProductsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SalesDetailsProductsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SalesDetailsProductsChildPopulateColumnParameters_NotVisible.FieldName = "SalesDetails";
		    SalesDetailsProductsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ProductsPopulateColumnsParameters.CustomColumnParameters.Add(SalesDetailsProductsChildPopulateColumnParameters_NotVisible);
							
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ProductsProductsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ProductsProductsChildPopulateColumnParameters.FieldName = "ProductsProducts";
            ProductsProductsChildPopulateColumnParameters.Path = "Products.ProductName";
			ProductsPopulateColumnsParameters.CustomColumnParameters.Add(ProductsProductsChildPopulateColumnParameters);
			 
		    this.ProductsGridView.PopulateColumns(typeof(SSCC.Models.POCO.Product),ProductsPopulateColumnsParameters);
			//
			//ProductsBindingSource
			//
			System.Windows.Forms.BindingSource ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			ProductsBindingSource.DataSource = typeof(SSCC.Models.POCO.Product);
            this.ProductsGridControl.DataSource = ProductsBindingSource;
			//
			//ProductsXtraUserControl
			//
            this.ProductsXtraUserControl.Controls.Add(ProductsGridControl);
			this.ProductsXtraUserControl.Name = "ProductsXtraUserControl";
			this.ProductsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//ProductsNew
			//
			this.bbiProductsNew.Caption = "New";
			this.bbiProductsNew.Name = "bbiProductsNew";
			this.bbiProductsNew.ImageUri.Uri = "New";
			this.bbiProductsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ProductsBarManager.Items.Add(this.bbiProductsNew);
			this.ProductsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductsNew));
			this.ProductsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductsNew));
						//
			//ProductsEdit
			//
			this.bbiProductsEdit.Caption = "Edit";
			this.bbiProductsEdit.Name = "bbiProductsEdit";
			this.bbiProductsEdit.ImageUri.Uri = "Edit";
			this.bbiProductsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ProductsBarManager.Items.Add(this.bbiProductsEdit);
			this.ProductsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductsEdit));
			this.ProductsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductsEdit));
						//
			//ProductsDelete
			//
			this.bbiProductsDelete.Caption = "Delete";
			this.bbiProductsDelete.Name = "bbiProductsDelete";
			this.bbiProductsDelete.ImageUri.Uri = "Delete";
			this.bbiProductsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ProductsBarManager.Items.Add(this.bbiProductsDelete);
			this.ProductsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductsDelete));
			this.ProductsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductsDelete));
						//
			//ProductsRefresh
			//
			this.bbiProductsRefresh.Caption = "Refresh";
			this.bbiProductsRefresh.Name = "bbiProductsRefresh";
			this.bbiProductsRefresh.ImageUri.Uri = "Refresh";
			this.bbiProductsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ProductsBarManager.Items.Add(this.bbiProductsRefresh);
			this.ProductsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductsRefresh));
			this.ProductsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiProductsRefresh));
						//
			//ProductsBar
			//
			this.ProductsBar.BarName = "Products";
            this.ProductsBar.DockCol = 0;
            this.ProductsBar.DockRow = 0;
            this.ProductsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ProductsBar.OptionsBar.AllowQuickCustomization = false;
            this.ProductsBar.OptionsBar.DrawDragBorder = false;
            this.ProductsBar.Text = "Products";
			//
			//ProductsBarManager
			//
			this.ProductsBarManager.AllowCustomization = false;
            this.ProductsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.ProductsBar});
            this.ProductsBarManager.Form = ProductsXtraUserControl;
            this.ProductsBarManager.MainMenu = this.ProductsBar;
			// 
            // ProductsPopUpMenu
            // 
            this.ProductsPopUpMenu.Manager = this.ProductsBarManager;
            this.ProductsPopUpMenu.Name = "ProductsPopUpMenu";
			//
			//ProductsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters ProductsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ProductsRetriveFieldParameters.FieldName = "Products";
            ProductsRetriveFieldParameters.ControlForField = ProductsXtraUserControl;
			ProductsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(ProductsRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(SSCC.Views.vProduct.ViewModels.LineViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.LineViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.LineViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.LineViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.LineViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.LineViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.LineViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.LineViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.LineViewModel), "ResetLayout", bbiResetLayout));
						this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//LineView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "LineView";
						((System.ComponentModel.ISupportInitialize)(this.ProductsBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource lineViewBindingSource;
				private DevExpress.XtraGrid.GridControl ProductsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView ProductsGridView;
		private DevExpress.XtraBars.BarManager ProductsBarManager;
		private DevExpress.XtraBars.Bar ProductsBar;
		private DevExpress.XtraEditors.XtraUserControl ProductsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu ProductsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiProductsNew;
				private DevExpress.XtraBars.BarButtonItem bbiProductsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiProductsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiProductsRefresh;
						 
	}
}
