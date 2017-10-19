using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class CliNaoGosta
    {
        private Clientes cliente;
        private Pecas peca;

        public CliNaoGosta()
        {
        }

        public CliNaoGosta(Pecas peca, Clientes cliente)
        {
            Peca = peca;
            Cliente = cliente;
        }

        public Pecas Peca
        {
            get { return peca; }
            set { peca = value; }
        }

        public Clientes Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

    }
}
