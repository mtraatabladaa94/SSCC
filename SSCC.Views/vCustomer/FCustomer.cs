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

namespace SSCC.Views.vCustomer
{
    public partial class FCustomer : DevExpress.XtraEditors.XtraForm
    {
        //creación del objeto producto para encapsular funcionalidades
        private Customer _Customer;        

        //bandera para saber si es nuevo o edicion
        private Boolean Exist;

        //creando regla de negocio
        private RuleCustomer RuleCustomer;

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


        public FCustomer()
        {
            InitializeComponent();

            //Inicializando objeto
            this._Customer= new Customer();

            this.Exist = false;

            this.RuleCustomer= new RuleCustomer();
        }

        public void Find(Guid CustomerID)
        {
            try
            {
                var p = RuleCustomer.Find(CustomerID);
                if (p != null)
                {
                    this._Customer = p;
                }
                else
                {
                    Msg.Adv("El cliente no fue encontrado.");
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
            txtCodeCustomer.Text = "";
            txtNameCustomer.Text = "";
            txtLastNameCustomer.Text = "";
            radioGroup1.SelectedIndex = -1;
            txtCompanyNameCustomer.Text = "";
            txtTelefonoCustomer.Text = "";
            txtAddressCustomer.Text = "";
            //txtDescription.Text = "";

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
            return windowsUIButtonPanelMain.Buttons.Where(c => c.Properties.Tag == name).FirstOrDefault() as                    WindowsUIButton;
        }


        private void Validation()
        {
            
        }

        private void Save()
        {
            try
            {
                this.Validation();
                RuleCustomer.Save(this._Customer);
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
                RuleCustomer.Delete(this._Customer.CustomerID);
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void txtCodeCustomer_TextChanged(object sender, EventArgs e)
        {
            this._Customer.CustomerCode = txtCodeCustomer.Text;
        }

        private void txtNameCustomer_TextChanged(object sender, EventArgs e)
        {
            this._Customer.CustomerFirstName = txtNameCustomer.Text;
        }

        private void txtLastNameCustomer_TextChanged(object sender, EventArgs e)
        {
            this._Customer.CustomerLastName = txtLastNameCustomer.Text;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup edit = sender as RadioGroup;
            if (edit.SelectedIndex == 0) // si es natural
            {
                this._Customer.CustomerType = true;
                txtCompanyNameCustomer.Text = "N/A";
                txtCompanyNameCustomer.ReadOnly = true;
            }
            else // Si es juridico 
            {
                this._Customer.CustomerType = false;
                txtCompanyNameCustomer.Text = "";
                txtCompanyNameCustomer.ReadOnly = false;
            }
        }

        private void txtCompanyNameCustomer_TextChanged(object sender, EventArgs e)
        {
            this._Customer.CustomerCompanyName = txtCompanyNameCustomer.Text;
        }

        private void txtTelefonoCustomer_TextChanged(object sender, EventArgs e)
        {
            this._Customer.CustomerPhone = txtTelefonoCustomer.Text;
        }

        private void txtAddressCustomer_TextChanged(object sender, EventArgs e)
        {
            this._Customer.CustomerAddress = txtAddressCustomer.Text;
        }

        private void windowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
        {
            if (this.SelectButton(btNew) == e.Button as WindowsUIButton)
            {
                this.Clear();
            }

            switch (e.Button.Properties.Tag.ToString())
            {
                case btNew:
                    this.Clear();
                    break;

                case btSave:
                    if (Exist)
                    {
                        this.Save();
                    }
                    else
                    {

                    }
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

        private void txtCodeCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            Exist = false;
            if (e.KeyCode == Keys.Enter)
            {
                
                _Customer =  RuleCustomer.Find(txtCodeCustomer.Text);
                if (_Customer != null)
                {
                    txtCodeCustomer.Text = _Customer.CustomerCode;
                    txtNameCustomer.Text = _Customer.CustomerFirstName;
                    txtLastNameCustomer.Text = _Customer.CustomerLastName;
                    if (_Customer.CustomerType == true)
                    {
                        radioGroup1.SelectedIndex = 0;
                    }
                    else
                    {
                        radioGroup1.SelectedIndex = 1;
                    }
                    txtCompanyNameCustomer.Text = _Customer.CustomerCompanyName;
                    txtTelefonoCustomer.Text = _Customer.CustomerPhone;
                    txtAddressCustomer.Text = _Customer.CustomerAddress;
                    Exist = true;
                }
            }


        }

        
    }
}