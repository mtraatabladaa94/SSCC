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

namespace SSCC.Views.vProduct
{
    public partial class List : DevExpress.XtraEditors.XtraForm
    {
        //creación del objeto producto para encapsular funcionalidades
        private Product _Product;        

        //bandera para saber si es nuevo o edicion
        private Boolean Exist;

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


        public List()
        {
            InitializeComponent();

            //Inicializando objeto
            this._Product = new Product();

            this.Exist = false;

            this.RuleProduct = new RuleProduct();
        }

        public void Find(Guid ProductID)
        {
            try
            {
                var p = RuleProduct.Find(ProductID);
                if (p != null)
                {
                    this._Product = p;
                }
                else
                {
                    Msg.Adv("Producto no encontrado.");
                }
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            
        }

        private void Clear()
        {
            //limpiar campos
            txtCode.Text = "";
            txtName.Text = "";
            txtPrice.Value = 0;
            cmbMark.Text = "";
            cmbLine.Text = "";
            txtDescription.Text = "";

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
                this.Validation();
                RuleProduct.Save(this._Product);
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
                RuleProduct.Delete(this._Product.ProductID);
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            this._Product.ProductCode = txtCode.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            this._Product.ProductName = txtName.Text;
        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
            this._Product.ProductPrice = txtPrice.Value;
        }

        private void cmbMark_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}