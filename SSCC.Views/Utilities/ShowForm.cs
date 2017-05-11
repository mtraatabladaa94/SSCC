using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSCC.Views.Utilities
{
    class ShowForm
    {
        public static void Show(System.Windows.Forms.Form frm, System.Windows.Forms.Form mdi = null, Boolean Dialog = false)
        {
            if (mdi == null)
            {
                if (Dialog)
                {
                    frm.ShowDialog();
                }
                else
                {
                    frm.Show();
                }
            }
            else
            {
                frm.MdiParent = mdi;
                frm.Show();
                frm.BringToFront();
            }
        }
    }
}
