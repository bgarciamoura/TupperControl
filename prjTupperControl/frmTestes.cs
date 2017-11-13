using prjTupperControl.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
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
            else
            {
                MessageBox.Show("Registro não incluso, verifique se ele já existe antes de tentar inclui-lo!", "Erro na inserção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atributos = new ArrayList();
            atributos.Add(txtNome.Text);
            atributos.Add(txtSigla.Text);
            controller = new controllerUnidadeMedida(atributos);
            if (MessageBox.Show("Deseja excluir a unidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (controller.RemoverUnidade())
                {
                    MessageBox.Show("Unidade: " + atributos[0] + " removida dos registros, obrigado!", "Remoção completa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro não removido, verifique se ele existe antes de tentar remove-lo!", "Erro na remoção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<String[]> list = new List<String[]>();
            controller = new controllerUnidadeMedida();
            list = controller.PesquisaTudo();
            for (int i = 0; i < list.Count; i++)
            {
                for (int x = 0; x < list.Count; x++)
                {
                    MessageBox.Show(list[i][x].ToString());
                }
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controller = new controllerUnidadeMedida();
            List<String> item = controller.PesquisaUm(txtNome.Text);
            if (item == null)
            {
                MessageBox.Show("A Unidade informada não existe. \nVerifique o nome e tente novamente",
                                "Este item não existe",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show(item[1] + " " + item[0]);
                txtSigla.Text = item[1];
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<String[]> list = new List<String[]>();
            controller = new controllerUnidadeMedida();
            list = controller.PesquisaTudoIncompleto(txtNome.Text);
            for (int i = 0; i < list.Count; i++)
            {
                for (int x = 0; x < list.Count; x++)
                {
                    MessageBox.Show(list[i][x].ToString());
                    if (list.Count == 1)
                    {
                        txtNome.Text = list[i][x].ToString();
                        txtSigla.Text = list[i][x + 1].ToString();
                    }
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            controller = new controllerUnidadeMedida();
            if (controller.Atualizar(txtNome.Text, txtSigla.Text))
            {
                MessageBox.Show("Registro atualizado com sucesso!", 
                                "Atualização de registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registro não atualizado, verifique se o registro existe e tente novamente",
                                "Atualização de registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            
        }
    }
}
