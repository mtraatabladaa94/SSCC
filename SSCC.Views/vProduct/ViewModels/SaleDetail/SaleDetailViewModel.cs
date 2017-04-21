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
    /// Represents the single SaleDetail object view model.
    /// </summary>
    public partial class SaleDetailViewModel : SingleObjectViewModel<SaleDetail, Tuple<Guid, Guid>, IModelDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of SaleDetailViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SaleDetailViewModel Create(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new SaleDetailViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SaleDetailViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SaleDetailViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SaleDetailViewModel(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SalesDetails, x => x.DetailSaleQuantity) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Products for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Product> LookUpProducts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SaleDetailViewModel x) => x.LookUpProducts,
                    getRepositoryFunc: x => x.Products);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Sales for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Sale> LookUpSales {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (SaleDetailViewModel x) => x.LookUpSales,
                    getRepositoryFunc: x => x.Sales);
            }
        }

    }
}
