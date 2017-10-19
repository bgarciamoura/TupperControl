using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class Documentos
    {
        private Consultora consultora;
        private TipoDoc tipoDoc;
        private String docNumero;
        private byte [] fotoDocumento;

        public Documentos()
        {
        }

        public Documentos(byte[] fotoDocumento, string docNumero, TipoDoc tipoDoc, Consultora consultora)
        {
            FotoDocumento = fotoDocumento;
            DocNumero = docNumero;
            TipoDoc = tipoDoc;
            Consultora = consultora;
        }

        public byte [] FotoDocumento
        {
            get { return fotoDocumento; }
            set { fotoDocumento = value; }
        }

        public String DocNumero
        {
            get { return docNumero; }
            set { docNumero = value; }
        }

        public TipoDoc TipoDoc
        {
            get { return tipoDoc; }
            set { tipoDoc = value; }
        }

        public Consultora Consultora
        {
            get { return consultora; }
            set { consultora = value; }
        }

    }
}
