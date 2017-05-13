using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto Marca
    /// </summary>
    public partial class MarkEntity // Características del objeto Marca
    {
        
        public Guid MarkID { get; set; }

        public string MarkName { get; set; }

    }

    public partial class Marca // Navegación del objeto Marca
    {

        public virtual ICollection<ProductEntity> Products { get; set; }

    }

    public partial class MarkEntityMapping : EntityTypeConfiguration<MarkEntity>
    {
        public MarkEntityMapping()
        {
            ToTable("tblMarks");

            HasKey(c => c.MarkID);

            Property(c => c.MarkName)
                .HasColumnType("varchar")
                .HasMaxLength(60)
                .IsRequired();

        }
    }
}
