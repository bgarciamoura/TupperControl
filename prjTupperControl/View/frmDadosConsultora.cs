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
        private List<Hashtable> lista;

        public List <Hashtable> Lista
        {
            get { return lista; }
            set { lista = value; }
        }


        public frmDadosConsultora()
        {
            InitializeComponent();
        }

        private void frmDadosConsultora_Load(object sender, EventArgs e)
        {
            controller = new controllerConsultora();
            //List<Hashtable> lista;
            Lista = controller.RetornaTudo();
            CarregaGrid(lista);
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            frmEndereco frm = new frmEndereco();
            frm.Show();
        }

        private void btnCadDoc_Click(object sender, EventArgs e)
        {
            frmCadDocs frm = new frmCadDocs();
            frm.Pessoa = BuscaID(dgvConsultora.CurrentRow.Cells["ID"].Value.ToString());
            frm.ShowDialog();
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            controller = new controllerConsultora();
            //List<Hashtable> lista;
            Lista = controller.ProcurarConsultora(txtProcurar.Text);
            
            CarregaGrid(lista);
        }

        private void CarregaGrid(List<Hashtable> lista)
        {
            dgvConsultora.Rows.Clear();
            dgvConsultora.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConsultora.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            for (int i = 0; i < Lista.Count; i++)
            {
                dgvConsultora.Rows.Add(Lista[i]["ID_Pessoa"], Lista[i]["Codigo_Consultora"], Lista[i]["Nome_Pessoa"], (Lista[i]["Ativa_Consultora"].Equals(true)) ? "SIM" : "NÃO", Lista[i]["Celular_Pessoa"], Lista[i]["Obs_Consultora"]);
                if (dgvConsultora.Rows[i].Cells["ATIVA"].Value.Equals("NÃO"))
                {
                    dgvConsultora.Rows[i].Cells["ATIVA"].Style.BackColor = Color.OrangeRed;
                }
            }
        }

        private void CarregaGridEndereco(int aux)
        {
            dgvEndereco.Rows.Clear();
            dgvEndereco.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEndereco.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvEndereco.Rows.Add(Lista[aux]["Logra_Endereco"], Lista[aux]["Numero_Endereco"], Lista[aux]["Bairro_Endereco"], Lista[aux]["Cidade_Endereco"], Lista[aux]["Cep_Endereco"], Lista[aux]["Obs_Endereco"]);
        }

        private void dgvConsultora_SelectionChanged(object sender, EventArgs e)
        {
            CarregaGridEndereco(Convert.ToInt32(dgvConsultora.CurrentRow.Index));
        }

        private Hashtable BuscaID(string aux)
        {
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i]["ID_Pessoa"].ToString().Equals(aux))
                {
                    hashtable = Lista[i];
                }
            }
            return hashtable;
        }
    }
}
