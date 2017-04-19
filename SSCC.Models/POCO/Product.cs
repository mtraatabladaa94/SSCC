using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto producto
    /// </summary>
    public partial class Product //Características del objeto
    {
        public Guid ProductID { get; set; }
        
        public string ProductCode { get; set; }
        
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

    public partial class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            ToTable("tblProducts");


            HasKey(c => c.ProductID);


            Property(c => c.ProductCode)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();


            Property(c => c.ProductName)
                .HasColumnType("varchar")
                .HasMaxLength(60)
                .IsRequired();


            Property(c => c.ProductDescription)
                .HasColumnType("varchar")
                .HasMaxLength(null);



            Property(c => c.ProductPrice)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);
        }
    }

}
