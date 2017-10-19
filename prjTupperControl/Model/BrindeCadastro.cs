using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class BrindeCadastro
    {
        private Consultora consultora;
        private Pecas peca;

        public BrindeCadastro()
        {
        }

        public BrindeCadastro(Pecas peca, Consultora consultoraBrinde)
        {
            Peca = peca;
            ConsultoraBrinde = consultoraBrinde;
        }

        public Pecas Peca
        {
            get { return peca; }
            set { peca = value; }
        }

        public Consultora ConsultoraBrinde
        {
            get { return consultora; }
            set { consultora = value; }
        }

    }
}
