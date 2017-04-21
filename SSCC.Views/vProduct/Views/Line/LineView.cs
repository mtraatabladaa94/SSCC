using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace SSCC.Views.vProduct.Views.LineView{
    public partial class LineView : XtraUserControl {
        public LineView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<SSCC.Views.vProduct.ViewModels.LineViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                lineViewBindingSource, x => x.Entity, x => x.Update());
						#region Products Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ProductsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.LineProductsDetails.SelectedEntity,
                    args => args.Row as SSCC.Models.POCO.Product,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ProductsGridView, "RowClick")
						.EventToCommand(
						    x => x.LineProductsDetails.Edit(null), x => x.LineProductsDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ProductsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ProductsPopUpMenu.ShowPopup(ProductsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the LineProductsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ProductsGridControl, g => g.DataSource, x => x.LineProductsDetails.Entities);
				
														fluentAPI.BindCommand(bbiProductsNew, x => x.LineProductsDetails.New());
																													fluentAPI.BindCommand(bbiProductsEdit,x => x.LineProductsDetails.Edit(null), x=>x.LineProductsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiProductsDelete,x => x.LineProductsDetails.Delete(null), x=>x.LineProductsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiProductsRefresh, x => x.LineProductsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
