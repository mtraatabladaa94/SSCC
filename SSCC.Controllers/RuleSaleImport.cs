using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data.OleDb;

using SSCC.Models.POCO;

using Excel = Microsoft.Office.Interop.Excel;

namespace SSCC.Controllers
{
    public class RuleSaleImport
    {
        public List<SaleImportEntity> Imports()
        {
            var cnn = new OleDbConnection();
            

            return null;
        }
    }
}