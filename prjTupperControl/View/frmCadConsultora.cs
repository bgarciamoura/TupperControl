using prjTupperControl.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace prjTupperControl.View
{
    public partial class frmCadConsultora : frmLayoutFit
    {
        public frmCadConsultora()
        {
            InitializeComponent();
            cmbSexo.SelectedIndex = 0;
        }

        private void btnCadDoc_Click(object sender, EventArgs e)
        {
            frmCadDocs frm = new frmCadDocs();
            frm.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (txtNome.Text == "")
            {
                MessageBox.Show("O nome é de preenchimento Obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                //DADOS DO ENDEREÇO
                Hashtable dadosEndereco = new Hashtable();
                dadosEndereco.Add("CIDADE", txtCidade.Text);
                dadosEndereco.Add("BAIRRO", txtBairro.Text);
                dadosEndereco.Add("LOGRADOURO", txtLogradouro.Text);
                dadosEndereco.Add("NUMERO", ConvertToInt(txtNumeroCasa.Text));
                dadosEndereco.Add("CEP", ConvertToInt(txtCep.Text));
                dadosEndereco.Add("OBS", rtxtObsEndereco.Text);

                //DADOS DA PESSOA
                Hashtable dadosPessoa = new Hashtable();
                dadosPessoa.Add("NOME", txtNome.Text);
                dadosPessoa.Add("IDADE", ConvertToInt(txtIdade.Text));
                dadosPessoa.Add("NASCIMENTO", dtpNascimento.Value.ToShortDateString());
                dadosPessoa.Add("TELEFONE", txtTelefone.Text);
                dadosPessoa.Add("CELULAR", txtCelular.Text);
                dadosPessoa.Add("SEXO", (cmbSexo.SelectedItem.ToString().Equals("Feminino  (F)")) ? "F" : "M");

                //MessageBox.Show((cmbSexo.SelectedItem.ToString().Equals("Feminino  (F)")) ? "F" : "M");

                //DADOS CONSULTOR(A)
                Hashtable dadosConsultor = new Hashtable();
                dadosConsultor.Add("CODIGO", ConvertToInt(txtCodigoConsultora.Text));

                dadosConsultor.Add("DATACAD", dtpDataCadastro.Value.ToShortDateString());
                dadosConsultor.Add("CADOK", (chkIsOk.Checked) ? 1 : 0);
                dadosConsultor.Add("OBS", rtxtObs.Text);
                //MessageBox.Show(Convert.ToString((chkIsOk.Checked) ? 1 : 0));

                List<Hashtable> dados = new List<Hashtable>();
                dados.Add(dadosEndereco);
                dados.Add(dadosPessoa);
                dados.Add(dadosConsultor);
                controllerConsultora controller = new controllerConsultora();
                if (CompletarEndereco(grbEndereco) == 1)
                {
                    MessageBox.Show("Caso você vá cadastrar o endereço, todos os dados são obrigatórios!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show(controller.Inserir(dados));
                }
            }
           
        }

        private bool EhNumerico(string control)
        {
            if (int.TryParse(control, out int x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int? ConvertToInt(string val)
        {
            if (EhNumerico(val))
            {
                return Convert.ToInt32(val);
            }
            else
            {
                return null;
            }
        }

        private int CompletarEndereco(GroupBox groupBox)
        {
            int QTD_CONTROLES = 0;
            int QTD_PREENCHIDO = 0;

            foreach (Control item in groupBox.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {
                    QTD_CONTROLES++;
                }
                if (item.GetType().Equals(typeof(TextBox)) && !item.Text.Equals(""))
                {
                    QTD_PREENCHIDO++;
                }
            }
            if (QTD_CONTROLES == QTD_PREENCHIDO || QTD_PREENCHIDO == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }

        private void LimpaCampos(Control control)
        {
            foreach (Control crtl in control.Controls)
            {
                if (crtl.GetType().Equals(typeof(GroupBox)))
                {
                    LimpaCampos(crtl);
                }
                if (crtl.GetType().Equals(typeof(TextBox)))
                {
                    (crtl as TextBox).Text = "";
                }
                if (crtl.GetType().Equals(typeof(ComboBox)))
                {
                    (crtl as ComboBox).SelectedIndex = 0;
                }
                if (crtl.GetType().Equals(typeof(DateTimePicker)))
                {
                    (crtl as DateTimePicker).Value = DateTime.Now.Date;
                }
                if (crtl.GetType().Equals(typeof(RichTextBox)))
                {
                    (crtl as RichTextBox).Text = "";
                }
                if (crtl.GetType().Equals(typeof(CheckBox)))
                {
                    (crtl as CheckBox).Checked = false;
                }
            }
        }
        
    }
}
