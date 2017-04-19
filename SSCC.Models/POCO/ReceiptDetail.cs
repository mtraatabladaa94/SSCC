using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto Recibo detalle
    /// </summary>
    public class ReceiptDetail // Características del objeto Recibo Detalle
    {

        public Guid SaleID { get; set; }

        public Guid ReceiptID { get; set; }

        public decimal DetailReceiptSaleAmount { get; set; }

    }

    public partial class ReceiptDetail // Navegación del objeto Recibo Detalle
    {

        public virtual Sale Sale { get; set; }

        public virtual Receipt Receipt { get; set; }
        
    }
}
