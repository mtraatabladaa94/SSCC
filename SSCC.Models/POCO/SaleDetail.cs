using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto detalle de venta
    /// </summary>
    public partial class SaleDetail // Características del objeto Venta Detalle
    {

        public Guid SaleID { get; set; }
        
        public Guid ProductID { get; set; }

        public decimal DetailSaleQuantity { get; set; }

        public decimal DetailSalePrice { get; set; }

        public decimal DetailSaleSubTotal { set; get; }

        public decimal DetailSaleIVA { set; get; }

        public decimal DetailSaleTotal { set; get; }

        public Boolean DetailSaleIsActive { get; set; }

    }
    
    public partial class SaleDetail // Navegación del objeto Venta Detalle
    {
        
        public virtual Sale Sale { get; set; }

        public virtual Product Product { set; get; }

    }

    public class SaleDetailMapping : EntityTypeConfiguration<SaleDetail>
    {

    }

}