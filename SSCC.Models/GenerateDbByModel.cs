using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSCC.Models
{
    public partial class GenerateDbByModel : Form
    {
        public GenerateDbByModel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Database.ModelDb())
            {
                db.Database.CreateIfNotExists();
                MessageBox.Show("Existe o se creo");
            }
        }
    }
}