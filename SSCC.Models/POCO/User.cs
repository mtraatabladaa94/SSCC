using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCC.Models.POCO
{
    public class User
    {
        public Guid UserID { get; set; }

        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public string UserNic { get; set; }

        public string UserPassword { get; set; }

        public Boolean UserIsActive { get; set; }
    }
}