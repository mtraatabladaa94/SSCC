using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace SSCC.Views.vProduct.Views.CustomerView{
    public partial class CustomerView : XtraUserControl {
        public CustomerView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<SSCC.Views.vProduct.ViewModels.CustomerViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                
                customerViewBindingSource, x => x.Entity, x => x.Update());
						#region Sales Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(SalesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.CustomerSalesDetails.SelectedEntity,
                    args => args.Row as SSCC.Models.POCO.Sale,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(SalesGridView, "RowClick")
						.EventToCommand(
						    x => x.CustomerSalesDetails.Edit(null), x => x.CustomerSalesDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			SalesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    SalesPopUpMenu.ShowPopup(SalesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the CustomerSalesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(SalesGridControl, g => g.DataSource, x => x.CustomerSalesDetails.Entities);
				
														fluentAPI.BindCommand(bbiSalesNew, x => x.CustomerSalesDetails.New());
																													fluentAPI.BindCommand(bbiSalesEdit,x => x.CustomerSalesDetails.Edit(null), x=>x.CustomerSalesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiSalesDelete,x => x.CustomerSalesDetails.Delete(null), x=>x.CustomerSalesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiSalesRefresh, x => x.CustomerSalesDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
