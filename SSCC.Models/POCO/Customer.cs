using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCC.Models.POCO
{
    /// <summary>
    /// Objeto cliente
    /// </summary>
    public partial class Customer //Características de la entidad cliente
    {

        public Guid CustomerID { get; set; }

        public string CustomerCode { get; set; }

        public string CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string CustomerCompanyName { get; set; }

        public Boolean CustomerType { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerAddress { get; set; }

        public Boolean CustomerIsActive { get; set; }

    }

    public partial class Customer //Variables de navegación
    {

        

    }
}
