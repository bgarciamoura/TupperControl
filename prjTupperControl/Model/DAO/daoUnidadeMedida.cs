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
        private String stringConn = "";
        private FileConn fileConn = new FileConn();
        private MySqlCommand sqlCommand;
        private MySqlDataReader dataReader;

        public daoUnidadeMedida()
        {
        }

        public MySqlConnection PrepareConnection()
        {
            MySqlConnection conn;
            fileConn.OpenXml();
            stringConn = fileConn.createStringConn();
            conn = new MySqlConnection(stringConn);
            return conn;
        }

        public Boolean Insert(UnidadeMedida unidadeMedida)
        {
            Boolean valReturn = false;
            MySqlConnection sqlConnection = PrepareConnection();
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.Parameters.AddWithValue("@NOME", unidadeMedida.Nome);
            sqlCommand.Parameters.AddWithValue("@SIGLA", unidadeMedida.Sigla);
           
            try
            {
                sqlConnection.Open();
                if (!Exists(sqlCommand.Parameters[0].Value.ToString()))
                {
                    sqlCommand.CommandText = "INSERT INTO `tupper`.`tb_UnidadeMedida` (`uni_Nome`, `uni_Sigla`) VALUES (@NOME, @SIGLA);";
                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        valReturn = true;
                    }
                    //return valReturn;
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
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public Boolean Exists(String parameter)
        {
            //CRIA UMA NOVA CONEXÃO PARA A CONSULTA
            MySqlConnection sqlConnection = new MySqlConnection(stringConn);
            try
            {
                //ABRE A CONEXÃO
                sqlConnection.Open();
                //CRIA UM COMANDO PARA REALIZAR A CONSULTA
                MySqlCommand command = sqlConnection.CreateCommand();
                //ADICIONA O PARAMETRO RECEBIDO A CONSULTA
                command.Parameters.AddWithValue("PARAM", parameter);
                //MONTA A CONSULTA
                command.CommandText = "SELECT * FROM `tupper`.`tb_UnidadeMedida` WHERE `uni_Nome` = @PARAM;";
                //JOGA O RETORNO DA SCALAR PARA UMA VARIAVEL.
                var retorno = command.ExecuteScalar();
                //FECHA A CONEXÃO
                sqlConnection.Close();
                //VERIFICA SE O A VARIAVEL RETORNO POSSUI ALGUM VALOR OU NÃO
                if (retorno != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException x)
            {
                throw;
            }
        }

        public Boolean Delete(UnidadeMedida unidade)
        {
            MySqlConnection sqlConnection = PrepareConnection();
            try
            {
                sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.Parameters.AddWithValue("NOME", unidade.Nome);
                sqlCommand.Parameters.AddWithValue("SIGLA", unidade.Sigla);
                sqlConnection.Open();
                if (Exists(sqlCommand.Parameters[0].Value.ToString()))
                {
                    sqlCommand.CommandText = "SET SQL_SAFE_UPDATES=0; DELETE FROM `tupper`.`tb_unidademedida` WHERE `uni_Nome` = @NOME AND `uni_Sigla` = @SIGLA;";
                    if (sqlCommand.ExecuteNonQuery() == 1)
                    {
                        sqlConnection.Close();
                        return true;
                    }
                    else
                    {
                        sqlConnection.Close();
                        return false;
                    }
                }
                else
                {
                    sqlConnection.Close();
                    return false;
                }
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao deletar os dados:\n" + ex.ToString(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public List<UnidadeMedida> GetAllUnidades()
        {
            List<UnidadeMedida> unidadeList = new List<UnidadeMedida>();
            MySqlConnection connection = PrepareConnection();
            

            sqlCommand = connection.CreateCommand();
            sqlCommand.CommandText = "SELECT * FROM `tupper`.`tb_unidademedida`;";
            connection.Open();
            dataReader = sqlCommand.ExecuteReader();
            
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    UnidadeMedida unidade = new UnidadeMedida();
                    unidade.Nome = dataReader[1].ToString();
                    unidade.Sigla = dataReader[2].ToString();
                    unidadeList.Add(unidade);
                }
                
            }
            connection.Close();
            return unidadeList;
        }

        public UnidadeMedida GetUnidadeMedida(UnidadeMedida find)
        {
            UnidadeMedida unidade = new UnidadeMedida();
            MySqlConnection connection = PrepareConnection();
            MySqlDataReader reader;
            sqlCommand = connection.CreateCommand();
            sqlCommand.Parameters.AddWithValue("NOME", find.Nome);
            sqlCommand.CommandText = "SELECT * FROM `tupper`.`tb_unidademedida` WHERE uni_Nome = @NOME;";
            connection.Open();
            reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    unidade.Nome = reader[1].ToString();
                    unidade.Sigla = reader[2].ToString();
                }
            }

            return unidade;
        }

        public List<UnidadeMedida> GetAllUnidadesIncomplete(string find)
        {
            List<UnidadeMedida> unidadeList = new List<UnidadeMedida>();
            MySqlConnection connection = fileConn.PrepareConnection();// PrepareConnection();


            sqlCommand = connection.CreateCommand();
            sqlCommand.Parameters.AddWithValue("NOME", "%" + find + "%");
            sqlCommand.CommandText = "SELECT * FROM `tupper`.`tb_unidademedida` WHERE `uni_Nome` LIKE @NOME;";
            connection.Open();
            dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    UnidadeMedida unidade = new UnidadeMedida();
                    unidade.Nome = dataReader[1].ToString();
                    unidade.Sigla = dataReader[2].ToString();
                    unidadeList.Add(unidade);
                }

            }
            connection.Close();
            return unidadeList;
        }

        public Boolean Update(UnidadeMedida unidadeMedida)
        {
            MySqlConnection connection = PrepareConnection();
            connection.Open();
            sqlCommand = connection.CreateCommand();
            sqlCommand.Parameters.AddWithValue("@NOME", unidadeMedida.Nome);
            sqlCommand.Parameters.AddWithValue("@SIGLA", unidadeMedida.Sigla);
            sqlCommand.CommandText = "UPDATE `tb_unidademedida` SET `uni_Nome` = @NOME,`uni_Sigla` = @SIGLA WHERE `uni_Nome` = @NOME;";
            
            if (sqlCommand.ExecuteNonQuery() == 1)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
    }
}
