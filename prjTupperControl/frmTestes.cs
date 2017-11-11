using prjTupperControl.Controller;
using System;
using System.Collections;
using System.Windows.Forms;

namespace prjTupperControl
{
    public partial class frmTestes : Form
    {
        private controllerUnidadeMedida controller;
        private ArrayList atributos;        

        public frmTestes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atributos = new ArrayList();
            atributos.Add(txtNome.Text);
            atributos.Add(txtSigla.Text);

            controller = new controllerUnidadeMedida(atributos);
            if (controller.InserirUnidade())
            {
                MessageBox.Show("Unidade: " + atributos[0] + " adicionada aos registros, obrigado!", "Inserção completa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
