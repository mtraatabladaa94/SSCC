using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto venta
    /// </summary>
    public partial class Sale // Características del objeto Venta
    {

        public Guid SaleID { get; set; }

        public DateTime SaleDate { get; set; }

        public Boolean SaleType { get; set; }

        public string SaleDescription { get; set; }

        public decimal SaleSubTotal { get; set; }

        public decimal SaleIVA { get; set; }

        public decimal SaleTotal { get; set; }

        public Guid CustomerID { get; set; }

        public Boolean SaleIsActive { get; set; }

    }

    public partial class Sale // Navegación del objeto Venta
    {

        public Customer Customer { get; set; }

        public virtual ICollection<SaleDetail> SalesDetails { get; set; }

    }
}
