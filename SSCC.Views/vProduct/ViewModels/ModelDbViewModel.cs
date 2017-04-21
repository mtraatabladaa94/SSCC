using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.ViewModel;
using SSCC.Views.vProduct.ModelDbDataModel;

namespace SSCC.Views.vProduct.ViewModels {
    /// <summary>
    /// Represents the root POCO view model for the ModelDb data model.
    /// </summary>
    public partial class ModelDbViewModel : DocumentsViewModel<ModelDbModuleDescription, IModelDbUnitOfWork> {

		const string TablesGroup = "Tables";

		const string ViewsGroup = "Views";
		INavigationService NavigationService { get { return this.GetService<INavigationService>(); } }
	
        /// <summary>
        /// Creates a new instance of ModelDbViewModel as a POCO view model.
        /// </summary>
        public static ModelDbViewModel Create() {
            return ViewModelSource.Create(() => new ModelDbViewModel());
        }

		
        /// <summary>
        /// Initializes a new instance of the ModelDbViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the ModelDbViewModel type without the POCO proxy factory.
        /// </summary>
        protected ModelDbViewModel()
		    : base(UnitOfWorkSource.GetUnitOfWorkFactory()) {
        }

        protected override ModelDbModuleDescription[] CreateModules() {
			return new ModelDbModuleDescription[] {
                new ModelDbModuleDescription( "Customers", "CustomerCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Customers)),
                new ModelDbModuleDescription( "Sales", "SaleCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Sales)),
                new ModelDbModuleDescription( "Sales Details", "SaleDetailCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.SalesDetails)),
                new ModelDbModuleDescription( "Products", "ProductCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Products)),
                new ModelDbModuleDescription( "Lines", "LineCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Lines)),
                new ModelDbModuleDescription( "Marks", "MarkCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Marks)),
                new ModelDbModuleDescription( "Receipts", "ReceiptCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Receipts)),
                new ModelDbModuleDescription( "Receipts Advances", "ReceiptAdvanceCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ReceiptsAdvances)),
                new ModelDbModuleDescription( "Receipts Details", "ReceiptDetailCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.ReceiptsDetails)),
			};
        }
                		protected override void OnActiveModuleChanged(ModelDbModuleDescription oldModule) {
            if(ActiveModule != null && NavigationService != null) {
                NavigationService.ClearNavigationHistory();
            }
            base.OnActiveModuleChanged(oldModule);
        }
	}

    public partial class ModelDbModuleDescription : ModuleDescription<ModelDbModuleDescription> {
        public ModelDbModuleDescription(string title, string documentType, string group, Func<ModelDbModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory) {
        }
    }
}