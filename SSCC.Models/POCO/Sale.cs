using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

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

    public class SaleMapping : EntityTypeConfiguration<Sale>
    {
        public SaleMapping()
        {
            ToTable("tblSales");

            HasKey(c => c.SaleID);

            Property(c => c.SaleDescription)
                .HasColumnType("varchar")
                .HasMaxLength(10);

            Property(c => c.SaleSubTotal)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);

            Property(c => c.SaleIVA)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);

            Property(c => c.SaleTotal)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);


        }
    }
    
}