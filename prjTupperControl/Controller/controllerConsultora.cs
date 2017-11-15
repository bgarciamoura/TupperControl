using prjTupperControl.Model;
using prjTupperControl.Model.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTupperControl.Controller
{
    class controllerConsultora
    {
        private Endereco endereco;
        private Pessoa pessoa;
        private Consultora consultora;
        private daoConsultora daoConsultora;


        public controllerConsultora()
        {
        }

        public Boolean Inserir(List<Hashtable> dados)
        {
            pessoa = ExtraiPessoa(dados[1]);
            pessoa.Endereco = ExtraiEndereco(dados[0]);
            consultora = ExtraiConsultora(dados[2]);
            consultora.Pessoa = pessoa;
            daoConsultora = new daoConsultora();
            return daoConsultora.Inserir(consultora);
        }

        private Consultora ExtraiConsultora(Hashtable dadosConsultora)
        {
            Consultora consultora = new Consultora();
            consultora.Codigo = Convert.ToInt32(dadosConsultora["CODIGO"]);
            consultora.DataCadastro = Convert.ToDateTime(dadosConsultora["DATACAD"]);
            consultora.EstaOk = Convert.ToBoolean(dadosConsultora["CADOK"]);
            consultora.Observacoes = dadosConsultora["OBS"].ToString();
            return consultora;
        }

        public Endereco ExtraiEndereco(Hashtable dadosEndereco)
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = dadosEndereco["LOGRADOURO"].ToString();
            endereco.Numero = Convert.ToInt32(dadosEndereco["NUMERO"]);
            endereco.Bairro = dadosEndereco["BAIRRO"].ToString();
            endereco.Cidade = dadosEndereco["CIDADE"].ToString();
            endereco.Cep = Convert.ToInt32(dadosEndereco["CEP"]);
            endereco.Observacoes = dadosEndereco["OBS"].ToString();
            return endereco;
        }

        public Pessoa ExtraiPessoa(Hashtable dadosPessoa)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = dadosPessoa["NOME"].ToString();
            pessoa.Idade = Convert.ToInt32(dadosPessoa["IDADE"]);
            pessoa.Nascimento = Convert.ToDateTime(dadosPessoa["NASCIMENTO"]);
            pessoa.Telefone = dadosPessoa["TELEFONE"].ToString();
            pessoa.Celular = dadosPessoa["CELULAR"].ToString();
            pessoa.Sexo = Convert.ToChar(dadosPessoa["SEXO"].ToString());
            return pessoa;
        }
    }
}
