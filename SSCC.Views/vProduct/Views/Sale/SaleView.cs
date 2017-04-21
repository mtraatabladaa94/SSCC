using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace SSCC.Views.vProduct.Views.SaleView{
    public partial class SaleView : XtraUserControl {
        public SaleView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<SSCC.Views.vProduct.ViewModels.SaleViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                saleViewBindingSource, x => x.Entity, x => x.Update());
						#region SalesDetails Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SalesDetailsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.SaleSalesDetailsDetails.SelectedEntity,
                    args => args.Row as SSCC.Models.POCO.SaleDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SalesDetailsGridView, "RowClick")
						.EventToCommand(
						    x => x.SaleSalesDetailsDetails.Edit(null), x => x.SaleSalesDetailsDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SalesDetailsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SalesDetailsPopUpMenu.ShowPopup(SalesDetailsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the SaleSalesDetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SalesDetailsGridControl, g => g.DataSource, x => x.SaleSalesDetailsDetails.Entities);
				
														fluentAPI.BindCommand(bbiSalesDetailsNew, x => x.SaleSalesDetailsDetails.New());
																													fluentAPI.BindCommand(bbiSalesDetailsEdit,x => x.SaleSalesDetailsDetails.Edit(null), x=>x.SaleSalesDetailsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSalesDetailsDelete,x => x.SaleSalesDetailsDetails.Delete(null), x=>x.SaleSalesDetailsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSalesDetailsRefresh, x => x.SaleSalesDetailsDetails.Refresh());
																	#endregion
									// Binding for Customer LookUp editor
			fluentAPI.SetBinding(CustomerLookUpEdit.Properties, p => p.DataSource, x => x.LookUpCustomers.Entities);
			 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
