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
    /// Represents the single Receipt object view model.
    /// </summary>
    public partial class ReceiptViewModel : SingleObjectViewModel<Receipt, Guid, IModelDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ReceiptViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ReceiptViewModel Create(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ReceiptViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ReceiptViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ReceiptViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ReceiptViewModel(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Receipts, x => x.ReceiptDescription) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of ReceiptsAdvances for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ReceiptAdvance> LookUpReceiptsAdvances {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ReceiptViewModel x) => x.LookUpReceiptsAdvances,
                    getRepositoryFunc: x => x.ReceiptsAdvances);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of ReceiptsDetails for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<ReceiptDetail> LookUpReceiptsDetails {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ReceiptViewModel x) => x.LookUpReceiptsDetails,
                    getRepositoryFunc: x => x.ReceiptsDetails);
            }
        }


        /// <summary>
        /// The view model for the ReceiptReceiptsAvances detail collection.
        /// </summary>
        public CollectionViewModelBase<ReceiptAdvance, ReceiptAdvance, Tuple<Guid, Guid, Guid>, IModelDbUnitOfWork> ReceiptReceiptsAvancesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ReceiptViewModel x) => x.ReceiptReceiptsAvancesDetails,
                    getRepositoryFunc: x => x.ReceiptsAdvances,
                    foreignKeyExpression: x => x.ReceiptID,
                    navigationExpression: x => x.Receipt);
            }
        }

        /// <summary>
        /// The view model for the ReceiptReceiptsDetails detail collection.
        /// </summary>
        public CollectionViewModelBase<ReceiptDetail, ReceiptDetail, Tuple<Guid, Guid>, IModelDbUnitOfWork> ReceiptReceiptsDetailsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ReceiptViewModel x) => x.ReceiptReceiptsDetailsDetails,
                    getRepositoryFunc: x => x.ReceiptsDetails,
                    foreignKeyExpression: x => x.ReceiptID,
                    navigationExpression: x => x.Receipt);
            }
        }
    }
}
