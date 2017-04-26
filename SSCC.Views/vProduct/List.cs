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
            this.RuleProduct = new RuleProduct();
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

        private void UpdateData()
        {
            try
            {
                dtRegistro.DataSource = (from c in RuleProduct.List(txtCode.Text.Trim(), txtName.Text.Trim(), txtPrice.Value, cmbMark.Text.Trim(), cmbLine.Text.Trim(), tsState.IsOn)
                                        select new {
                                            c.ProductID,
                                            c.ProductCode,
                                            c.ProductName,
                                            c.ProductPrice,
                                            ProductMark = c.MarkID != null ? c.Mark.MarkName : "",
                                            ProductLine = c.LineID != null ? c.Line.LineName : "",
                                            c.ProductDescription
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
            if (dtRegistro.Columns.Count > 0)
            {
                //Ocultando ID
                dtRegistro.Columns[0].Visible = false;

                //Estilo de Encabezados
                dtRegistro.Columns[1].HeaderText = "\nCódigo\n"; dtRegistro.Columns[1].Width = 120;
                dtRegistro.Columns[2].HeaderText = "Nombre"; dtRegistro.Columns[2].Width = 200;
                dtRegistro.Columns[3].HeaderText = "Precio"; dtRegistro.Columns[3].Width = 150;
                dtRegistro.Columns[4].HeaderText = "Marca"; dtRegistro.Columns[4].Width = 250;
                dtRegistro.Columns[5].HeaderText = "Linea"; dtRegistro.Columns[5].Width = 250;
                dtRegistro.Columns[6].HeaderText = "Descripción"; dtRegistro.Columns[6].Width = 500;

                //Aplicando Formato General al Texto del Encabezado
                foreach (DataGridViewColumn item in dtRegistro.Columns)
                {
                    item.HeaderText = item.HeaderText.ToUpper();
                    item.HeaderCell.Style.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);
                }
            }
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            this.MarkList();

            this.LineList();

            this.UpdateData();
        }

        private void Clear()
        {
            
        }

        //IMPORTANTE: Modificar código, crear una clase general o una interfaz
        private WindowsUIButton SelectButton(object name)
        {
            return windowsUIButtonPanelMain.Buttons.Where(c => c.Properties.Tag == name).FirstOrDefault() as WindowsUIButton;
        }

        private void Delete(Guid ProductID)
        {
            try
            {
                RuleProduct.Delete(ProductID);
            }
            catch (Exception ex)
            {
                Msg.Err(ex.Message);
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.UpdateData();
            }
        }

        private void tsState_Toggled(object sender, EventArgs e)
        {
            this.UpdateData();
        }
    }
}