using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto Linea
    /// </summary>
    public partial class Line // Características del objeto Línea
    {

        public Guid LineID { get; set; }

        public string LineName { get; set; }

    }

    public partial class Line // Navegación del objeto Línea
    {

        public virtual ICollection<Product> Products { get; set; }

    }


}
