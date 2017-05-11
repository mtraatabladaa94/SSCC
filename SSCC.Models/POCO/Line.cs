using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto Linea
    /// </summary>
    public partial class LineEntity // Características del objeto Línea
    {

        public Guid LineID { get; set; }

        public string LineName { get; set; }

    }

    public partial class LineEntity // Navegación del objeto Línea
    {

        public virtual ICollection<ProductEntity> Products { get; set; }

    }

    public partial class LineMappingEntity : EntityTypeConfiguration<LineEntity>
    {
        public LineMappingEntity()
        {
            ToTable("tblLines");

            HasKey(c => c.LineID);

            Property(c => c.LineName)
                .HasColumnType("varchar")
                .HasMaxLength(60)
                .IsRequired();

        }
    }
}
