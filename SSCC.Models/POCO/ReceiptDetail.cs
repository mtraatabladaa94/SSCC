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
    public partial class ReceiptDetail // Características del objeto Recibo Detalle
    {

        [Column(Order = 0), Key, ForeignKey("Sale")]
        public Guid SaleID { get; set; }

        [Column(Order = 1), Key, ForeignKey("Receipt")]
        public Guid ReceiptID { get; set; }

        public decimal ReceiptDetailAmount { get; set; }

    }

    public partial class ReceiptDetail // Navegación del objeto Recibo Detalle
    {

        public virtual Sale Sale { get; set; }

        public virtual Receipt Receipt { get; set; }
        
    }

    public partial class ReceiptDetailMapping : EntityTypeConfiguration<ReceiptDetail>
    {
        public ReceiptDetailMapping()
        {
            ToTable("tblReceiptsDetails");

            Property(c => c.ReceiptDetailAmount)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);
        }
    }
}
