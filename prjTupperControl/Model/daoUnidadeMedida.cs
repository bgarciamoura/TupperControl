using MySql.Data.MySqlClient;
using prjTupperControl.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTupperControl.Model
{
    class daoUnidadeMedida
    {
        private MySqlConnection conn;
        private String stringConn = "";
        private FileConn fileConn = new FileConn();
        private MySqlCommand sqlCommand;

        public daoUnidadeMedida()
        {
        }

        public Boolean Insert(UnidadeMedida unidadeMedida)
        {
            Boolean valReturn;
            fileConn.OpenXml();
            stringConn = fileConn.createStringConn();
            conn = new MySqlConnection(stringConn);
            sqlCommand = conn.CreateCommand();
            sqlCommand.Parameters.AddWithValue("@NOME", unidadeMedida.Nome);
            sqlCommand.Parameters.AddWithValue("@SIGLA", unidadeMedida.Sigla);

            try
            {
                conn.Open();
                sqlCommand.CommandText = "INSERT INTO `tupper`.`tb_UnidadeMedida` (`uni_Nome`, `uni_Sigla`) VALUES (@NOME, @SIGLA);";

                if (sqlCommand.ExecuteNonQuery() == 1)
                {
                    valReturn = true;
                }
                else
                {
                    valReturn = false;
                }
                return valReturn;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao inserir os dados:\n" + ex.ToString(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


    }
}
