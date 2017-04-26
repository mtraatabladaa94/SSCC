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
                    this.ShowProductInControls();
                    this.Exist = true;
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

        public void Find(string Code)
        {
            try
            {
                var p = RuleProduct.Find(Code);
                if (p != null)
                {
                    this._Product = p;
                    this.ShowProductInControls();
                    this.Exist = true;
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

        private void ShowProductInControls()
        {
            txtCode.Text = this._Product.ProductCode;
            txtName.Text = this._Product.ProductName;
            txtPrice.Value = this._Product.ProductPrice;
            cmbLine.Text = this._Product.LineID != null ? this._Product.Line.LineName : "";
            cmbMark.Text = this._Product.MarkID != null ? this._Product.Mark.MarkName : "";
            txtDescription.Text = this._Product.ProductDescription;
        }

        public void MarkList()
        {
            try
            {
                var mark = new RuleMark();
                cmbMark.DataSource = mark.List();
                cmbMark.ValueMember = "MarkID";
                cmbMark.DisplayMember = "MarkName";
                cmbMark.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void MarkSelect()
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(cmbMark.Text.Trim()))
                {
                    if (cmbMark.SelectedValue == null)
                    {
                        var MarkName = cmbMark.Text;
                        this.MarkList();
                        cmbMark.Text = MarkName;
                        if (cmbMark.SelectedValue != null)
                        {
                            cmbMark.Focus();
                        }
                        else
                        {
                            if (XtraMessageBox.Show("No se encuentra esta marca ¿Desea agregarla?", "Información del Sistema", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                var mark = new RuleMark();
                                mark.Save(new Mark()
                                {
                                    MarkName = cmbMark.Text
                                });

                                this.MarkList();

                                cmbMark.Text = MarkName;

                                txtDescription.Focus();
                            }
                        }
                    }
                    else
                    {
                        txtDescription.Focus();
                    }
                }
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
                cmbLine.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void LineSelect()
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(cmbLine.Text.Trim()))
                {
                    if (cmbLine.SelectedValue == null)
                    {
                        var LineName = cmbLine.Text;
                        this.LineList();
                        cmbLine.Text = LineName;
                        if (cmbLine.SelectedValue != null)
                        {
                            cmbLine.Focus();
                        }
                        else
                        {
                            if (XtraMessageBox.Show("No se encuentra esta linea ¿Desea agregarla?", "Información del Sistema", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                var line = new RuleLine();
                                line.Save(new Line()
                                {
                                    LineName = cmbLine.Text
                                });

                                this.LineList();

                                cmbLine.Text = LineName;

                                cmbMark.Focus();
                            }
                        }
                    }
                    else
                    {
                        cmbMark.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void Clear()
        {
            //Crear objeto nuevo
            this._Product = new Product();

            //Al ser un objeto nuevo, no existe.
            //La bandera se establece en false
            this.Exist = false;

            //Limpiar campos
            txtCode.Text = "";
            txtName.Text = "";
            txtPrice.Value = 0;
            cmbMark.SelectedIndex = -1;
            cmbLine.SelectedIndex = -1;
            txtDescription.Text = "";

            //Limpiar botones
            this.SelectButton(btSave).Enabled = true;
            this.SelectButton(btSaveAndClose).Enabled = true;
            this.SelectButton(btSaveAndNew).Enabled = true;
            this.SelectButton(btEdit).Enabled = false;
            this.SelectButton(btDelete).Enabled = false;

            //Se asigna el foco al código del producto
            txtCode.Focus();
        }

        //IMPORTANTE: Modificar código, crear una clase general o una interfaz
        private WindowsUIButton SelectButton(object name)
        {
            return windowsUIButtonPanelMain.Buttons.Where(c => c.Properties.Tag == name).FirstOrDefault() as WindowsUIButton;
        }

        private void Validation()
        {

            if (String.IsNullOrWhiteSpace(txtCode.Text.Trim()))
            {
                Msg.Adv("Ingresar el Código");
                txtCode.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                Msg.Adv("Ingresar el Nombre");
                txtName.Focus();
                return;
            }

            if (txtPrice.Value <= 0)
            {
                Msg.Adv("Ingresar el Precio");
                txtPrice.Focus();
                return;
            }

        }

        private void Save()
        {
            try
            {
                this.Validation();
                if (!this.Exist)
                {
                    this._Product = RuleProduct.Save(this._Product);
                }
                else
                {
                    RuleProduct.Edit(this._Product);
                }
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
                this.Clear();
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }


        private void Manage_Load(object sender, EventArgs e)
        {

            this.MarkList();
            cmbMark.SelectedIndex = -1;

            this.LineList();
            cmbLine.SelectedIndex = -1;


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
                        this.Save();
                        break;

                    case Keys.B: //Buscar
                        
                        break;

                    case Keys.Delete: // Eliminar
                        this.Delete();
                        break;
                }
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text != this._Product.ProductCode)
            {
                this._Product.ProductCode = txtCode.Text;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != this._Product.ProductName)
            {
                this._Product.ProductName = txtName.Text;
            }
        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
            if (txtPrice.Value != this._Product.ProductPrice)
            {
                this._Product.ProductPrice = txtPrice.Value;
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
                    this.Save();

                    break;

                case btSaveAndClose:

                    //Guardar y cerrar el form
                    this.Save();
                    this.Close();

                    break;

                case btSaveAndNew:

                    //Guardar y nuevo
                    this.Save();
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

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Enter:

                        //Al presionar tecla ENTER
                        if (!String.IsNullOrWhiteSpace(txtCode.Text))
                        {
                            var p = this.RuleProduct.Find(txtCode.Text);
                            if (p != null)
                            {
                                //Ya que existe se carga en el objeto
                                this._Product = p;

                                //Se muestran los datos en los controles
                                this.ShowProductInControls();

                                //La bandera Exist se establece en true
                                this.Exist = true;
                            }

                            //El foco se pasa al campo Nombre
                            txtName.Focus();
                        }
                        else
                        {
                            Msg.Adv("Ingresar el Código");
                        }

                        break;

                    case Keys.Escape:

                        //Al presionar tecla ESCAPE


                        break;
                }
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Enter:

                        //Al presionar tecla ENTER
                        if (!String.IsNullOrWhiteSpace(txtName.Text))
                        {
                            txtPrice.Focus();
                        }
                        else
                        {
                            Msg.Adv("Ingresar el Nombre");
                        }

                        break;

                    case Keys.Escape:

                        //Al presionar tecla ESCAPE
                        txtCode.Focus();

                        break;
                }
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.Enter:

                        //Al presionar tecla ENTER
                        if (txtPrice.Value > 0)
                        {
                            cmbLine.Focus();
                        }
                        else
                        {
                            Msg.Adv("Ingresar el Precio");
                        }

                        break;

                    case Keys.Escape:

                        //Al presionar tecla ESCAPE
                        txtName.Focus();

                        break;
                }
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void cmbLine_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:

                    //Seleccionar Marca
                    this.LineSelect();

                    break;

                case Keys.Escape:

                    //Al presionar tecla ESCAPE
                    txtPrice.Focus();

                    break;
            }
        }

        private void cmbMark_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    
                    //Seleccionar Marca
                    this.MarkSelect();

                    break;

                case Keys.Escape:

                    //Al presionar tecla ESCAPE
                    cmbLine.Focus();

                    break;
            }
        }

        private void cmbLine_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.ObjLoad)
            {
                if (cmbLine.SelectedValue != null && cmbLine.SelectedIndex != -1)
                {
                    this._Product.LineID = Guid.Parse(cmbLine.SelectedValue.ToString());
                }
            }
        }

        private void cmbMark_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.ObjLoad)
            {
                if (cmbMark.SelectedValue != null && cmbMark.SelectedIndex != -1)
                {
                    this._Product.MarkID = Guid.Parse(cmbMark.SelectedValue.ToString());
                }
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

    }
}