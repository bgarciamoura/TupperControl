using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class Endereco
    {
        private String logradouro;
        private int numero;
        private String bairro;
        private String cidade;
        private int cep;
        private String observacoes;

        public Endereco()
        {
        }

        public Endereco(string observacoes, int cep, string cidade, string bairro, int numero, string logradouro)
        {
            Observacoes = observacoes;
            Cep = cep;
            Cidade = cidade;
            Bairro = bairro;
            Numero = numero;
            Logradouro = logradouro;
        }

        public String Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public int Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }

    }
}
