using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class CliCompradas
    {
        private Clientes cliente;
        private Pecas peca;
        private int quantidade;


        public CliCompradas()
        {
        }

        public CliCompradas(Pecas peca, Clientes cliente, int quantidade)
        {
            Peca = peca;
            Cliente = cliente;
            Quantidade = quantidade;
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
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
