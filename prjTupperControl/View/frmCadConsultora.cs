using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTupperControl.View
{
    public partial class frmCadConsultora : frmLayoutFit
    {
        public frmCadConsultora()
        {
            InitializeComponent();
        }

        private void btnCadDoc_Click(object sender, EventArgs e)
        {
            frmCadDocs frm = new frmCadDocs();
            frm.ShowDialog();
        }
    }
}
