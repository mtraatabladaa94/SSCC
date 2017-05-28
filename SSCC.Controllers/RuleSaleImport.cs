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
    public struct Cell
    {
        public string Column { get; set; }
        public int Row { get; set; }
    }

    public struct Range
    {
        public void ConvertInCell()
        {

        }

        public Cell CellLeft { get; set; }
        public Cell CellFinal { get; set; }
    }

    public class RuleSaleImport
    {
        private Excel.Application xlsApp;
        private Excel.Workbook xlWorkBook;
        private Excel.Worksheet xlWorkSheet;
        private Excel.Range range;

        //jet connection

        private Boolean Exist(string FilePath)
        {
            return File.Exists(FilePath);
        }

        private Excel.Range ReadFile(string FilePath, int SheetNumber)
        {
            if (!this.Exist(FilePath))
            {
                throw new Exception("No se encuentra el archivo: " + FilePath);
            }

            var misValue = Type.Missing;

            // abrir el documento
            xlsApp = new Excel.Application();
            xlWorkBook = xlsApp.Workbooks.Open(FilePath, misValue, misValue,
                misValue, misValue, misValue, misValue, misValue, misValue,
                misValue, misValue, misValue, misValue, misValue, misValue);



            // seleccion de la hoja de calculo
            // get_item() devuelve object y numera las hojas a partir de 1
            if (xlWorkBook.Worksheets.Count > 0 && xlWorkBook.Worksheets.Count <= SheetNumber)
            {
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(SheetNumber);
            }
            else
            {
                throw new Exception("No existe la hoja '" + SheetNumber.ToString() + "' en el Libro de Excel.");
            }

            // seleccion rango activo
            range = xlWorkSheet.UsedRange;

            return range;
        }

        public List<SaleImportEntity> Imports(string FilePath, int SheetNumber, string CellLeft, string CellFinal, string SaleN = "", string SaleDate = "", string Customer = "", string ProductN = "", string Quanty = "", string Price = "", string IVA = "")
        {
            if (!this.Exist(FilePath))
            {
                throw new Exception("No se encuestra el archivo: " + FilePath);
            }

            var saleImportEntityList = new List<SaleImportEntity>();

            //conectando con excel
            var dataValues = this.ReadFile(FilePath, SheetNumber).Range[CellLeft, CellFinal];
            Object[,] array = new Object[dataValues.Rows.Count, dataValues.Columns.Count];
            for (int column = 1; column < dataValues.Columns.Count; column++)
            {
                for (int row = 1; row < dataValues.Rows.Count; row++)
                {
                    array[row, column] = (dataValues.Cells[row, column] as Excel.Range).Value2;
                }
            }
            
            //recorriendo celdas
            

            return saleImportEntityList;
        }
    }
}