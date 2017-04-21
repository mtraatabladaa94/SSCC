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
    /// Represents the single Line object view model.
    /// </summary>
    public partial class LineViewModel : SingleObjectViewModel<Line, Guid, IModelDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of LineViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static LineViewModel Create(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new LineViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the LineViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the LineViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected LineViewModel(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Lines, x => x.LineName) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of Products for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<Product> LookUpProducts {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (LineViewModel x) => x.LookUpProducts,
                    getRepositoryFunc: x => x.Products);
            }
        }


        /// <summary>
        /// The view model for the LineProducts detail collection.
        /// </summary>
        public CollectionViewModelBase<Product, Product, Guid, IModelDbUnitOfWork> LineProductsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (LineViewModel x) => x.LineProductsDetails,
                    getRepositoryFunc: x => x.Products,
                    foreignKeyExpression: x => x.LineID,
                    navigationExpression: x => x.Line);
            }
        }
    }
}
