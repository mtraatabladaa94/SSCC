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

namespace SSCC.Views
{
    //Eventos de Controles
    public sealed partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
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
    }
}