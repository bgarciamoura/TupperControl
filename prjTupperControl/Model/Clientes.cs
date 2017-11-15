using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class Clientes
    {
        private String corPreferida;
        private bool pagaEmDia;
        private String observacoes;
        private Pessoa pessoa;

        public Clientes()
        {
        }

        public Clientes(string observacoes, bool pagaEmDia, string corPreferida, Pessoa pessoa)
        {
            Observacoes = observacoes;
            PagaEmDia = pagaEmDia;
            CorPreferida = corPreferida;
            Pessoa = pessoa;
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

        public bool PagaEmDia
        {
            get { return pagaEmDia; }
            set { pagaEmDia = value; }
        }

        public String CorPreferida
        {
            get { return corPreferida; }
            set { corPreferida = value; }
        }

    }
}
