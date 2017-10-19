using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class TipoDoc
    {
        private String tipoDocumento;
        private String sigla;

        public String Sigla
        {
            get { return sigla; }
            set { sigla = value; }
        }

        public String TipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }

    }
}
