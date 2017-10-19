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
    public partial class frmDadosConsultora : frmLayoutFit
    {
        public frmDadosConsultora()
        {
            InitializeComponent();
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            frmEndereco frm = new frmEndereco();
            frm.Show();
        }
    }
}
