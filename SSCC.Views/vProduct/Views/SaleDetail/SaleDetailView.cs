using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace SSCC.Views.vProduct.Views.SaleDetailView{
    public partial class SaleDetailView : XtraUserControl {
        public SaleDetailView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<SSCC.Views.vProduct.ViewModels.SaleDetailViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                saleDetailViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for Product LookUp editor
			fluentAPI.SetBinding(ProductLookUpEdit.Properties, p => p.DataSource, x => x.LookUpProducts.Entities);
						// Binding for Sale LookUp editor
			fluentAPI.SetBinding(SaleLookUpEdit.Properties, p => p.DataSource, x => x.LookUpSales.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
