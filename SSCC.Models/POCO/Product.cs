using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto producto
    /// </summary>
    public partial class Product //Características del objeto
    {
        public Guid ProductID { get; set; }
        
        public string ProductoCode { get; set; }
        
        public string ProductName { get; set; }
        
        public string ProductDescription { get; set; }
        
        public decimal ProductPrice { get; set; }

        public Nullable<Guid> MarkID { get; set; }

        public Nullable<Guid> LineID { get; set; }

        public Boolean ProductIsActive { get; set; }

    }

    public partial class Product //Navegación
    {

        public virtual Mark Mark { get; set; }

        public virtual Line Line { get; set; }

        public virtual ICollection<SaleDetail> SalesDetails { get; set; }

    }
}
