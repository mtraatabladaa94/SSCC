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
    /// Represents the single Product object view model.
    /// </summary>
    public partial class ProductViewModel : SingleObjectViewModel<Product, Guid, IModelDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of ProductViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static ProductViewModel Create(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new ProductViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the ProductViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ProductViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected ProductViewModel(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Products, x => x.ProductName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of SalesDetails for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<SaleDetail> LookUpSalesDetails {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProductViewModel x) => x.LookUpSalesDetails,
                    getRepositoryFunc: x => x.SalesDetails);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Lines for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Line> LookUpLines {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProductViewModel x) => x.LookUpLines,
                    getRepositoryFunc: x => x.Lines);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of Marks for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Mark> LookUpMarks {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (ProductViewModel x) => x.LookUpMarks,
                    getRepositoryFunc: x => x.Marks);
            }
        }


        /// <summary>
        /// The view model for the ProductSalesDetails detail collection.
        /// </summary>
        public CollectionViewModelBase<SaleDetail, SaleDetail, Tuple<Guid, Guid>, IModelDbUnitOfWork> ProductSalesDetailsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (ProductViewModel x) => x.ProductSalesDetailsDetails,
                    getRepositoryFunc: x => x.SalesDetails,
                    foreignKeyExpression: x => x.ProductID,
                    navigationExpression: x => x.Product);
            }
        }
    }
}
