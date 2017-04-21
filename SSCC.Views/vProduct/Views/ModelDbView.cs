using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;
using DevExpress.Utils.MVVM;

namespace SSCC.Views.vProduct.Views.ModelDbView{
    public partial class ModelDbView : XtraUserControl {
        public ModelDbView() {
			InitializeComponent();
			if(!mvvmContext.IsDesignMode)
                InitializeNavigation();
            ribbonControl.Merge += ribbonControl_Merge;
            ribbonControl.UnMerge += ribbonControl_UnMerge;
        }

        private void ribbonControl_UnMerge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergeOwner.SelectedPage;
            ribbonControl.StatusBar.UnMergeStatusBar();
        }

        void ribbonControl_Merge(object sender, DevExpress.XtraBars.Ribbon.RibbonMergeEventArgs e) {
            ribbonControl.SelectedPage = e.MergedChild.SelectedPage;
            ribbonControl.StatusBar.MergeStatusBar(e.MergedChild.StatusBar);
        }
        void InitializeNavigation() {
			DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013 Light Gray");	

            mvvmContext.RegisterService(DocumentManagerService.Create(navigationFrame));
            DevExpress.Utils.MVVM.MVVMContext.RegisterFlyoutDialogService();
            // We want to use buttons in Ribbon to show the specific modules
            var fluentAPI = mvvmContext.OfType<SSCC.Views.vProduct.ViewModels.ModelDbViewModel>();
			            fluentAPI.BindCommand(navigationBarItemCustomerCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			fluentAPI.BindCommand(barButtonItemCustomerCollectionView, (x, m) => x.Show(m), x => x.Modules[0]);
			            fluentAPI.BindCommand(navigationBarItemSaleCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			fluentAPI.BindCommand(barButtonItemSaleCollectionView, (x, m) => x.Show(m), x => x.Modules[1]);
			            fluentAPI.BindCommand(navigationBarItemSaleDetailCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			fluentAPI.BindCommand(barButtonItemSaleDetailCollectionView, (x, m) => x.Show(m), x => x.Modules[2]);
			            fluentAPI.BindCommand(navigationBarItemProductCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			fluentAPI.BindCommand(barButtonItemProductCollectionView, (x, m) => x.Show(m), x => x.Modules[3]);
			            fluentAPI.BindCommand(navigationBarItemLineCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			fluentAPI.BindCommand(barButtonItemLineCollectionView, (x, m) => x.Show(m), x => x.Modules[4]);
			            fluentAPI.BindCommand(navigationBarItemMarkCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			fluentAPI.BindCommand(barButtonItemMarkCollectionView, (x, m) => x.Show(m), x => x.Modules[5]);
			            fluentAPI.BindCommand(navigationBarItemReceiptCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			fluentAPI.BindCommand(barButtonItemReceiptCollectionView, (x, m) => x.Show(m), x => x.Modules[6]);
			            fluentAPI.BindCommand(navigationBarItemReceiptAdvanceCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
			fluentAPI.BindCommand(barButtonItemReceiptAdvanceCollectionView, (x, m) => x.Show(m), x => x.Modules[7]);
			            fluentAPI.BindCommand(navigationBarItemReceiptDetailCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
			fluentAPI.BindCommand(barButtonItemReceiptDetailCollectionView, (x, m) => x.Show(m), x => x.Modules[8]);
						            // We want show the default module when our UserControl is loaded
            fluentAPI.WithEvent<EventArgs>(this, "Load")
                .EventToCommand(x => x.OnLoaded(null), x => x.DefaultModule);
        }
    }
}
