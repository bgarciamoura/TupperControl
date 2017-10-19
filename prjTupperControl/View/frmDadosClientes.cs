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
    public partial class frmDadosClientes : frmLayoutFit
    {
        public frmDadosClientes()
        {
            InitializeComponent();
        }

        private void btnPecas_Click(object sender, EventArgs e)
        {
            frmPecasCliente frm = new frmPecasCliente();
            frm.Show();
        }

        private void btnCadPecas_Click(object sender, EventArgs e)
        {
            frmCadPecasCliente frm = new frmCadPecasCliente();
            frm.Show();
        }
    }
}
