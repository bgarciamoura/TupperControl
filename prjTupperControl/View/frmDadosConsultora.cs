using prjTupperControl.Controller;
using System;
using System.Collections;
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
        private controllerConsultora controller;

        public frmDadosConsultora()
        {
            InitializeComponent();
        }

        private void frmDadosConsultora_Load(object sender, EventArgs e)
        {
            controller = new controllerConsultora();
            List<Hashtable> lista;
            lista = controller.RetornaTudo();

            dgvConsultora.DataSource = null;
            for (int i = 0; i < lista.Count; i++)
            {
                dgvConsultora.Rows.Add(lista[i]["Nome_Pessoa"], lista[i]["Codigo_Consultora"], lista[i]["Celular_Pessoa"], lista[i]["Obs_Consultora"]);
            }

        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            
            frmEndereco frm = new frmEndereco();
            frm.Show();
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            controller = new controllerConsultora();
            List<Hashtable> lista;
            lista = controller.ProcurarConsultora(txtProcurar.Text);
            dgvConsultora.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                dgvConsultora.Rows.Add(lista[i]["Nome_Pessoa"], lista[i]["Codigo_Consultora"], lista[i]["Celular_Pessoa"], lista[i]["Obs_Consultora"]);
            }
        }

        
    }
}
