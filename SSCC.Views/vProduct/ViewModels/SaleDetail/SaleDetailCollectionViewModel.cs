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
    /// Represents the SalesDetails collection view model.
    /// </summary>
    public partial class SaleDetailCollectionViewModel : CollectionViewModel<SaleDetail, Tuple<Guid, Guid>, IModelDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SaleDetailCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SaleDetailCollectionViewModel Create(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SaleDetailCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SaleDetailCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SaleDetailCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SaleDetailCollectionViewModel(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SalesDetails) {
        }
    }
}