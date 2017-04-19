﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto Recibo
    /// </summary>
    public partial class Receipt // Características del objeto Recibo
    {
        
        public Guid ReceiptID { get; set; }

        public DateTime ReceiptDate { get; set; }

        public string ReceiptDescription { get; set; }

        public decimal ReceiptAmount { get; set; }

        public Boolean ReceiptType { get; set; }

        public Boolean ReceiptIsActive { get; set; }

    }

    public partial class Receipt // Navegación del objeto Recibo
    {
        
        public virtual ICollection<ReceiptDetail> ReceiptsDetails { get; set; }

        public virtual ICollection<ReceiptAdvance> ReceiptsAvances { get; set; }

    }

    public partial class ReceiptMapping : EntityTypeConfiguration<Receipt>
    {
        public ReceiptMapping()
        {
            ToTable("tblReceipts");

            HasKey(c => c.ReceiptID);

            Property(c => c.ReceiptDescription)
                .HasColumnType("varchar")
                .HasMaxLength(null);

            Property(c => c.ReceiptAmount)
                .HasColumnType("decimal")
                .HasPrecision(10, 4);
        }
    }

}