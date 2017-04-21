using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace SSCC.Views.vProduct.Views.ReceiptView{
    public partial class ReceiptView : XtraUserControl {
        public ReceiptView() {
            InitializeComponent();
			if(!mvvmContext.IsDesignMode)
				InitBindings();
		}
		void InitBindings() {
		    var fluentAPI = mvvmContext.OfType<SSCC.Views.vProduct.ViewModels.ReceiptViewModel>();
			fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                receiptViewBindingSource, x => x.Entity, x => x.Update());
						#region ReceiptsAvances Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ReceiptsAvancesGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ReceiptReceiptsAvancesDetails.SelectedEntity,
                    args => args.Row as SSCC.Models.POCO.ReceiptAdvance,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ReceiptsAvancesGridView, "RowClick")
						.EventToCommand(
						    x => x.ReceiptReceiptsAvancesDetails.Edit(null), x => x.ReceiptReceiptsAvancesDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ReceiptsAvancesGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ReceiptsAvancesPopUpMenu.ShowPopup(ReceiptsAvancesGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ReceiptReceiptsAvancesDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ReceiptsAvancesGridControl, g => g.DataSource, x => x.ReceiptReceiptsAvancesDetails.Entities);
				
														fluentAPI.BindCommand(bbiReceiptsAvancesNew, x => x.ReceiptReceiptsAvancesDetails.New());
																													fluentAPI.BindCommand(bbiReceiptsAvancesEdit,x => x.ReceiptReceiptsAvancesDetails.Edit(null), x=>x.ReceiptReceiptsAvancesDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiReceiptsAvancesDelete,x => x.ReceiptReceiptsAvancesDetails.Delete(null), x=>x.ReceiptReceiptsAvancesDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiReceiptsAvancesRefresh, x => x.ReceiptReceiptsAvancesDetails.Refresh());
																	#endregion
						#region ReceiptsDetails Detail Collection
			// We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ReceiptsDetailsGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ReceiptReceiptsDetailsDetails.SelectedEntity,
                    args => args.Row as SSCC.Models.POCO.ReceiptDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
						// We want to proceed the Edit command when row double-clicked
			fluentAPI.WithEvent<RowClickEventArgs>(ReceiptsDetailsGridView, "RowClick")
						.EventToCommand(
						    x => x.ReceiptReceiptsDetailsDetails.Edit(null), x => x.ReceiptReceiptsDetailsDetails.SelectedEntity,
						    args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
						//We want to show PopupMenu when row clicked by right button
			ReceiptsDetailsGridView.RowClick += (s, e) => {
                if(e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right) {
                    ReceiptsDetailsPopUpMenu.ShowPopup(ReceiptsDetailsGridControl.PointToScreen(e.Location), s);
                }
            };
			// We want to show the ReceiptReceiptsDetailsDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
			fluentAPI.SetBinding(ReceiptsDetailsGridControl, g => g.DataSource, x => x.ReceiptReceiptsDetailsDetails.Entities);
				
														fluentAPI.BindCommand(bbiReceiptsDetailsNew, x => x.ReceiptReceiptsDetailsDetails.New());
																													fluentAPI.BindCommand(bbiReceiptsDetailsEdit,x => x.ReceiptReceiptsDetailsDetails.Edit(null), x=>x.ReceiptReceiptsDetailsDetails.SelectedEntity);
																								fluentAPI.BindCommand(bbiReceiptsDetailsDelete,x => x.ReceiptReceiptsDetailsDetails.Delete(null), x=>x.ReceiptReceiptsDetailsDetails.SelectedEntity);
																			fluentAPI.BindCommand(bbiReceiptsDetailsRefresh, x => x.ReceiptReceiptsDetailsDetails.Refresh());
																	#endregion
						 
			bbiCustomize.ItemClick += (s, e) => { dataLayoutControl1.ShowCustomizationForm(); };
       }
    }
}
