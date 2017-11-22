using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class Consultora
    {
        private long codigo;
        private DateTime dataCadastro;
        private bool estaOk;
        private bool estaAtiva;
        private String observacoes;
        private Pessoa pessoa;
        private int codConsultora;

        public Consultora()
        {
        }

        public Consultora(string observacoes, bool estaOk, bool estaAtiva, DateTime dataCadastro, long codigo, Pessoa pessoa, int codConsultora)
        {
            Observacoes = observacoes;
            EstaOk = estaOk;
            EstaAtiva = estaAtiva;
            DataCadastro = dataCadastro;
            Codigo = codigo;
            Pessoa = pessoa;
            CodConsultora = codConsultora;
        }

        public int CodConsultora
        {
            get { return codConsultora; }
            set { codConsultora = value; }
        }

        public Pessoa Pessoa
        {
            get { return pessoa; }
            set { pessoa = value; }
        }

        public String Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        public bool EstaOk
        {
            get { return estaOk; }
            set { estaOk = value; }
        }

        public bool EstaAtiva
        {
            get { return estaAtiva; }
            set { estaAtiva = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public long Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
