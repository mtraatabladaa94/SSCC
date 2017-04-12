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
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home()
        {
            InitializeComponent();
            this.ribbonStatusBar.BackColor = Color.FromArgb(141, 147, 161);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ProgressIndicator c = new ProgressIndicator();
            c.StartPosition = FormStartPosition.CenterScreen;
            c.ShowDialog();
        }
    }
}