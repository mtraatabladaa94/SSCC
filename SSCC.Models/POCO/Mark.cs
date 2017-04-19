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
    public partial class Mark // Características del objeto Marca
    {
        
        public Guid MarkID { get; set; }

        public string MarkName { get; set; }

    }

    public partial class Marca // Navegación del objeto Marca
    {

        public virtual ICollection<Product> Products { get; set; }

    }

    public partial class MarkMapping : EntityTypeConfiguration<Mark>
    {
        public MarkMapping()
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
