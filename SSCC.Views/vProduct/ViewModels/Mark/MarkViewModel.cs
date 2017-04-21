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
    /// Represents the single Mark object view model.
    /// </summary>
    public partial class MarkViewModel : SingleObjectViewModel<Mark, Guid, IModelDbUnitOfWork> {

        /// <summary>
        /// Creates a new instance of MarkViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static MarkViewModel Create(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new MarkViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the MarkViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the MarkViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected MarkViewModel(IUnitOfWorkFactory<IModelDbUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.Marks, x => x.MarkName) {
                }



    }
}
