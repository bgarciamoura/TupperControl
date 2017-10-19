using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Model
{
    class Pecas
    {
        private UnidadeMedida unidadeMedida;
        private String nome;
        private String cor;
        private bool vaiFreezer;
        private bool vaiMicro;
        private int quantidade;
        private decimal capacidade;
        private byte[] foto;

        public Pecas()
        {
        }

        public Pecas(byte[] foto, decimal capacidade, int quantidade, bool vaiMicro, bool vaiFreezer, string cor, string nome, UnidadeMedida unidadeMedida)
        {
            Foto = foto;
            Capacidade = capacidade;
            Quantidade = quantidade;
            VaiMicro = vaiMicro;
            VaiFreezer = vaiFreezer;
            Cor = cor;
            Nome = nome;
            UnidadeMedidaPeca = unidadeMedida;
        }

        public byte[] Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public decimal Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public bool VaiMicro
        {
            get { return vaiMicro; }
            set { vaiMicro = value; }
        }

        public bool VaiFreezer
        {
            get { return vaiFreezer; }
            set { vaiFreezer = value; }
        }

        public String Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public UnidadeMedida UnidadeMedidaPeca
        {
            get { return unidadeMedida; }
            set { unidadeMedida = value; }
        }

    }
}
