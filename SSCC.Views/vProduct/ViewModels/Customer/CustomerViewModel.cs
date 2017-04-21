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
    /// Represents the single Customer object view model.
    /// </summary>
    public partial class CustomerViewModel : SingleObjectViewModel<Customer, Guid, IModelDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of CustomerViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static CustomerViewModel Create(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new CustomerViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the CustomerViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the CustomerViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected CustomerViewModel(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Customers, x => x.CustomerLastName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Sales for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Sale> LookUpSales {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (CustomerViewModel x) => x.LookUpSales,
                    getRepositoryFunc: x => x.Sales);
            }
        }


        /// <summary>
        /// The view model for the CustomerSales detail collection.
        /// </summary>
        public CollectionViewModelBase<Sale, Sale, Guid, IModelDbUnitOfWork> CustomerSalesDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (CustomerViewModel x) => x.CustomerSalesDetails,
                    getRepositoryFunc: x => x.Sales,
                    foreignKeyExpression: x => x.CustomerID,
                    navigationExpression: x => x.Customer);
            }
        }
    }
}
