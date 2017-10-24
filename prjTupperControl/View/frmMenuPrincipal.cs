using prjTupperControl.Controller;
using prjTupperControl.View;
using System;
using System.Windows.Forms;

namespace prjTupperControl
{
    public partial class frmMenuPrincipal : Form
    {
        public const int CONSULTORA = 1;
        public const int CLIENTE = 2;
        public const int CONSORCIO = 3;
        public const int PECAS = 4;
        public const int SAIR = 5;
        int CONTROL = 0;

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bem Vinda Jaqueline!", "Olá!", MessageBoxButtons.OK);
        }

        private void frmMenuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F1))
            {
                if (btnSair.Tag.Equals("Cadastro"))
                {
                    btnConsultoras_Click(sender, e);
                }
                else
                {
                    TrocaImagens(CONSULTORA);
                    TrocaTag(CONSULTORA);
                    CONTROL = CONSULTORA;
                }
            }
            if (e.KeyCode.Equals(Keys.F2))
            {
                if (btnSair.Tag.Equals("Cadastro"))
                {
                    btnClientes_Click(sender, e);
                }
                else
                {
                    TrocaImagens(CLIENTE);
                    TrocaTag(CLIENTE);
                    CONTROL = CLIENTE;
                }
            }
            if (e.KeyCode.Equals(Keys.F3))
            {
                if (btnSair.Tag.Equals("Cadastro"))
                {
                    btnConsorcio_Click(sender, e);
                }
                else
                {
                    TrocaImagens(CONSORCIO);
                    TrocaTag(CONSORCIO);
                    CONTROL = CONSORCIO;
                }
            }
            if (e.KeyCode.Equals(Keys.F4))
            {
                if (btnSair.Tag.Equals("Cadastro"))
                {
                    btnPecas_Click(sender, e);
                }
                else
                {
                    TrocaImagens(PECAS);
                    TrocaTag(PECAS);
                    CONTROL = PECAS;
                }
            }
            if (e.KeyCode.Equals(Keys.F9))
            {
                if (btnSair.Tag.Equals("Cadastro"))
                {
                    btnSair_Click(sender, e);
                }
                else
                {
                    TrocaTag(SAIR);
                    MessageBox.Show("Até mais Jaqueline!", "Volte Sempre!");
                    this.Close();
                }
            }
        }

        private void btnConsultoras_Click(object sender, EventArgs e)
        {
            if (btnSair.Tag.Equals("Cadastro"))
            {
                fechaFilhos();
                
                abreForm(CONTROL, btnConsultoras.Tag.ToString());
            }
            else
            {
                TrocaImagens(CONSULTORA);
                TrocaTag(CONSULTORA);
                CONTROL = CONSULTORA;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (btnSair.Tag.Equals("Cadastro"))
            {
                fechaFilhos();
                abreForm(CONTROL, btnClientes.Tag.ToString());
            }
            else
            {
                TrocaImagens(CLIENTE);
                TrocaTag(CLIENTE);
                CONTROL = CLIENTE;
            }
        }

        private void btnConsorcio_Click(object sender, EventArgs e)
        {
            if (btnSair.Tag.Equals("Cadastro"))
            {
                fechaFilhos();
                abreForm(CONTROL, btnConsorcio.Tag.ToString());
            }
            else
            {
                TrocaImagens(CONSORCIO);
                TrocaTag(CONSORCIO);
                CONTROL = CONSORCIO;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (btnSair.Tag.Equals("Cadastro"))
            {
                TrocaTag(5);
                TrocaImagens(5);
                fechaFilhos();
                CONTROL = 0;
            }
            else
            {
                btnSair.Tag = "Sair";
                MessageBox.Show("Até mais Jaqueline!");
                this.Close();
            }
        }
        
        private void btnPecas_Click(object sender, EventArgs e)
        {
            if (btnSair.Tag.Equals("Cadastro"))
            {
                fechaFilhos();
                abreForm(CONTROL, btnPecas.Tag.ToString());
            }
            else
            {
                TrocaImagens(PECAS);
                TrocaTag(PECAS);
                CONTROL = PECAS;
            }
        }

        //TROCAR AS IMAGENS DOS BOTÕES CONFORME O BOTÃO PREVIAMENTE CLICADO
        public void TrocaImagens(int x)
        {
            btnPecas.Enabled = false;
            btnConsorcio.Enabled = false;
            switch (x)
            {
                case 1:
                    btnConsultoras.Image = Properties.Resources.girl_Consultora_64x64_By_Freepik;
                    btnClientes.Image = Properties.Resources.girl_Consultora_64x64_By_Freepik;
                    //btnConsorcio.Image = Properties.Resources.girl_Consultora_64x64_By_Freepik;
                    break;
                case 2:
                    btnConsultoras.Image = Properties.Resources.girl_Cliente_64x64_By_Freepik;
                    btnClientes.Image = Properties.Resources.girl_Cliente_64x64_By_Freepik;
                    //btnConsorcio.Image = Properties.Resources.girl_Cliente_64x64_By_Freepik;
                    break;
                case 3:
                    btnConsultoras.Image = Properties.Resources.girl_Consorcio_64x64_By_Freepik;
                    btnClientes.Image = Properties.Resources.girl_Consorcio_64x64_By_Freepik;
                    btnConsorcio.Image = Properties.Resources.group2_ByFreepik_EdittedByVycros;
                    btnConsorcio.Enabled = true;
                    break;
                case 4:
                    btnConsultoras.Image = Properties.Resources.bowl_64x64_By_Smashicons;
                    btnClientes.Image = Properties.Resources.bowl_64x64_By_Smashicons;
                    //btnConsorcio.Image = Properties.Resources.bowl_64x64_By_Smashicons;
                    break;
                default:
                    btnPecas.Enabled = true;
                    btnConsorcio.Enabled = true;
                    btnConsultoras.Image = Properties.Resources.girl_Consultora_64x64_By_Freepik;
                    btnClientes.Image = Properties.Resources.girl_Cliente_64x64_By_Freepik;
                    btnConsorcio.Image = Properties.Resources.girl_Consorcio_64x64_By_Freepik;
                    break;
            }
        }

        //TROCA AS TAGS DOS BOTÕES PARA IDENTIFICAR O QUE CADA BOTÃO FARÁ
        public void TrocaTag(int x)
        {
            switch (x)
            {
                case 3:
                    btnSair.Tag = "Cadastro";
                    btnConsultoras.Text = "Cadastrar\n(F1)";
                    btnClientes.Text = "Ver Dados\n(F2)";
                    btnConsorcio.Text = "Grupos\n(F3)";
                    btnSair.Text = "Voltar\n(F9)";
                    break;
                case 5:
                    btnSair.Tag = "Limpo";
                    btnConsultoras.Text = "Consultoras\n(F1)";
                    btnClientes.Text = "Clientes\n(F2)";
                    btnConsorcio.Text = "Consórcio\n(F3)";
                    btnSair.Text = "Sair\n(F9)";
                    break;
                default:
                    btnSair.Tag = "Cadastro";
                    btnConsultoras.Text = "Cadastrar\n(F1)";
                    btnClientes.Text = "Ver Dados\n(F2)";
                    //btnConsorcio.Text = "Excluir\n(F3)";
                    btnSair.Text = "Voltar\n(F9)";
                    break;
            }
        }

        //FECHA TODOS OS FILHOS ATIVOS DENTRO DO MDICONTAINER
        public void fechaFilhos()
        {
            foreach (var frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        //ABRE UM DETERMINADO FORM FILHO DENTRO DO MDI COM BASE NO CONTROLE E NA TAG DO BOTÃO
        public void abreForm(int controle, String tag)
        {
            Form frm;
            switch (controle)
            {
                case 1://CADASTRO CONSULTORA
                    if (tag.Equals("Cadastro"))
                    {
                        frm = new frmCadConsultora();
                    }
                    else if (tag.Equals("Ver Dados"))
                    {
                        frm = new frmDadosConsultora();
                    }
                    else
                    {
                        frm = new frmLayoutFit();
                    }
                    frm.MdiParent = this;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    break;
                case 2://CADASTRO CLIENTES
                    if (tag.Equals("Cadastro"))
                    {
                        frm = new frmCadClientes();
                    }
                    else if (tag.Equals("Ver Dados"))
                    {
                        frm = new frmDadosClientes();
                    }
                    else
                    {
                        frm = new frmLayoutFit();
                    }
                    
                    frm.MdiParent = this;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    break;
                case 4:
                    if (tag.Equals("Cadastro"))
                    {
                        frm = new frmCadPecas();
                    }
                    else if (tag.Equals("Ver Dados"))
                    {
                        frm = new frmDadosPecas();
                    }
                    else
                    {
                        frm = new frmLayoutFit();
                    }

                    frm.MdiParent = this;
                    frm.Dock = DockStyle.Fill;
                    frm.Show();
                    break;
                default:
                    break;
            }
        }

    }
}
