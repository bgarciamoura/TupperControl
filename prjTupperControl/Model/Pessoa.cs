using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class Pessoa
    {
        private String nome;
        private DateTime nascimento;
        private int idade;
        private String telefone;
        private String celular;
        private Endereco endereco;
        private char sexo;

        public Pessoa()
        {
        }

        public Pessoa(Endereco endereco, string celular, string telefone, int idade, DateTime nascimento, string nome, char sexo)
        {
            Endereco = endereco;
            Celular = celular;
            Telefone = telefone;
            Idade = idade;
            Nascimento = nascimento;
            Nome = nome;
            Sexo = sexo;
        }

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public DateTime Nascimento
        {
            get { return nascimento; }
            set { nascimento = value; }
        }
        
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
