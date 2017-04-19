using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto detalle de venta
    /// </summary>
    public partial class SaleDetail // Características del objeto Venta Detalle
    {

        [Column(Order= 0), Key, ForeignKey("Sale")]
        public Guid SaleID { get; set; }

        [Column(Order = 1), Key, ForeignKey("Product")]
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
        public SaleDetailMapping()
        {
            ToTable("tblSalesDetails");

            //Property(c => c.SaleID).HasColumnOrder(0);
            //HasKey(c => c.SaleID).HasRequired(c => c.Sale).WithMany().HasForeignKey(c => c.SaleID);;

            //Property(c => c.ProductID).HasColumnOrder(1);
            //HasKey(c => c.ProductID).HasRequired(c => c.Product).WithMany().HasForeignKey(c => c.ProductID);

            Property(c => c.DetailSaleQuantity)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);

            Property(c => c.DetailSalePrice)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);

            Property(c => c.DetailSaleSubTotal)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);

            Property(c => c.DetailSaleIVA)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);

            Property(c => c.DetailSaleTotal)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);

            Property(c => c.DetailSaleTotal)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);

        }
    }

}