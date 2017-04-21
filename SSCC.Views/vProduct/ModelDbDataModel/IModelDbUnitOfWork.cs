using DevExpress.Mvvm.DataModel;
using SSCC.Models.Database;
using SSCC.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSCC.Views.vProduct.ModelDbDataModel {

    /// <summary>
    /// IModelDbUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IModelDbUnitOfWork : IUnitOfWork {
        
        /// <summary>
        /// The Customer entities repository.
        /// </summary>
		IRepository<Customer, Guid> Customers { get; }
        
        /// <summary>
        /// The Sale entities repository.
        /// </summary>
		IRepository<Sale, Guid> Sales { get; }
        
        /// <summary>
        /// The SaleDetail entities repository.
        /// </summary>
		IRepository<SaleDetail, Tuple<Guid, Guid>> SalesDetails { get; }
        
        /// <summary>
        /// The Product entities repository.
        /// </summary>
		IRepository<Product, Guid> Products { get; }
        
        /// <summary>
        /// The Line entities repository.
        /// </summary>
		IRepository<Line, Guid> Lines { get; }
        
        /// <summary>
        /// The Mark entities repository.
        /// </summary>
		IRepository<Mark, Guid> Marks { get; }
        
        /// <summary>
        /// The Receipt entities repository.
        /// </summary>
		IRepository<Receipt, Guid> Receipts { get; }
        
        /// <summary>
        /// The ReceiptAdvance entities repository.
        /// </summary>
		IRepository<ReceiptAdvance, Tuple<Guid, Guid, Guid>> ReceiptsAdvances { get; }
        
        /// <summary>
        /// The ReceiptDetail entities repository.
        /// </summary>
		IRepository<ReceiptDetail, Tuple<Guid, Guid>> ReceiptsDetails { get; }
    }
}
