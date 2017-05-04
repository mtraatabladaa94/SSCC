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


        #region Variables Privadas

        //creación del objeto producto para encapsular funcionalidades
        private Product _Product;

        //bandera para saber si es nuevo o edicion
        private Boolean Exist;

        //creando regla de negocio
        private RuleProduct RuleProduct;

        //bandera para saber si ya cargo el form
        private Boolean FormLoad = false;

        #endregion


        #region Constantes de Botones

        public const string btNew = "btNew";
        public const string btSave = "btSave";
        public const string btSaveAndClose = "btSaveAndClose";
        public const string btSaveAndNew = "btSaveAndNew";
        public const string btEdit = "btEdit";
        public const string btDelete = "btDelete";
        public const string btSearch = "btSearch";

        #endregion


        #region Constructores

        public Manage()
        {
            InitializeComponent();

            //Inicializando objeto
            this._Product = new Product();

            this.Exist = false;

            this.RuleProduct = new RuleProduct();

            this.LineList();

            this.MarkList();

        }

        #endregion


        #region Métodos Privados

        private void ShowDataInControls()
        {

            txtCode.Text = this._Product.ProductCode;

            txtName.Text = this._Product.ProductName;

            txtPrice.Value = this._Product.ProductPrice;

            cmbMark.Text = this._Product.MarkID != null ? this._Product.Mark.MarkName : "";

            cmbLine.Text = this._Product.LineID != null ? this._Product.Line.LineName : "";

            txtDescription.Text = this._Product.ProductDescription;

        }

        private void MarkList()
        {
            try
            {
                var mark = new RuleMark();
                cmbMark.DataSource = mark.List().ToList();
                cmbMark.ValueMember = "MarkID";
                cmbMark.DisplayMember = "MarkName";
                cmbMark.SelectedIndex = -1;

                //cmbMark.Properties.ValueMember = "MarkID";

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

                if (!String.IsNullOrWhiteSpace(cmbMark.Text))
                {

                    if (cmbMark.SelectedValue != null && cmbMark.SelectedIndex > -1)
                    {

                        txtDescription.Focus();

                    }
                    else
                    {

                        var markName = cmbMark.Text.Trim();
                        this.MarkList();
                        cmbMark.Text = markName;

                        if (cmbMark.SelectedValue != null && cmbMark.SelectedIndex > -1)
                        {

                            txtDescription.Focus();

                        }
                        else
                        {

                            if (XtraMessageBox.Show("No se encuentra esta marca ¿Desea crearla?", "Pregunta de seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                            {

                                var mark = new RuleMark();
                                mark.Save(new Mark()
                                {
                                    MarkID = Guid.NewGuid(),
                                    MarkName = markName
                                });

                                this.MarkList();

                                cmbMark.Text = markName;

                                txtDescription.Focus();

                            }

                        }

                    }

                }
                else
                {

                    cmbMark.SelectedIndex = -1;
                    txtDescription.Focus();
                }

            }
            catch (Exception ex)
            {

                Msg.Err(ex.Message);

            }

        }

        private void LineList()
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

                if (!String.IsNullOrWhiteSpace(cmbLine.Text))
                {

                    if (cmbLine.SelectedValue != null && cmbLine.SelectedIndex > -1)
                    {

                        cmbMark.Focus();

                    }
                    else
                    {

                        var lineName = cmbLine.Text.Trim();
                        this.LineList();
                        cmbLine.Text = lineName;

                        if (cmbLine.SelectedValue != null && cmbLine.SelectedIndex > -1)
                        {

                            cmbMark.Focus();

                        }
                        else
                        {

                            if (XtraMessageBox.Show("No se encuentra esta Linea ¿Desea crearla?", "Pregunta de seguridad", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                            {

                                var line = new RuleLine();
                                line.Save(new Line()
                                {
                                    LineID = Guid.NewGuid(),
                                    LineName = lineName
                                });

                                this.LineList();

                                cmbLine.Text = lineName;

                                cmbMark.Focus();

                            }

                        }

                    }

                }
                else
                {
                    cmbLine.SelectedIndex = -1;
                    cmbMark.Focus();

                }

            }
            catch (Exception ex)
            {

                Msg.Err(ex.Message);

            }

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

        private void Find(string ProductCode)
        {
            try
            {
                var p = RuleProduct.Find(ProductCode);
                if (p != null)
                {
                    this._Product = p;
                    this.ShowDataInControls();
                }
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        #endregion


        #region Métodos públicos

        public void Find(Guid ProductID)
        {
            try
            {
                var p = RuleProduct.Find(ProductID);
                if (p != null)
                {
                    this._Product = p;
                    this.ShowDataInControls();
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

        #endregion


        #region Operaciones con el modelo

        private Boolean Validation()
        {
            if (String.IsNullOrWhiteSpace(_Product.ProductCode))
            {
                Msg.Err("Ingresar código");

                txtCode.Focus();

                return false;
            }

            if (String.IsNullOrWhiteSpace(_Product.ProductName))
            {
                Msg.Err("Ingresar nombre");

                txtName.Focus();

                return false;
            }

            if (_Product.ProductPrice <= 0)
            {
                Msg.Err("Ingresar precio mayor que 0");

                txtPrice.Focus();

                return false;
            }

            return true;
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

        #endregion


        #region Manejo de Eventos

        private void Manage_Load(object sender, EventArgs e)
        {


            //cargado
            this.FormLoad = true;
        }

        //IMPORTANTE: Modificar código, crear una clase general o una interfaz
        private WindowsUIButton SelectButton(object name)
        {
            return windowsUIButtonPanelMain.Buttons.Where(c => c.Properties.Tag == name).FirstOrDefault() as WindowsUIButton;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (this._Product.ProductCode != txtCode.Text)
            {
                this._Product.ProductCode = txtCode.Text;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (this._Product.ProductName != txtName.Text)
            {
                this._Product.ProductName = txtName.Text;
            }
        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
            if (this._Product.ProductPrice != txtPrice.Value)
            {
                this._Product.ProductPrice = txtPrice.Value;
            }
        }

        private void cmbLine_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.FormLoad)
            {
                if (cmbLine.SelectedValue != null && cmbLine.SelectedIndex > -1)
                {
                    if (this._Product.LineID != Guid.Parse(cmbLine.SelectedValue.ToString()))
                    {
                        this._Product.LineID = Guid.Parse(cmbLine.SelectedValue.ToString());
                    }
                }
                else
                {
                    this._Product.LineID = null;
                }
            }
        }

        private void cmbMark_SelectedValueChanged(object sender, EventArgs e)
        {

            if (this.FormLoad)
            {

                if (cmbMark.SelectedValue != null && cmbMark.SelectedIndex > -1)
                {

                    if (this._Product.MarkID != Guid.Parse(cmbMark.SelectedValue.ToString()))
                    {

                        this._Product.MarkID = Guid.Parse(cmbMark.SelectedValue.ToString());

                    }

                }
                else
                {

                    this._Product.MarkID = null;

                }

            }

        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            switch (e.Button.Properties.Tag.ToString())
            {

                case btNew:
                    this.Clear();
                    break;

                case btSave:
                    this.Save();
                    break;

                case btSaveAndClose:
                    this.Save();
                    this.Close();
                    break;

                case btSaveAndNew:
                    this.Save();
                    this.Clear();
                    break;

                case btDelete:
                    this.Delete();
                    break;

                case btSearch:

                    break;
            }

        }

        private void windowsUIButtonPanelMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCode.Text.Trim() != "")
                {
                    this.Find(txtCode.Text);
                    txtName.Focus();
                }
                else
                {
                    Msg.Err("Ingresar código");
                }
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtName.Text.Trim() != "")
                {
                    txtPrice.Focus();
                }
                else
                {
                    Msg.Err("Ingrsear nombre");
                }
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPrice.Value > 0)
                {
                    cmbLine.Focus();
                }
                else
                {
                    Msg.Err("Ingresar precio");
                }
            }
        }

        private void cmbLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.LineSelect();
            }
        }

        private void cmbMark_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.MarkSelect();
            }
        }

        private void Manage_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control)
            {
                switch (e.KeyData)
                {
                    case Keys.N:
                        this.Clear();
                        break;

                    case Keys.G:
                        this.Save();
                        break;

                    case Keys.Delete:
                        this.Delete();
                        break;
                }
            }
        }

        #endregion

    }
}