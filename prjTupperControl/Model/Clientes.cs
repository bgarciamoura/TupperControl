using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class Clientes : Pessoa
    {
        private String corPreferida;
        private bool pagaEmDia;
        private String observacoes;

        public Clientes()
        {
        }

        public Clientes(string observacoes, bool pagaEmDia, string corPreferida)
        {
            Observacoes = observacoes;
            PagaEmDia = pagaEmDia;
            CorPreferida = corPreferida;
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
