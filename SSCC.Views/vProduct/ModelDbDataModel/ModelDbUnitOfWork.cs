using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.EF6;
using SSCC.Models.Database;
using SSCC.Models.POCO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSCC.Views.vProduct.ModelDbDataModel {

    /// <summary>
    /// A ModelDbUnitOfWork instance that represents the run-time implementation of the IModelDbUnitOfWork interface.
    /// </summary>
    public class ModelDbUnitOfWork : DbUnitOfWork<ModelDb>, IModelDbUnitOfWork {

        public ModelDbUnitOfWork(Func<ModelDb> contextFactory)
            : base(contextFactory) {
        }

        IRepository<Customer, Guid> IModelDbUnitOfWork.Customers {
            get { return GetRepository(x => x.Set<Customer>(), (Customer x) => x.CustomerID); }
        }

        IRepository<Sale, Guid> IModelDbUnitOfWork.Sales {
            get { return GetRepository(x => x.Set<Sale>(), (Sale x) => x.SaleID); }
        }

        IRepository<SaleDetail, Tuple<Guid, Guid>> IModelDbUnitOfWork.SalesDetails {
            get { return GetRepository(x => x.Set<SaleDetail>(), (SaleDetail x) => Tuple.Create(x.SaleID, x.ProductID)); }
        }

        IRepository<Product, Guid> IModelDbUnitOfWork.Products {
            get { return GetRepository(x => x.Set<Product>(), (Product x) => x.ProductID); }
        }

        IRepository<Line, Guid> IModelDbUnitOfWork.Lines {
            get { return GetRepository(x => x.Set<Line>(), (Line x) => x.LineID); }
        }

        IRepository<Mark, Guid> IModelDbUnitOfWork.Marks {
            get { return GetRepository(x => x.Set<Mark>(), (Mark x) => x.MarkID); }
        }

        IRepository<Receipt, Guid> IModelDbUnitOfWork.Receipts {
            get { return GetRepository(x => x.Set<Receipt>(), (Receipt x) => x.ReceiptID); }
        }

        IRepository<ReceiptAdvance, Tuple<Guid, Guid, Guid>> IModelDbUnitOfWork.ReceiptsAdvances {
            get { return GetRepository(x => x.Set<ReceiptAdvance>(), (ReceiptAdvance x) => Tuple.Create(x.ProductID, x.SaleID, x.ReceiptID)); }
        }

        IRepository<ReceiptDetail, Tuple<Guid, Guid>> IModelDbUnitOfWork.ReceiptsDetails {
            get { return GetRepository(x => x.Set<ReceiptDetail>(), (ReceiptDetail x) => Tuple.Create(x.SaleID, x.ReceiptID)); }
        }
    }
}
