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

using System.Data.OleDb;

using SSCC.Controllers;
using SSCC.Models.POCO;
using SSCC.Models.Database;

using SSCC.Views.Utilities.Message;

using DevExpress.XtraBars.Docking2010;

namespace SSCC.Views.vSale
{
    public partial class Import : DevExpress.XtraEditors.XtraForm
    {
        //variable bandera cuando termino de cargarse completamente el objeto
        private Boolean ObjLoad = false;

        //creación del objeto producto para encapsular funcionalidades
        private Product _Product;

        //bandera para saber si es nuevo o edicion
        private Boolean Exist = false;

        //creando regla de negocio
        private RuleProduct RuleProduct;

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
        

        public Import()
        {
            InitializeComponent();

            //Inicializando objeto
            this._Product = new Product();

            this.Exist = false;

            this.RuleProduct = new RuleProduct();
        }

        private void Clear()
        {
            //crear objeto nuevo
            this._Product = new Product();

            //limpiar campos
            

            //limpiar botones
            this.SelectButton(btSave).Enabled = true;
            this.SelectButton(btSaveAndClose).Enabled = true;
            this.SelectButton(btSaveAndNew).Enabled = true;
            this.SelectButton(btEdit).Enabled = false;
            this.SelectButton(btDelete).Enabled = false;

        }

        //IMPORTANTE: Modificar código, crear una clase general o una interfaz
        private WindowsUIButton SelectButton(object name)
        {
            return windowsUIButtonPanelMain.Buttons.Where(c => c.Properties.Tag == name).FirstOrDefault() as WindowsUIButton;
        }

        private void Validation()
        {

        }

        private void Save()
        {
            try
            {
                if (!this.Exist)
                {
                    
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void Manage_Load(object sender, EventArgs e)
        {

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

                    case Keys.Delete: // Eliminar
                        
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

                case btSearch:

                    break;
            }
        }

        private void bteImport_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            opFile.ShowDialog();
        }

        private void opFile_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                bteImport.Text = opFile.FileName;
                txtCellLeft.Focus();
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

    }
}