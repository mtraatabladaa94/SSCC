using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto Anticipos
    /// </summary>
    public partial class ReceiptAdvance // Características del objeto Anticipos
    {
        
        public Guid ProductID { get; set; }
        
        public Guid SaleID { get; set; }

        public Guid ReceiptID { get; set; }

        public decimal ProductQuantity { get; set; }

    }

    public partial class ReceiptAdvance
    {

        public virtual Product Product { get; set; }

        public virtual Sale Sale { get; set; }

        public virtual Receipt Receipt { get; set; }

    }
}
