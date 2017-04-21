using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace SSCC.Views.vProduct.Views.ReceiptDetailView{
    public partial class ReceiptDetailView : XtraUserControl {
        public ReceiptDetailView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<SSCC.Views.vProduct.ViewModels.ReceiptDetailViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                receiptDetailViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for Receipt LookUp editor
			fluentAPI.SetBinding(ReceiptLookUpEdit.Properties, p => p.DataSource, x => x.LookUpReceipts.Entities);
						// Binding for Sale LookUp editor
			fluentAPI.SetBinding(SaleLookUpEdit.Properties, p => p.DataSource, x => x.LookUpSales.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
