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
    /// Represents the single ReceiptDetail object view model.
    /// </summary>
    public partial class ReceiptDetailViewModel : SingleObjectViewModel<ReceiptDetail, Tuple<Guid, Guid>, IModelDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ReceiptDetailViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ReceiptDetailViewModel Create(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ReceiptDetailViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ReceiptDetailViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ReceiptDetailViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ReceiptDetailViewModel(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ReceiptsDetails, x => x.ReceiptDetailAmount) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Receipts for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Receipt> LookUpReceipts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ReceiptDetailViewModel x) => x.LookUpReceipts,
                    getRepositoryFunc: x => x.Receipts);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Sales for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Sale> LookUpSales {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ReceiptDetailViewModel x) => x.LookUpSales,
                    getRepositoryFunc: x => x.Sales);
            }
        }

    }
}
