using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.XtraEditors;

namespace SSCC.Views.Utilities.Message
{
    internal class Msg
    {

        public static void Info(string message)
        {
            XtraMessageBox.Show(message, "Información del Sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        public static void Err(string message)
        {
            XtraMessageBox.Show(message, "Información del Sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static void Adv(string message)
        {
            XtraMessageBox.Show(message, "Información del Sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        }

    }
}
