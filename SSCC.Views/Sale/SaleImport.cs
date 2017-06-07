using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;

using SSCC.Controllers;
using SSCC.Models.POCO;
using SSCC.Models.Database;

using SSCC.Views.Utilities.Message;

using DevExpress.XtraBars.Docking2010;

namespace SSCC.Views.Sale
{
    public partial class SaleImport : DevExpress.XtraEditors.XtraForm
    {
        //variable bandera cuando termino de cargarse completamente el objeto
        private Boolean ObjLoad = false;

        private List<SaleImportEntity> SalesImports;

        //creando regla de negocio
        private RuleSaleImport RuleSaleImport;

        //constantes para botones
#region Constantes de Botones

        public const string btNew = "btNew";
        public const string btSave = "btSave";
        public const string btSaveAndClose = "btSaveAndClose";
        public const string btSaveAndNew = "btSaveAndNew";
        public const string btEdit = "btEdit";
        public const string btDelete = "btDelete";
        public const string btSearch = "btSearch";

#endregion
        

        public SaleImport()
        {
            InitializeComponent();

            //Inicializando objeto
            this.SalesImports = new List<SaleImportEntity>();

            this.RuleSaleImport = new RuleSaleImport();
        }

        private void Clear()
        {

            //crear objeto nuevo
            this.SalesImports = new List<SaleImportEntity>();

            //limpiar campos
            

            //limpiar botones
            this.SelectButton(btSave).Enabled = true;
            this.SelectButton(btSaveAndClose).Enabled = true;
            this.SelectButton(btSaveAndNew).Enabled = true;
            this.SelectButton(btEdit).Enabled = false;
            this.SelectButton(btDelete).Enabled = false;

        }

        private void List()
        {
            try
            {
                dtReg.DataSource = (from c in this.SalesImports
                                    select new
                                    {
                                        c.SaleCode,
                                        c.SaleDate,
                                        c.CustomerCode,
                                        c.CustomerName,
                                        c.ProductCode,
                                        c.ProductName,
                                        c.ProductQuantity,
                                        c.ProductPrice,
                                        c.ProductIVA
                                    }).ToList();
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }

            this.Grid();
        }

        private void Grid()
        {

            if (dtReg.Columns.Count > 0)
            {

                //Estilo de Encabezados
                dtReg.Columns[0].HeaderText = "\nNº Factura\n"; dtReg.Columns[0].Width = 120;
                dtReg.Columns[1].HeaderText = "Fecha"; dtReg.Columns[1].Width = 120;
                dtReg.Columns[2].HeaderText = "Nº Cliente"; dtReg.Columns[2].Width = 120;
                dtReg.Columns[3].HeaderText = "Nombres y Apellidos"; dtReg.Columns[3].Width = 200;
                dtReg.Columns[4].HeaderText = "Nº Producto"; dtReg.Columns[4].Width = 120;
                dtReg.Columns[5].HeaderText = "Nombre del Producto"; dtReg.Columns[5].Width = 200;
                dtReg.Columns[6].HeaderText = "Cantidad"; dtReg.Columns[6].Width = 100;
                dtReg.Columns[7].HeaderText = "Precio"; dtReg.Columns[7].Width = 100;
                dtReg.Columns[8].HeaderText = "I.V.A"; dtReg.Columns[8].Width = 100;

                //Aplicando Formato General al Texto del Encabezado
                foreach (DataGridViewColumn item in dtReg.Columns)
                {
                    item.HeaderText = item.HeaderText.ToUpper();
                    item.HeaderCell.Style.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);
                }

            }

        }

        //IMPORTANTE: Modificar código, crear una clase general o una interfaz
        private WindowsUIButton SelectButton(object name)
        {
            return windowsUIButtonPanelMain.Buttons.Where(c => c.Properties.Tag == name).FirstOrDefault() as WindowsUIButton;
        }

        private void DialogImport()
        {
            opImport.ShowDialog();
        }

        private void Validation()
        {

            if (String.IsNullOrWhiteSpace(bteImport.Text))
            {
                Msg.Err("Seleccionar archivo de Excel.");
                bteImport.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtInitialCell.Text))
            {
                Msg.Err("Para importar datos debe ingresar el rango de celdas (Celda Inicial).");
                txtInitialCell.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtInitialCell.Text))
            {
                Msg.Err("Para importar datos debe ingresar el rango de celdas (Celda Final).");
                txtFinalCell.Focus();
                return;
            }

            if (this.SalesImports.Count > 0)
            {
                Msg.Err("No hay registros, para importar");
                bteImport.Focus();
                return;
            }
        }

        private void Import()
        {
            try
            {
                this.Validation();

                
                
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void GetData()
        {
            try
            {
                RuleSaleImport.Imports(bteImport.Text, int.Parse(txtSheet.Value.ToString()), txtInitialCell.Text, txtFinalCell.Text, int.Parse(txtNFactura.Value.ToString()), int.Parse(txtFecha.Value.ToString()), int.Parse(txtCliente.Value.ToString()), int.Parse(txtProducto.Value.ToString()), int.Parse(txtCantidad.Value.ToString()), int.Parse(txtPrecio.Value.ToString()));
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void Delete()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }



        private void Manage_Load(object sender, EventArgs e)
        {
            this.List();
            
            //Cargado completamente
            this.ObjLoad = true;
        }

        private void windowsUIButtonPanelCloseButton_ButtonClick(object sender, ButtonEventArgs e)
        {
            this.Close();
        }

        private void Manage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {

                    case Keys.N: //Nuevo
                        this.Clear();
                        break;

                    case Keys.G: //Guardar
                        this.Import();
                        break;

                    case Keys.B: //Buscar
                        
                        break;

                    case Keys.Delete: // Eliminar
                        this.Delete();
                        break;
                }
            }
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            switch(e.Button.Properties.Tag.ToString())
            {
                case btNew:

                    //Nuevo
                    this.Clear();

                    break;

                case btSave:

                    //Guardar
                    this.Import();

                    break;

                case btSaveAndClose:

                    //Guardar y cerrar el form
                    this.Import();
                    this.Close();

                    break;

                case btSaveAndNew:

                    //Guardar y nuevo
                    this.Import();
                    this.Clear();

                    break;

                case btEdit:

                    break;

                case btDelete:

                    //Eliminar
                    this.Delete();
                    this.Clear();

                    break;

                case btSearch:

                    break;
            }
        }

        private void bteImport_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            this.DialogImport();
        }

        private void opAbrir_FileOk(object sender, CancelEventArgs e)
        {
            bteImport.EditValue = opImport.FileName;
            txtSheet.Focus();
        }

        private void bteImport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(bteImport.Text))
                {
                    this.DialogImport();
                }
                else
                {
                    txtInitialCell.Focus();
                }
            }
        }

        private void txtSheet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(txtInitialCell.Text))
                {
                    txtFinalCell.Focus();
                }
                else
                {
                    Msg.Err("Para importar datos debe ingresar el rango de celdas (Celda Inicial).");
                }
            }
        }

        private void txtInitialCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(txtInitialCell.Text))
                {
                    txtFinalCell.Focus();
                }
                else
                {
                    Msg.Err("Para importar datos debe ingresar el rango de celdas (Celda Inicial).");
                }
            }
        }

        private void txtFinalCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!String.IsNullOrWhiteSpace(txtInitialCell.Text))
                {
                    this.GetData();
                }
                else
                {
                    Msg.Err("Para importar datos debe ingresar el rango de celdas (Celda Final).");
                }

            }

        }

    }

}