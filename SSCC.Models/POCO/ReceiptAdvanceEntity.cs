using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Data.Entity.ModelConfiguration;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto Anticipos
    /// </summary>
    public partial class ReceiptAdvanceEntity // Características del objeto Anticipos
    {

        [Column(Order = 0), Key, ForeignKey("SaleDetail")]
        public Guid ProductID { get; set; }

        [Column(Order = 1), Key, ForeignKey("SaleDetail")]
        public Guid SaleID { get; set; }

        [Column(Order = 2), Key, ForeignKey("Receipt")]
        public Guid ReceiptID { get; set; }

        public decimal ProductQuantity { get; set; }

    }

    public partial class ReceiptAdvanceEntity
    {
        public virtual SaleDetailEntity SaleDetail { get; set; }

        public virtual ReceiptEntity Receipt { get; set; }

    }

    public partial class ReceiptAdvanceEntityMapping : EntityTypeConfiguration<ReceiptAdvanceEntity>
    {
        public ReceiptAdvanceEntityMapping()
        {
            ToTable("tblReceiptsAdvances");

            Property(c => c.ProductQuantity)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);
        }
    }

}
