namespace SSCC.Views.vProduct.Views.ReceiptView {
    partial class ReceiptView {
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
						this.ReceiptsAvancesGridControl = new DevExpress.XtraGrid.GridControl();
			this.ReceiptsAvancesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ReceiptsAvancesBarManager = new DevExpress.XtraBars.BarManager();
			this.ReceiptsAvancesBar = new DevExpress.XtraBars.Bar();
			this.ReceiptsAvancesXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.ReceiptsAvancesPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiReceiptsAvancesNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiReceiptsAvancesEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiReceiptsAvancesDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiReceiptsAvancesRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.ReceiptsAvancesBarManager)).BeginInit();
						this.ReceiptsDetailsGridControl = new DevExpress.XtraGrid.GridControl();
			this.ReceiptsDetailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ReceiptsDetailsBarManager = new DevExpress.XtraBars.BarManager();
			this.ReceiptsDetailsBar = new DevExpress.XtraBars.Bar();
			this.ReceiptsDetailsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.ReceiptsDetailsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiReceiptsDetailsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiReceiptsDetailsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiReceiptsDetailsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiReceiptsDetailsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.ReceiptsDetailsBarManager)).BeginInit();
						 
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
            this.mainRibbonPageGroup.Text = "Receipt Tasks";
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
			this.receiptViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.receiptViewBindingSource.DataSource = typeof(SSCC.Models.POCO.Receipt);
			this.dataLayoutControl1.DataSource = receiptViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
			parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
           				//
			//ReceiptsAvancesGridControl
			//
			this.ReceiptsAvancesGridControl.MainView = this.ReceiptsAvancesGridView;
			this.ReceiptsAvancesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceiptsAvancesGridControl.MenuManager = this.mainRibbonControl;
            this.ReceiptsAvancesGridControl.Name = "ReceiptsAvancesGridControl";
            this.ReceiptsAvancesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ReceiptsAvancesGridView});
			//
			//ReceiptsAvancesGridView
			//
            this.ReceiptsAvancesGridView.GridControl = this.ReceiptsAvancesGridControl;
            this.ReceiptsAvancesGridView.Name = "ReceiptsAvancesGridView";
            this.ReceiptsAvancesGridView.OptionsBehavior.Editable = false;
            this.ReceiptsAvancesGridView.OptionsBehavior.ReadOnly = true;
			//
			//ReceiptsAvancesPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters ReceiptsAvancesPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SaleDetailReceiptsAvancesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SaleDetailReceiptsAvancesChildPopulateColumnParameters_NotVisible.FieldName = "SaleDetail";
		    SaleDetailReceiptsAvancesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ReceiptsAvancesPopulateColumnsParameters.CustomColumnParameters.Add(SaleDetailReceiptsAvancesChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ReceiptReceiptsAvancesChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ReceiptReceiptsAvancesChildPopulateColumnParameters_NotVisible.FieldName = "Receipt";
		    ReceiptReceiptsAvancesChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ReceiptsAvancesPopulateColumnsParameters.CustomColumnParameters.Add(ReceiptReceiptsAvancesChildPopulateColumnParameters_NotVisible);
							
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ReceiptsAvancesReceiptsAvancesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ReceiptsAvancesReceiptsAvancesChildPopulateColumnParameters.FieldName = "ReceiptsAvancesReceiptsAvances";
            ReceiptsAvancesReceiptsAvancesChildPopulateColumnParameters.Path = "ReceiptsAvances.ProductQuantity";
			ReceiptsAvancesPopulateColumnsParameters.CustomColumnParameters.Add(ReceiptsAvancesReceiptsAvancesChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ReceiptsDetailsReceiptsAvancesChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ReceiptsDetailsReceiptsAvancesChildPopulateColumnParameters.FieldName = "ReceiptsDetailsReceiptsAvances";
            ReceiptsDetailsReceiptsAvancesChildPopulateColumnParameters.Path = "ReceiptsDetails.ReceiptDetailAmount";
			ReceiptsAvancesPopulateColumnsParameters.CustomColumnParameters.Add(ReceiptsDetailsReceiptsAvancesChildPopulateColumnParameters);
			 
		    this.ReceiptsAvancesGridView.PopulateColumns(typeof(SSCC.Models.POCO.ReceiptAdvance),ReceiptsAvancesPopulateColumnsParameters);
			//
			//ReceiptsAvancesBindingSource
			//
			System.Windows.Forms.BindingSource ReceiptsAvancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			ReceiptsAvancesBindingSource.DataSource = typeof(SSCC.Models.POCO.ReceiptAdvance);
            this.ReceiptsAvancesGridControl.DataSource = ReceiptsAvancesBindingSource;
			//
			//ReceiptsAvancesXtraUserControl
			//
            this.ReceiptsAvancesXtraUserControl.Controls.Add(ReceiptsAvancesGridControl);
			this.ReceiptsAvancesXtraUserControl.Name = "ReceiptsAvancesXtraUserControl";
			this.ReceiptsAvancesXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//ReceiptsAvancesNew
			//
			this.bbiReceiptsAvancesNew.Caption = "New";
			this.bbiReceiptsAvancesNew.Name = "bbiReceiptsAvancesNew";
			this.bbiReceiptsAvancesNew.ImageUri.Uri = "New";
			this.bbiReceiptsAvancesNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ReceiptsAvancesBarManager.Items.Add(this.bbiReceiptsAvancesNew);
			this.ReceiptsAvancesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsAvancesNew));
			this.ReceiptsAvancesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsAvancesNew));
						//
			//ReceiptsAvancesEdit
			//
			this.bbiReceiptsAvancesEdit.Caption = "Edit";
			this.bbiReceiptsAvancesEdit.Name = "bbiReceiptsAvancesEdit";
			this.bbiReceiptsAvancesEdit.ImageUri.Uri = "Edit";
			this.bbiReceiptsAvancesEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ReceiptsAvancesBarManager.Items.Add(this.bbiReceiptsAvancesEdit);
			this.ReceiptsAvancesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsAvancesEdit));
			this.ReceiptsAvancesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsAvancesEdit));
						//
			//ReceiptsAvancesDelete
			//
			this.bbiReceiptsAvancesDelete.Caption = "Delete";
			this.bbiReceiptsAvancesDelete.Name = "bbiReceiptsAvancesDelete";
			this.bbiReceiptsAvancesDelete.ImageUri.Uri = "Delete";
			this.bbiReceiptsAvancesDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ReceiptsAvancesBarManager.Items.Add(this.bbiReceiptsAvancesDelete);
			this.ReceiptsAvancesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsAvancesDelete));
			this.ReceiptsAvancesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsAvancesDelete));
						//
			//ReceiptsAvancesRefresh
			//
			this.bbiReceiptsAvancesRefresh.Caption = "Refresh";
			this.bbiReceiptsAvancesRefresh.Name = "bbiReceiptsAvancesRefresh";
			this.bbiReceiptsAvancesRefresh.ImageUri.Uri = "Refresh";
			this.bbiReceiptsAvancesRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ReceiptsAvancesBarManager.Items.Add(this.bbiReceiptsAvancesRefresh);
			this.ReceiptsAvancesBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsAvancesRefresh));
			this.ReceiptsAvancesPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsAvancesRefresh));
						//
			//ReceiptsAvancesBar
			//
			this.ReceiptsAvancesBar.BarName = "ReceiptsAvances";
            this.ReceiptsAvancesBar.DockCol = 0;
            this.ReceiptsAvancesBar.DockRow = 0;
            this.ReceiptsAvancesBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ReceiptsAvancesBar.OptionsBar.AllowQuickCustomization = false;
            this.ReceiptsAvancesBar.OptionsBar.DrawDragBorder = false;
            this.ReceiptsAvancesBar.Text = "ReceiptsAvances";
			//
			//ReceiptsAvancesBarManager
			//
			this.ReceiptsAvancesBarManager.AllowCustomization = false;
            this.ReceiptsAvancesBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.ReceiptsAvancesBar});
            this.ReceiptsAvancesBarManager.Form = ReceiptsAvancesXtraUserControl;
            this.ReceiptsAvancesBarManager.MainMenu = this.ReceiptsAvancesBar;
			// 
            // ReceiptsAvancesPopUpMenu
            // 
            this.ReceiptsAvancesPopUpMenu.Manager = this.ReceiptsAvancesBarManager;
            this.ReceiptsAvancesPopUpMenu.Name = "ReceiptsAvancesPopUpMenu";
			//
			//ReceiptsAvancesRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters ReceiptsAvancesRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ReceiptsAvancesRetriveFieldParameters.FieldName = "ReceiptsAvances";
            ReceiptsAvancesRetriveFieldParameters.ControlForField = ReceiptsAvancesXtraUserControl;
			ReceiptsAvancesRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(ReceiptsAvancesRetriveFieldParameters);
						//
			//ReceiptsDetailsGridControl
			//
			this.ReceiptsDetailsGridControl.MainView = this.ReceiptsDetailsGridView;
			this.ReceiptsDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceiptsDetailsGridControl.MenuManager = this.mainRibbonControl;
            this.ReceiptsDetailsGridControl.Name = "ReceiptsDetailsGridControl";
            this.ReceiptsDetailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ReceiptsDetailsGridView});
			//
			//ReceiptsDetailsGridView
			//
            this.ReceiptsDetailsGridView.GridControl = this.ReceiptsDetailsGridControl;
            this.ReceiptsDetailsGridView.Name = "ReceiptsDetailsGridView";
            this.ReceiptsDetailsGridView.OptionsBehavior.Editable = false;
            this.ReceiptsDetailsGridView.OptionsBehavior.ReadOnly = true;
			//
			//ReceiptsDetailsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters ReceiptsDetailsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters SaleReceiptsDetailsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            SaleReceiptsDetailsChildPopulateColumnParameters_NotVisible.FieldName = "Sale";
		    SaleReceiptsDetailsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ReceiptsDetailsPopulateColumnsParameters.CustomColumnParameters.Add(SaleReceiptsDetailsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ReceiptReceiptsDetailsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ReceiptReceiptsDetailsChildPopulateColumnParameters_NotVisible.FieldName = "Receipt";
		    ReceiptReceiptsDetailsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ReceiptsDetailsPopulateColumnsParameters.CustomColumnParameters.Add(ReceiptReceiptsDetailsChildPopulateColumnParameters_NotVisible);
							
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ReceiptsAvancesReceiptsDetailsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ReceiptsAvancesReceiptsDetailsChildPopulateColumnParameters.FieldName = "ReceiptsAvancesReceiptsDetails";
            ReceiptsAvancesReceiptsDetailsChildPopulateColumnParameters.Path = "ReceiptsAvances.ProductQuantity";
			ReceiptsDetailsPopulateColumnsParameters.CustomColumnParameters.Add(ReceiptsAvancesReceiptsDetailsChildPopulateColumnParameters);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ReceiptsDetailsReceiptsDetailsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ReceiptsDetailsReceiptsDetailsChildPopulateColumnParameters.FieldName = "ReceiptsDetailsReceiptsDetails";
            ReceiptsDetailsReceiptsDetailsChildPopulateColumnParameters.Path = "ReceiptsDetails.ReceiptDetailAmount";
			ReceiptsDetailsPopulateColumnsParameters.CustomColumnParameters.Add(ReceiptsDetailsReceiptsDetailsChildPopulateColumnParameters);
			 
		    this.ReceiptsDetailsGridView.PopulateColumns(typeof(SSCC.Models.POCO.ReceiptDetail),ReceiptsDetailsPopulateColumnsParameters);
			//
			//ReceiptsDetailsBindingSource
			//
			System.Windows.Forms.BindingSource ReceiptsDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			ReceiptsDetailsBindingSource.DataSource = typeof(SSCC.Models.POCO.ReceiptDetail);
            this.ReceiptsDetailsGridControl.DataSource = ReceiptsDetailsBindingSource;
			//
			//ReceiptsDetailsXtraUserControl
			//
            this.ReceiptsDetailsXtraUserControl.Controls.Add(ReceiptsDetailsGridControl);
			this.ReceiptsDetailsXtraUserControl.Name = "ReceiptsDetailsXtraUserControl";
			this.ReceiptsDetailsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//ReceiptsDetailsNew
			//
			this.bbiReceiptsDetailsNew.Caption = "New";
			this.bbiReceiptsDetailsNew.Name = "bbiReceiptsDetailsNew";
			this.bbiReceiptsDetailsNew.ImageUri.Uri = "New";
			this.bbiReceiptsDetailsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ReceiptsDetailsBarManager.Items.Add(this.bbiReceiptsDetailsNew);
			this.ReceiptsDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsDetailsNew));
			this.ReceiptsDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsDetailsNew));
						//
			//ReceiptsDetailsEdit
			//
			this.bbiReceiptsDetailsEdit.Caption = "Edit";
			this.bbiReceiptsDetailsEdit.Name = "bbiReceiptsDetailsEdit";
			this.bbiReceiptsDetailsEdit.ImageUri.Uri = "Edit";
			this.bbiReceiptsDetailsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ReceiptsDetailsBarManager.Items.Add(this.bbiReceiptsDetailsEdit);
			this.ReceiptsDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsDetailsEdit));
			this.ReceiptsDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsDetailsEdit));
						//
			//ReceiptsDetailsDelete
			//
			this.bbiReceiptsDetailsDelete.Caption = "Delete";
			this.bbiReceiptsDetailsDelete.Name = "bbiReceiptsDetailsDelete";
			this.bbiReceiptsDetailsDelete.ImageUri.Uri = "Delete";
			this.bbiReceiptsDetailsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ReceiptsDetailsBarManager.Items.Add(this.bbiReceiptsDetailsDelete);
			this.ReceiptsDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsDetailsDelete));
			this.ReceiptsDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsDetailsDelete));
						//
			//ReceiptsDetailsRefresh
			//
			this.bbiReceiptsDetailsRefresh.Caption = "Refresh";
			this.bbiReceiptsDetailsRefresh.Name = "bbiReceiptsDetailsRefresh";
			this.bbiReceiptsDetailsRefresh.ImageUri.Uri = "Refresh";
			this.bbiReceiptsDetailsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ReceiptsDetailsBarManager.Items.Add(this.bbiReceiptsDetailsRefresh);
			this.ReceiptsDetailsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsDetailsRefresh));
			this.ReceiptsDetailsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiReceiptsDetailsRefresh));
						//
			//ReceiptsDetailsBar
			//
			this.ReceiptsDetailsBar.BarName = "ReceiptsDetails";
            this.ReceiptsDetailsBar.DockCol = 0;
            this.ReceiptsDetailsBar.DockRow = 0;
            this.ReceiptsDetailsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ReceiptsDetailsBar.OptionsBar.AllowQuickCustomization = false;
            this.ReceiptsDetailsBar.OptionsBar.DrawDragBorder = false;
            this.ReceiptsDetailsBar.Text = "ReceiptsDetails";
			//
			//ReceiptsDetailsBarManager
			//
			this.ReceiptsDetailsBarManager.AllowCustomization = false;
            this.ReceiptsDetailsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.ReceiptsDetailsBar});
            this.ReceiptsDetailsBarManager.Form = ReceiptsDetailsXtraUserControl;
            this.ReceiptsDetailsBarManager.MainMenu = this.ReceiptsDetailsBar;
			// 
            // ReceiptsDetailsPopUpMenu
            // 
            this.ReceiptsDetailsPopUpMenu.Manager = this.ReceiptsDetailsBarManager;
            this.ReceiptsDetailsPopUpMenu.Name = "ReceiptsDetailsPopUpMenu";
			//
			//ReceiptsDetailsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters ReceiptsDetailsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ReceiptsDetailsRetriveFieldParameters.FieldName = "ReceiptsDetails";
            ReceiptsDetailsRetriveFieldParameters.ControlForField = ReceiptsDetailsXtraUserControl;
			ReceiptsDetailsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(ReceiptsDetailsRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(SSCC.Views.vProduct.ViewModels.ReceiptViewModel);
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ReceiptViewModel), "Save", bbiSave));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ReceiptViewModel), "SaveAndClose", bbiSaveAndClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ReceiptViewModel), "SaveAndNew", bbiSaveAndNew));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ReceiptViewModel), "Reset", bbiReset));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ReceiptViewModel), "Delete", bbiDelete));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ReceiptViewModel), "Close", bbiClose));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ReceiptViewModel), "SaveLayout", bbiSaveLayout));
						this.mvvmContext.BindingExpressions.Add(DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(SSCC.Views.vProduct.ViewModels.ReceiptViewModel), "ResetLayout", bbiResetLayout));
						this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
			//
			//ReceiptView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.mainRibbonControl);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "ReceiptView";
						((System.ComponentModel.ISupportInitialize)(this.ReceiptsAvancesBarManager)).EndInit();
						((System.ComponentModel.ISupportInitialize)(this.ReceiptsDetailsBarManager)).EndInit();
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
		private System.Windows.Forms.BindingSource receiptViewBindingSource;
				private DevExpress.XtraGrid.GridControl ReceiptsAvancesGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView ReceiptsAvancesGridView;
		private DevExpress.XtraBars.BarManager ReceiptsAvancesBarManager;
		private DevExpress.XtraBars.Bar ReceiptsAvancesBar;
		private DevExpress.XtraEditors.XtraUserControl ReceiptsAvancesXtraUserControl;
		private DevExpress.XtraBars.PopupMenu ReceiptsAvancesPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiReceiptsAvancesNew;
				private DevExpress.XtraBars.BarButtonItem bbiReceiptsAvancesEdit;
				private DevExpress.XtraBars.BarButtonItem bbiReceiptsAvancesDelete;
				private DevExpress.XtraBars.BarButtonItem bbiReceiptsAvancesRefresh;
						private DevExpress.XtraGrid.GridControl ReceiptsDetailsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView ReceiptsDetailsGridView;
		private DevExpress.XtraBars.BarManager ReceiptsDetailsBarManager;
		private DevExpress.XtraBars.Bar ReceiptsDetailsBar;
		private DevExpress.XtraEditors.XtraUserControl ReceiptsDetailsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu ReceiptsDetailsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiReceiptsDetailsNew;
				private DevExpress.XtraBars.BarButtonItem bbiReceiptsDetailsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiReceiptsDetailsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiReceiptsDetailsRefresh;
						 
	}
}
