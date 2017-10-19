using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class Consultora : Pessoa
    {
        private long codigo;
        private DateTime dataCadastro;
        private bool estaOk;
        private String observacoes;

        public Consultora()
        {
        }

        public Consultora(string observacoes, bool estaOk, DateTime dataCadastro, long codigo)
        {
            Observacoes = observacoes;
            EstaOk = estaOk;
            DataCadastro = dataCadastro;
            Codigo = codigo;
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
