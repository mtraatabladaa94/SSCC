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
    /// Objeto Recibo detalle
    /// </summary>
    public partial class ReceiptDetailEntity // Características del objeto Recibo Detalle
    {

        [Column(Order = 0), Key, ForeignKey("Sale")]
        public Guid SaleID { get; set; }

        [Column(Order = 1), Key, ForeignKey("Receipt")]
        public Guid ReceiptID { get; set; }

        public decimal ReceiptDetailAmount { get; set; }

    }

    public partial class ReceiptDetailEntity // Navegación del objeto Recibo Detalle
    {

        public virtual SaleEntity Sale { get; set; }

        public virtual ReceiptEntity Receipt { get; set; }
        
    }

    public partial class ReceiptDetailEntityMapping : EntityTypeConfiguration<ReceiptDetailEntity>
    {
        public ReceiptDetailEntityMapping()
        {
            ToTable("tblReceiptsDetails");

            Property(c => c.ReceiptDetailAmount)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);
        }
    }
}
