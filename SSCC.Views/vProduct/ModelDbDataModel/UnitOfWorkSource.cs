using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using SSCC.Models.Database;
using System;
using System.Collections;
using System.Linq;

namespace SSCC.Views.vProduct.ModelDbDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IModelDbUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IModelDbUnitOfWork>(() => new ModelDbUnitOfWork(() => new ModelDb()));
        }
    }
}