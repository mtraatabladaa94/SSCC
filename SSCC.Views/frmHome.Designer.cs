namespace SSCC.Views
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.Skin = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.rbnMenu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btInventario = new DevExpress.XtraBars.BarButtonItem();
            this.btAlmacen = new DevExpress.XtraBars.BarButtonItem();
            this.btRecetas = new DevExpress.XtraBars.BarButtonItem();
            this.BarHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.BarStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btHelp = new DevExpress.XtraBars.BarButtonItem();
            this.RibbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RibbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RibbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem1 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem2 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.backstageViewClientControl3 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem3 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewItemSeparator2 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.backstageViewClientControl4 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewTabItem4 = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            ((System.ComponentModel.ISupportInitialize)(this.rbnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.backstageViewControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 581);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = null;
            this.ribbonStatusBar.Size = new System.Drawing.Size(620, 20);
            // 
            // Skin
            // 
            this.Skin.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // rbnMenu
            // 
            this.rbnMenu.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.rbnMenu.ExpandCollapseItem.Id = 0;
            this.rbnMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbnMenu.ExpandCollapseItem,
            this.btProducto,
            this.btInventario,
            this.btAlmacen,
            this.btRecetas,
            this.BarHeaderItem1,
            this.BarStaticItem1,
            this.btHelp,
            this.barButtonItem1});
            this.rbnMenu.Location = new System.Drawing.Point(0, 0);
            this.rbnMenu.MaxItemId = 15;
            this.rbnMenu.Name = "rbnMenu";
            this.rbnMenu.PageHeaderItemLinks.Add(this.BarStaticItem1);
            this.rbnMenu.PageHeaderItemLinks.Add(this.btHelp);
            this.rbnMenu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RibbonPage1,
            this.RibbonPage2});
            this.rbnMenu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.rbnMenu.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.rbnMenu.ShowToolbarCustomizeItem = false;
            this.rbnMenu.Size = new System.Drawing.Size(620, 146);
            this.rbnMenu.Toolbar.ShowCustomizeItem = false;
            // 
            // btProducto
            // 
            this.btProducto.Caption = "Registro\r\nProductos";
            this.btProducto.Id = 1;
            this.btProducto.ImageUri.Uri = "AddItem";
            this.btProducto.Name = "btProducto";
            // 
            // btInventario
            // 
            this.btInventario.Caption = "Movimientos\r\nInventario";
            this.btInventario.Id = 2;
            this.btInventario.ImageUri.Uri = "MoreLayoutOptions";
            this.btInventario.Name = "btInventario";
            // 
            // btAlmacen
            // 
            this.btAlmacen.Caption = "Almacén\r\n(Kardex)";
            this.btAlmacen.Id = 3;
            this.btAlmacen.ImageUri.Uri = "CustomizeGrid";
            this.btAlmacen.Name = "btAlmacen";
            // 
            // btRecetas
            // 
            this.btRecetas.Caption = "Archivos Excel";
            this.btRecetas.Id = 5;
            this.btRecetas.ImageUri.Uri = "SendXLSX";
            this.btRecetas.Name = "btRecetas";
            // 
            // BarHeaderItem1
            // 
            this.BarHeaderItem1.Caption = "Listo";
            this.BarHeaderItem1.Id = 7;
            this.BarHeaderItem1.Name = "BarHeaderItem1";
            // 
            // BarStaticItem1
            // 
            this.BarStaticItem1.Caption = "Michel Roberto Traña Tablada";
            this.BarStaticItem1.Id = 12;
            this.BarStaticItem1.Name = "BarStaticItem1";
            this.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btHelp
            // 
            this.btHelp.Caption = "BarButtonItem1";
            this.btHelp.Id = 13;
            this.btHelp.Name = "btHelp";
            // 
            // RibbonPage1
            // 
            this.RibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RibbonPageGroup1,
            this.RibbonPageGroup2});
            this.RibbonPage1.Name = "RibbonPage1";
            this.RibbonPage1.Text = "Archivo";
            // 
            // RibbonPageGroup1
            // 
            this.RibbonPageGroup1.ItemLinks.Add(this.btProducto);
            this.RibbonPageGroup1.ItemLinks.Add(this.btInventario);
            this.RibbonPageGroup1.ItemLinks.Add(this.btAlmacen);
            this.RibbonPageGroup1.Name = "RibbonPageGroup1";
            this.RibbonPageGroup1.ShowCaptionButton = false;
            this.RibbonPageGroup1.Text = "Datos Manuales";
            // 
            // RibbonPageGroup2
            // 
            this.RibbonPageGroup2.ItemLinks.Add(this.btRecetas);
            this.RibbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.RibbonPageGroup2.Name = "RibbonPageGroup2";
            this.RibbonPageGroup2.ShowCaptionButton = false;
            this.RibbonPageGroup2.Text = "Importar";
            // 
            // RibbonPage2
            // 
            this.RibbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.RibbonPage2.Name = "RibbonPage2";
            this.RibbonPage2.Text = "Reportes";
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl2);
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl3);
            this.backstageViewControl1.Controls.Add(this.backstageViewClientControl4);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem2);
            this.backstageViewControl1.Items.Add(this.backstageViewItemSeparator1);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem3);
            this.backstageViewControl1.Items.Add(this.backstageViewItemSeparator2);
            this.backstageViewControl1.Items.Add(this.backstageViewTabItem4);
            this.backstageViewControl1.Location = new System.Drawing.Point(30, 177);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.rbnMenu;
            this.backstageViewControl1.SelectedTab = this.backstageViewTabItem4;
            this.backstageViewControl1.SelectedTabIndex = 5;
            this.backstageViewControl1.Size = new System.Drawing.Size(578, 356);
            this.backstageViewControl1.TabIndex = 2;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(196, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(381, 292);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // backstageViewTabItem1
            // 
            this.backstageViewTabItem1.Caption = "Nuevo";
            this.backstageViewTabItem1.ContentControl = this.backstageViewClientControl1;
            this.backstageViewTabItem1.Name = "backstageViewTabItem1";
            this.backstageViewTabItem1.Selected = false;
            // 
            // backstageViewClientControl2
            // 
            this.backstageViewClientControl2.Location = new System.Drawing.Point(188, 63);
            this.backstageViewClientControl2.Name = "backstageViewClientControl2";
            this.backstageViewClientControl2.Size = new System.Drawing.Size(389, 292);
            this.backstageViewClientControl2.TabIndex = 2;
            // 
            // backstageViewTabItem2
            // 
            this.backstageViewTabItem2.Caption = "Guardar como";
            this.backstageViewTabItem2.ContentControl = this.backstageViewClientControl2;
            this.backstageViewTabItem2.Name = "backstageViewTabItem2";
            this.backstageViewTabItem2.Selected = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Estados de Cuentas";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Archivos CVS";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.ImageUri.Uri = "SendCSV";
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // backstageViewClientControl3
            // 
            this.backstageViewClientControl3.Location = new System.Drawing.Point(196, 63);
            this.backstageViewClientControl3.Name = "backstageViewClientControl3";
            this.backstageViewClientControl3.Size = new System.Drawing.Size(381, 292);
            this.backstageViewClientControl3.TabIndex = 3;
            // 
            // backstageViewTabItem3
            // 
            this.backstageViewTabItem3.Caption = "Configuración";
            this.backstageViewTabItem3.ContentControl = this.backstageViewClientControl3;
            this.backstageViewTabItem3.Name = "backstageViewTabItem3";
            this.backstageViewTabItem3.Selected = false;
            // 
            // backstageViewItemSeparator2
            // 
            this.backstageViewItemSeparator2.Name = "backstageViewItemSeparator2";
            // 
            // backstageViewClientControl4
            // 
            this.backstageViewClientControl4.Location = new System.Drawing.Point(146, 63);
            this.backstageViewClientControl4.Name = "backstageViewClientControl4";
            this.backstageViewClientControl4.Size = new System.Drawing.Size(431, 292);
            this.backstageViewClientControl4.TabIndex = 4;
            // 
            // backstageViewTabItem4
            // 
            this.backstageViewTabItem4.Caption = "Ayuda";
            this.backstageViewTabItem4.ContentControl = this.backstageViewClientControl4;
            this.backstageViewTabItem4.Name = "backstageViewTabItem4";
            this.backstageViewTabItem4.Selected = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 601);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.rbnMenu);
            this.Name = "frmHome";
            this.Ribbon = this.rbnMenu;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Sistema de Cartera de Cobros - Petronic 2017";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.rbnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.backstageViewControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        internal DevExpress.LookAndFeel.DefaultLookAndFeel Skin;
        internal DevExpress.XtraBars.Ribbon.RibbonControl rbnMenu;
        internal DevExpress.XtraBars.BarButtonItem btProducto;
        internal DevExpress.XtraBars.BarButtonItem btInventario;
        internal DevExpress.XtraBars.BarButtonItem btAlmacen;
        internal DevExpress.XtraBars.BarButtonItem btRecetas;
        internal DevExpress.XtraBars.BarHeaderItem BarHeaderItem1;
        internal DevExpress.XtraBars.BarStaticItem BarStaticItem1;
        internal DevExpress.XtraBars.BarButtonItem btHelp;
        internal DevExpress.XtraBars.Ribbon.RibbonPage RibbonPage1;
        internal DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbonPageGroup1;
        internal DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbonPageGroup2;
        internal DevExpress.XtraBars.Ribbon.RibbonPage RibbonPage2;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl3;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem3;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl4;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator2;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageViewTabItem4;
    }
}