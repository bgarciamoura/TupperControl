using prjTupperControl.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //DADOS DO ENDEREÇO
            Hashtable dadosEndereco = new Hashtable();
            dadosEndereco.Add("CIDADE", txtCidade.Text);
            dadosEndereco.Add("BAIRRO", txtBairro.Text);
            dadosEndereco.Add("LOGRADOURO", txtLogradouro.Text);
            dadosEndereco.Add("NUMERO", Convert.ToInt32(txtNumeroCasa.Text));
            dadosEndereco.Add("CEP", Convert.ToInt32(txtCep.Text));
            dadosEndereco.Add("OBS", rtxtObsEndereco.Text);

            //DADOS DA PESSOA
            Hashtable dadosPessoa = new Hashtable();
            dadosPessoa.Add("NOME", txtNome.Text);
            dadosPessoa.Add("IDADE", Convert.ToInt32(txtIdade.Text));
            dadosPessoa.Add("NASCIMENTO", dtpNascimento.Value.ToShortDateString());
            dadosPessoa.Add("TELEFONE", txtTelefone.Text);
            dadosPessoa.Add("CELULAR", txtCelular.Text);
            dadosPessoa.Add("SEXO", (cmbSexo.SelectedItem.ToString().Equals("Feminino  (F)")) ? "F" : "M" );
            //MessageBox.Show((cmbSexo.SelectedItem.ToString().Equals("Feminino  (F)")) ? "F" : "M");

            //DADOS CONSULTOR(A)
            Hashtable dadosConsultor = new Hashtable();
            dadosConsultor.Add("CODIGO", Convert.ToUInt32(txtCodigoConsultora.Text));
            dadosConsultor.Add("DATACAD", dtpDataCadastro.Value.ToShortDateString());
            dadosConsultor.Add("CADOK", (chkIsOk.Checked) ? 1 : 0);
            dadosConsultor.Add("OBS", rtxtObs.Text);
            //MessageBox.Show(Convert.ToString((chkIsOk.Checked) ? 1 : 0));

            List<Hashtable> dados = new List<Hashtable>();
            dados.Add(dadosEndereco);
            dados.Add(dadosPessoa);
            dados.Add(dadosConsultor);
            controllerConsultora controller = new controllerConsultora();
            controller.Inserir(dados);
        }
    }
}
