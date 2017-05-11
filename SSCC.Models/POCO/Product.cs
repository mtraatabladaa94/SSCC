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
    public partial class ProductEntity //Características del objeto
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

    public partial class ProductEntity //Navegación
    {

        public virtual MarkEntity Mark { get; set; }

        public virtual LineEntity Line { get; set; }

        public virtual ICollection<SaleDetailEntity> SalesDetails { get; set; }

    }

    public partial class ProductEntityMapping : EntityTypeConfiguration<ProductEntity>
    {
        public ProductEntityMapping()
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
