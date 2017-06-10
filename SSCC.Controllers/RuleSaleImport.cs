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

        private Excel.Range ReadFile(string FilePath, int SheetNumber, string CellLeft, string CellFinal)
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
            range = xlWorkSheet.get_Range(CellLeft, CellFinal);

            return range;
        }

        public List<SaleImportEntity> Imports(string FilePath, int SheetNumber, string CellLeft, string CellFinal, int SaleN = 1, int SaleDate = 2, int CustomerN = 3, int ProductN = 4, int Quanty = 5, int Price = 6, int IVA = 7)
        {
            if (!this.Exist(FilePath))
            {
                throw new Exception("No se encuestra el archivo: " + FilePath);
            }

            var saleImportEntityList = new List<SaleImportEntity>();

            //conectando con excel
            var dataValues = this.ReadFile(FilePath, SheetNumber, CellLeft, CellFinal);
            
            //objeto array de pruebas
            Object[,] array = new Object[dataValues.Rows.Count, dataValues.Columns.Count];

            //objeto del listado
            var saleImportEntity = new SaleImportEntity();

            for (int row = 0; row < dataValues.Rows.Count; row++)
            {
                //objeto de base de datos
                using (var db = new Models.Database.ModelDb())
                {

                    //aplicando probador para validar que los datos sean los debidos
                    try
                    {
                        for (int column = 0; column < dataValues.Columns.Count; column++)
                        {

                            //valor obtenido de la celda de excel
                            object value = (dataValues.Cells[row, column] as Excel.Range).Value;

                            //llenando array para pruebas
                            array[row, column] = value;

                            //si es la columna nº factura
                            if (column == SaleN - 1)
                            {
                                saleImportEntity.SaleCode = value.ToString();
                            }
                            //si es la columna fecha
                            if (column == SaleDate - 1)
                            {
                                saleImportEntity.SaleDate = DateTime.Parse(value.ToString());
                            }
                            //si es la columna código cliente
                            if (column == CustomerN - 1)
                            {
                                saleImportEntity.CustomerCode = value.ToString();
                            }
                            //si es la columna código producto
                            if (column == ProductN - 1)
                            {
                                saleImportEntity.ProductCode = value.ToString();
                            }
                            //si es la columna cantidad
                            if (column == Quanty - 1)
                            {
                                saleImportEntity.ProductQuantity = decimal.Parse(value.ToString());
                            }
                            //si es la columna precio
                            if (column == Price - 1)
                            {
                                saleImportEntity.ProductPrice = decimal.Parse(value.ToString());
                            }
                            //si es la columna iva
                            if (column == IVA - 1)
                            {
                                //saleImportEntity.ProductIVA = decimal.Parse(value.ToString());
                            }
                        }

                        //calcular total
                        saleImportEntity.SaleTotal = saleImportEntity.ProductQuantity + saleImportEntity.ProductPrice + saleImportEntity.ProductIVA;

                        //agregando objeto al listado
                        saleImportEntityList.Add(saleImportEntity);
                    }
                    catch(Exception ex)
                    {
                        throw new Exception("Ha ocurrido un error al extraer los datos de excel. Descripción: " + ex.Message + ". El error ocurrio en la fila ");
                    }

                }
            }
            
            //retornando listado de datos
            return saleImportEntityList;
        }
    }
}