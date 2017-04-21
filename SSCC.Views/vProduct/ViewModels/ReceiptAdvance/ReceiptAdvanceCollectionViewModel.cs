using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using SSCC.Views.vProduct.ModelDbDataModel;
using SSCC.Views.vProduct.Common;
using SSCC.Models.POCO;

namespace SSCC.Views.vProduct.ViewModels {

    /// <summary>
    /// Represents the ReceiptsAdvances collection view model.
    /// </summary>
    public partial class ReceiptAdvanceCollectionViewModel : CollectionViewModel<ReceiptAdvance, Tuple<Guid, Guid, Guid>, IModelDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ReceiptAdvanceCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ReceiptAdvanceCollectionViewModel Create(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ReceiptAdvanceCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ReceiptAdvanceCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ReceiptAdvanceCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ReceiptAdvanceCollectionViewModel(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.ReceiptsAdvances) {
        }
    }
}