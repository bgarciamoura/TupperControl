using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class UnidadeMedida
    {
        private String nome;
        private String sigla;

        public UnidadeMedida()
        {
        }

        public UnidadeMedida(string sigla, string nome)
        {
            Sigla = sigla;
            Nome = nome;
        }

        public String Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
