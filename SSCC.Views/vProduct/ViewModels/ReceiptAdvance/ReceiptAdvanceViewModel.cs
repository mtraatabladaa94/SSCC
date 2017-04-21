using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using SSCC.Views.vProduct.ModelDbDataModel;
using SSCC.Views.vProduct.Common;
using SSCC.Models.POCO;

namespace SSCC.Views.vProduct.ViewModels {

    /// <summary>
    /// Represents the single ReceiptAdvance object view model.
    /// </summary>
    public partial class ReceiptAdvanceViewModel : SingleObjectViewModel<ReceiptAdvance, Tuple<Guid, Guid, Guid>, IModelDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ReceiptAdvanceViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ReceiptAdvanceViewModel Create(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ReceiptAdvanceViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ReceiptAdvanceViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ReceiptAdvanceViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ReceiptAdvanceViewModel(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ReceiptsAdvances, x => x.ProductQuantity) {
                    AddLookUpProperty(() => LookUpSalesDetails, () => LookUpSaleDetailEntity, () => new { Entity.ProductID, Entity.SaleID });
                }

        public virtual SaleDetail LookUpSaleDetailEntity { get; set; }

        /// <summary>
        /// The view model that contains a look-up collection of Receipts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Receipt> LookUpReceipts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ReceiptAdvanceViewModel x) => x.LookUpReceipts,
                    getRepositoryFunc: x => x.Receipts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of SalesDetails for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<SaleDetail> LookUpSalesDetails {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ReceiptAdvanceViewModel x) => x.LookUpSalesDetails,
                    getRepositoryFunc: x => x.SalesDetails);
            }
        }

    }
}
