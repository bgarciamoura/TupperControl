using prjTupperControl.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTupperControl.Controller
{
    class controllerUnidadeMedida
    {
        private UnidadeMedida unidadeMedida;
        private daoUnidadeMedida dao;

        public controllerUnidadeMedida()
        {

        }

        public controllerUnidadeMedida(ArrayList list)
        {
            unidadeMedida = new UnidadeMedida(list[1].ToString(), list[0].ToString());
        }

        public Boolean InserirUnidade()
        {            
            dao = new daoUnidadeMedida();
            return dao.Insert(unidadeMedida);
        }

        public Boolean RemoverUnidade()
        {
            dao = new daoUnidadeMedida();
            return dao.Delete(unidadeMedida);
        }

        public List<String[]> PesquisaTudo()
        {
            List<String[]> lista = new List<String[]>();
            dao = new daoUnidadeMedida();
            List<UnidadeMedida> unidades = dao.GetAllUnidades();

            for (int i = 0; i < unidades.Count; i++)
            {
                lista.Add(new String[2] { unidades[i].Nome.ToString(), unidades[i].Sigla.ToString() } );
            }

            return lista;
        }

        public List<String> PesquisaUm(string nomeUnidade)
        {
            List<String> unMedida = new List<String>();
            unidadeMedida = new UnidadeMedida();
            unidadeMedida.Nome = nomeUnidade;
            unidadeMedida.Sigla = "";
            dao = new daoUnidadeMedida();
            UnidadeMedida item = dao.GetUnidadeMedida(unidadeMedida);
            if (item.Nome == null)
            {
                return null;
            }
            else
            {
                unMedida.Add(item.Nome.ToString());
                unMedida.Add(item.Sigla.ToString());
                return unMedida;
            }
            
        }

        public List<String[]> PesquisaTudoIncompleto(string nome)
        {
            List<String[]> lista = new List<String[]>();
            dao = new daoUnidadeMedida();
            List<UnidadeMedida> unidades = dao.GetAllUnidadesIncomplete(nome);

            for (int i = 0; i < unidades.Count; i++)
            {
                lista.Add(new String[2] { unidades[i].Nome.ToString(), unidades[i].Sigla.ToString() });
            }

            return lista;
        }

        public Boolean Atualizar(string nome, string sigla)
        {
            unidadeMedida = new UnidadeMedida(sigla, nome);
            dao = new daoUnidadeMedida();
            return dao.Update(unidadeMedida);
        }
    }
}
