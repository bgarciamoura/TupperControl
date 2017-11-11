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

        public controllerUnidadeMedida(ArrayList list)
        {
            unidadeMedida = new UnidadeMedida(list[1].ToString(), list[0].ToString());
        }

        public Boolean InserirUnidade()
        {
            
            //nesse ponto pego os dados da view
            /*unidadeMedida.Nome = "TESTEINSERT";
            unidadeMedida.Sigla = "T";*/
            
            dao = new daoUnidadeMedida();
            return dao.Insert(unidadeMedida);

        }

    }
}
