﻿using System;
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
    public partial class SaleManage : DevExpress.XtraEditors.XtraForm
    {
        //variable bandera cuando termino de cargarse completamente el objeto
        private Boolean ObjLoad = false;

        //creación del objeto producto para encapsular funcionalidades
        private ProductEntity _Product;

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
        

        public SaleManage()
        {
            InitializeComponent();

            //Inicializando objeto
            this._Product = new ProductEntity();

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
            txtDate.Text = this._Product.ProductName;
            cmbCliente.Text = this._Product.LineID != null ? this._Product.Line.LineName : "";
            txtDescription.Text = this._Product.ProductDescription;
        }

        
        public void LineList()
        {
            try
            {
                var line = new RuleLine();
                cmbCliente.DataSource = line.List();
                cmbCliente.ValueMember = "LineID";
                cmbCliente.DisplayMember = "LineName";
                cmbCliente.SelectedIndex = -1;
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
                if (!String.IsNullOrWhiteSpace(cmbCliente.Text.Trim()))
                {
                    if (cmbCliente.SelectedValue == null)
                    {
                        var LineName = cmbCliente.Text;
                        this.LineList();
                        cmbCliente.Text = LineName;
                        if (cmbCliente.SelectedValue != null)
                        {
                            cmbCliente.Focus();
                        }
                        else
                        {
                            if (XtraMessageBox.Show("No se encuentra esta linea ¿Desea agregarla?", "Información del Sistema", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                            {
                                var line = new RuleLine();
                                line.Save(new LineEntity()
                                {
                                    LineName = cmbCliente.Text
                                });

                                this.LineList();

                                cmbCliente.Text = LineName;

                                //cmbMark.Focus();
                            }
                        }
                    }
                    else
                    {
                        //cmbMark.Focus();
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
            //crear objeto nuevo
            this._Product = new ProductEntity();

            //limpiar campos
            txtCode.Text = "";
            txtDate.Text = "";
            cmbCliente.SelectedIndex = -1;
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

            if (String.IsNullOrWhiteSpace(txtCode.Text.Trim()))
            {
                Msg.Adv("Ingresar el Código");
                txtCode.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtDate.Text.Trim()))
            {
                Msg.Adv("Ingresar el Nombre");
                txtCode.Focus();
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

            this.LineList();
            cmbCliente.SelectedIndex = -1;


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
            if (txtDate.Text != this._Product.ProductName)
            {
                this._Product.ProductName = txtDate.Text;
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
                                txtDate.Text = p.ProductName;
                                cmbCliente.Text = p.LineID != null ? p.Line.LineName : "";
                                txtDescription.Text = p.ProductDescription;
                            }
                            txtDate.Focus();
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
                        if (!String.IsNullOrWhiteSpace(txtDate.Text))
                        {
                            //txtPrice.Focus();
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
                    //txtPrice.Focus();

                    break;
            }
        }


        private void cmbLine_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.ObjLoad)
            {
                if (cmbCliente.SelectedValue != null && cmbCliente.SelectedIndex != -1)
                {
                    this._Product.LineID = Guid.Parse(cmbCliente.SelectedValue.ToString());
                }
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

    }
}