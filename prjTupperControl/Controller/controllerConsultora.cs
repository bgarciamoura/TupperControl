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

        public string Inserir(List<Hashtable> dados)
        {
            pessoa = ExtraiPessoa(dados[1]);
            pessoa.Endereco = ExtraiEndereco(dados[0]);
            consultora = ExtraiConsultora(dados[2]);
            consultora.Pessoa = pessoa;
            daoConsultora = new daoConsultora();
            return daoConsultora.Inserir(consultora);
        }

        public List<Hashtable> ProcurarConsultora(string aux)
        {
            List<Hashtable> lista = new List<Hashtable>();
            List<Consultora> listaRetorno;
            daoConsultora = new daoConsultora();
            listaRetorno = daoConsultora.BuscarPesquisa(aux);
            for (int i = 0; i < listaRetorno.Count; i++)
            {
                Hashtable hashtable = new Hashtable();
                hashtable.Add("Codigo_Consultora", listaRetorno[i].Codigo);
                hashtable.Add("Data_Consultora", listaRetorno[i].DataCadastro);
                hashtable.Add("EstaOk_Consultora", listaRetorno[i].EstaOk);
                hashtable.Add("Obs_Consultora", listaRetorno[i].Observacoes);
                hashtable.Add("Nome_Pessoa", listaRetorno[i].Pessoa.Nome);
                hashtable.Add("Nasc_Pessoa", listaRetorno[i].Pessoa.Nascimento);
                hashtable.Add("Idade_Pessoa", listaRetorno[i].Pessoa.Idade);
                hashtable.Add("Sexo_Pessoa", listaRetorno[i].Pessoa.Sexo);
                hashtable.Add("Telefone_Pessoa", listaRetorno[i].Pessoa.Telefone);
                hashtable.Add("Celular_Pessoa", listaRetorno[i].Pessoa.Celular);
                hashtable.Add("Logra_Endereco", listaRetorno[i].Pessoa.Endereco.Logradouro);
                hashtable.Add("Numero_Endereco", listaRetorno[i].Pessoa.Endereco.Numero);
                hashtable.Add("Bairro_Endereco", listaRetorno[i].Pessoa.Endereco.Bairro);
                hashtable.Add("Cep_Endereco", listaRetorno[i].Pessoa.Endereco.Cep);
                hashtable.Add("Cidade_Endereco", listaRetorno[i].Pessoa.Endereco.Cidade);
                hashtable.Add("Obs_Endereco", listaRetorno[i].Pessoa.Endereco.Observacoes);
                lista.Add(hashtable);
            }

            return lista;
        }

        public List<Hashtable> RetornaTudo()
        {
            List<Hashtable> lista = new List<Hashtable>();
            List<Consultora> listaRetorno;
            daoConsultora = new daoConsultora();
            listaRetorno = daoConsultora.RetornaTudo();
            for (int i = 0; i < listaRetorno.Count; i++)
            {
                Hashtable hashtable = new Hashtable();
                hashtable.Add("Codigo_Consultora", listaRetorno[i].Codigo);
                hashtable.Add("Data_Consultora", listaRetorno[i].DataCadastro);
                hashtable.Add("EstaOk_Consultora", listaRetorno[i].EstaOk);
                hashtable.Add("Obs_Consultora", listaRetorno[i].Observacoes);
                hashtable.Add("Nome_Pessoa", listaRetorno[i].Pessoa.Nome);
                hashtable.Add("Nasc_Pessoa", listaRetorno[i].Pessoa.Nascimento);
                hashtable.Add("Idade_Pessoa", listaRetorno[i].Pessoa.Idade);
                hashtable.Add("Sexo_Pessoa", listaRetorno[i].Pessoa.Sexo);
                hashtable.Add("Telefone_Pessoa", listaRetorno[i].Pessoa.Telefone);
                hashtable.Add("Celular_Pessoa", listaRetorno[i].Pessoa.Celular);
                hashtable.Add("Logra_Endereco", listaRetorno[i].Pessoa.Endereco.Logradouro);
                hashtable.Add("Numero_Endereco", listaRetorno[i].Pessoa.Endereco.Numero);
                hashtable.Add("Bairro_Endereco", listaRetorno[i].Pessoa.Endereco.Bairro);
                hashtable.Add("Cep_Endereco", listaRetorno[i].Pessoa.Endereco.Cep);
                hashtable.Add("Cidade_Endereco", listaRetorno[i].Pessoa.Endereco.Cidade);
                hashtable.Add("Obs_Endereco", listaRetorno[i].Pessoa.Endereco.Observacoes);
                lista.Add(hashtable);
            }
            
            return lista;
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
            if (dadosEndereco["LOGRADOURO"].Equals(""))
            {
                return endereco = null;
            }
            else
            {
                endereco.Logradouro = dadosEndereco["LOGRADOURO"].ToString();
                endereco.Numero = Convert.ToInt32(dadosEndereco["NUMERO"]);
                endereco.Bairro = dadosEndereco["BAIRRO"].ToString();
                endereco.Cidade = dadosEndereco["CIDADE"].ToString();
                endereco.Cep = Convert.ToInt32(dadosEndereco["CEP"]);
                endereco.Observacoes = dadosEndereco["OBS"].ToString();
                return endereco;
            }            
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
