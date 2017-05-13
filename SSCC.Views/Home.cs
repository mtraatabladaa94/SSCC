using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

using SSCC.Views.Sale;
using SSCC.Views.Customer;
using SSCC.Views.Product;

using SSCC.Views.Utilities;

namespace SSCC.Views
{
    //Eventos de Controles
    public sealed partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Boolean FormLoad = false;
        public Boolean _LoadSale = true;

#region Cargar Formularios
        private void LoadSale()
        {
            var sale = new SaleManage();
            ShowForm.Show(sale, Dialog: true);
        }
        private void LoadProduct()
        {
            var product = new ProductManage();
            ShowForm.Show(product, Dialog: true);
        }
        private void LoadCustomer()
        {
            var customer = new CustomerManage();
            ShowForm.Show(customer, Dialog: true);
        }
        private void LoadImport()
        {
            var import = new SaleImport();
            ShowForm.Show(import, Dialog: true);
        }
#endregion

        /// <summary>
        /// Constructor que inicializa componentes.
        /// </summary>
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.LoadDate(); //Muestra la fecha y hora en pantalla.
            
            //se carga la venta si así se desea
            if (this._LoadSale)
            {
                //this.LoadSale();
            }

            //se termina de cargar el form
            this.FormLoad = true;
        }

        /// <summary>
        /// Muestra la fecha y hora en pantalla.
        /// </summary>
        private void LoadDate()
        {
            lblDate.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            this.LoadDate();
        }

        private void btProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.LoadProduct();
        }

        private void btCustomer_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.LoadCustomer();
        }

        private void btSale_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void btSaleList_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btReceipt_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btReceiptList_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btImportar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.LoadImport();
        }
    }
}