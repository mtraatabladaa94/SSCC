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
    public partial class Manage : DevExpress.XtraEditors.XtraForm
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
        

        public Manage()
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

        public void MarkList()
        {
            try
            {
                var mark = new RuleMark();
                cmbMark.DataSource = mark.List().ToList();
                cmbMark.ValueMember = "MarkID";
                cmbMark.DisplayMember = "MarkName";
                
                //cmbMark.Properties.ValueMember = "MarkID";
                
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        public void LineList()
        {
            try
            {
                var line = new RuleLine();
                cmbLine.DataSource = line.List();
                cmbLine.ValueMember = "LineID";
                cmbLine.DisplayMember = "LineName";
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            this.MarkList();
        }

        private void Clear()
        {
            //crear objeto nuevo
            this._Product = new Product();

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

            txtCode.Focus();
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

        private void windowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            if (this.SelectButton(btNew) == e.Button as WindowsUIButton)
            {
                this.Clear();
            }

            switch(e.Button.Properties.Tag.ToString())
            {
                case btNew:
                    this.Clear();
                    break;

                case btSave:
                    this.Save();
                    break;

                case btSaveAndClose:

                    break;

                case btSaveAndNew:

                    break;

                case btEdit:

                    break;

                case btDelete:

                    break;

                case btSearch:

                    break;
                default:

                    break;
            }
        }

        private void windowsUIButtonPanelMain_Click(object sender, EventArgs e)
        {

        }
    }
}