using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace SSCC.Views.vProduct.Views.ReceiptAdvanceView{
    public partial class ReceiptAdvanceView : XtraUserControl {
        public ReceiptAdvanceView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<SSCC.Views.vProduct.ViewModels.ReceiptAdvanceViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                receiptAdvanceViewBindingSource, x => x.Entity, x => x.Update());
									// Binding for Receipt LookUp editor
			fluentAPI.SetBinding(ReceiptLookUpEdit.Properties, p => p.DataSource, x => x.LookUpReceipts.Entities);
						// Binding for SaleDetail LookUp editor
			fluentAPI.SetBinding(SaleDetailLookUpEdit.Properties, p => p.DataSource, x => x.LookUpSalesDetails.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
