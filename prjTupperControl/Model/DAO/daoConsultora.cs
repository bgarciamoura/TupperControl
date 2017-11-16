﻿using MySql.Data.MySqlClient;
using prjTupperControl.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTupperControl.Model.DAO
{
    class daoConsultora
    {
        private FileConn fileConn;
        private MySqlCommand sqlCommand;
        private MySqlDataReader dataReader;
        private MySqlConnection connection;

        public daoConsultora()
        {
            fileConn = new FileConn();
        }

        public string Inserir(Consultora consultora)
        {
            int idRetornoEndereco = -2;
            int idRetornoPessoa = -2;
            connection = fileConn.PrepareConnection();
            connection.Open();
            sqlCommand = connection.CreateCommand();

            if (!PessoaExiste(consultora.Pessoa.Nome))
            {
                if (!(consultora.Pessoa.Endereco == null))
                {
                    if (!EnderecoExiste(consultora.Pessoa.Endereco.Logradouro, Convert.ToString(consultora.Pessoa.Endereco.Numero), consultora.Pessoa.Endereco.Bairro))
                    {
                        idRetornoEndereco = InserirEndereco(consultora.Pessoa.Endereco);
                    }
                    else
                    {
                        idRetornoEndereco = IDEndereco(consultora.Pessoa.Endereco.Logradouro, Convert.ToString(consultora.Pessoa.Endereco.Numero), consultora.Pessoa.Endereco.Bairro);
                    }
                    idRetornoPessoa = InserirPessoa(consultora.Pessoa, idRetornoEndereco);
                }
                else
                {
                    idRetornoPessoa = InserirPessoa(consultora.Pessoa, null);
                }
                
                return (InserirConsultora(consultora, idRetornoPessoa) > 0) ? "Consultora cadastrada com sucesso!" : "Erro ao cadastrar consultora!";

            }
            else
            {
                idRetornoPessoa = IDPessoa(consultora.Pessoa.Nome);
                //idRetornoEndereco = IDEndereco(consultora.Pessoa.Endereco.Logradouro, Convert.ToString(consultora.Pessoa.Endereco.Numero), consultora.Pessoa.Endereco.Bairro);
                if (ConsultoraExiste(idRetornoPessoa))
                {
                    return "Consultora já cadastrada";
                }
                else
                {
                    return (InserirConsultora(consultora, idRetornoPessoa) > 0) ? "Consultora cadastrada com sucesso!" : "Erro ao cadastrar consultora";
                }
            }
        }

        private int IDEndereco(string logradouro, string numero, string bairro)
        {
            MySqlConnection sqlConnection = fileConn.PrepareConnection();
            sqlConnection.Open();
            MySqlCommand command = sqlConnection.CreateCommand();
            command.Parameters.AddWithValue("LOGRADOURO", logradouro);
            command.Parameters.AddWithValue("NUMERO", numero);
            command.Parameters.AddWithValue("BAIRRO", bairro);
            command.CommandText = "SELECT `end_ID` FROM `tb_endereco` WHERE `end_Logradouro` = @LOGRADOURO AND `end_Numero` = @NUMERO AND `end_Bairro` = @BAIRRO;";
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private int IDPessoa(string nome)
        {
            MySqlConnection sqlConnection = fileConn.PrepareConnection();
            sqlConnection.Open();
            MySqlCommand command = sqlConnection.CreateCommand();
            command.Parameters.AddWithValue("NOME", nome);
            command.CommandText = "SELECT `pes_ID` FROM `tb_pessoa` WHERE `pes_Nome` = @NOME;";
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public Boolean EnderecoExiste(String logradouro, String numero, String bairro)
        {
            //CRIA UMA NOVA CONEXÃO PARA A CONSULTA
            MySqlConnection sqlConnection = fileConn.PrepareConnection();
            try
            {
                //ABRE A CONEXÃO
                sqlConnection.Open();
                
                //CRIA UM COMANDO PARA REALIZAR A CONSULTA
                MySqlCommand command = sqlConnection.CreateCommand();
                
                //ADICIONA O PARAMETRO RECEBIDO A CONSULTA
                command.Parameters.AddWithValue("PARAM1", logradouro);
                command.Parameters.AddWithValue("PARAM2", numero);
                command.Parameters.AddWithValue("PARAM3", bairro);
                
                //MONTA A CONSULTA
                command.CommandText = "SELECT * FROM `tupper`.`tb_endereco` WHERE `end_Logradouro` = @PARAM1 AND `end_Numero` = @PARAM2 AND `end_Bairro` = @PARAM3;";
                
                //JOGA O RETORNO DA SCALAR PARA UMA VARIAVEL.
                var retorno = command.ExecuteScalar();
                
                //FECHA A CONEXÃO
                sqlConnection.Close();
                
                //VERIFICA SE O A VARIAVEL RETORNO POSSUI ALGUM VALOR OU NÃO
                return (retorno != null) ? true : false;
            }
            catch (MySqlException x)
            {
                throw;
            }
        }

        public Boolean PessoaExiste(String nome)
        {
            //CRIA UMA NOVA CONEXÃO PARA A CONSULTA
            MySqlConnection sqlConnection = fileConn.PrepareConnection();
            try
            {
                //ABRE A CONEXÃO
                sqlConnection.Open();

                //CRIA UM COMANDO PARA REALIZAR A CONSULTA
                MySqlCommand command = sqlConnection.CreateCommand();

                //ADICIONA O PARAMETRO RECEBIDO A CONSULTA
                command.Parameters.AddWithValue("PARAM1", nome);

                //MONTA A CONSULTA
                command.CommandText = "SELECT * FROM `tupper`.`tb_pessoa` WHERE `pes_Nome` = @PARAM1;";

                //JOGA O RETORNO DA SCALAR PARA UMA VARIAVEL.
                var retorno = command.ExecuteScalar();

                //FECHA A CONEXÃO
                sqlConnection.Close();

                //VERIFICA SE O A VARIAVEL RETORNO POSSUI ALGUM VALOR OU NÃO
                return (retorno != null) ? true : false;
            }
            catch (MySqlException x)
            {
                throw;
            }
        }

        public Boolean ConsultoraExiste(int ID)
        {
            //CRIA UMA NOVA CONEXÃO PARA A CONSULTA
            MySqlConnection sqlConnection = fileConn.PrepareConnection();
            try
            {
                //ABRE A CONEXÃO
                sqlConnection.Open();

                //CRIA UM COMANDO PARA REALIZAR A CONSULTA
                MySqlCommand command = sqlConnection.CreateCommand();

                //ADICIONA O PARAMETRO RECEBIDO A CONSULTA
                command.Parameters.AddWithValue("PARAM1", ID);

                //MONTA A CONSULTA
                command.CommandText = "SELECT * FROM `tupper`.`tb_consultora` WHERE `tb_consultora`.`pes_ID` = @PARAM1;";

                //JOGA O RETORNO DA SCALAR PARA UMA VARIAVEL.
                var retorno = command.ExecuteScalar();

                //FECHA A CONEXÃO
                sqlConnection.Close();

                //VERIFICA SE O A VARIAVEL RETORNO POSSUI ALGUM VALOR OU NÃO
                return (retorno != null) ? true : false;
            }
            catch (MySqlException x)
            {
                throw;
            }
        }

        public int InserirEndereco(Endereco endereco)
        {
            MySqlConnection sqlConnection = fileConn.PrepareConnection();
            sqlConnection.Open();
            MySqlCommand command = sqlConnection.CreateCommand();
            command.Parameters.AddWithValue("LOGRADOURO", endereco.Logradouro);
            command.Parameters.AddWithValue("NUMERO", endereco.Numero);
            command.Parameters.AddWithValue("BAIRRO", endereco.Bairro);
            command.Parameters.AddWithValue("CIDADE", endereco.Cidade);
            command.Parameters.AddWithValue("CEP", endereco.Cep);
            command.Parameters.AddWithValue("OBS", endereco.Observacoes);
            command.CommandText = "INSERT INTO `tupper`.`tb_endereco`(`end_Logradouro`,`end_Numero`,`end_Bairro`,`end_Cidade`,`end_Cep`,`end_Observacao`)" +
                                                        "VALUES(@LOGRADOURO," +
                                                        "@NUMERO," +
                                                        "@BAIRRO," +
                                                        "@CIDADE," +
                                                        "@CEP," +
                                                        "@OBS);";
            if (command.ExecuteNonQuery() == 1)
            {
                MySqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT MAX(end_ID) FROM tb_endereco;";
                return  Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            else
            {
                return -1;
            }
            
        }

        public int InserirPessoa(Pessoa pessoa, int? enderecoID)
        {
            MySqlConnection sqlConnection = fileConn.PrepareConnection();
            sqlConnection.Open();
            MySqlCommand command = sqlConnection.CreateCommand();
            command.Parameters.AddWithValue("ENDERECOID", enderecoID);
            command.Parameters.AddWithValue("NOME", pessoa.Nome);
            command.Parameters.AddWithValue("SEXO", pessoa.Sexo);
            command.Parameters.AddWithValue("NASCIMENTO", pessoa.Nascimento);
            command.Parameters.AddWithValue("IDADE", pessoa.Idade);
            command.Parameters.AddWithValue("TELEFONE", pessoa.Telefone);
            command.Parameters.AddWithValue("CELULAR", pessoa.Celular);
            command.CommandText = "INSERT INTO `tupper`.`tb_pessoa`(`end_ID`,`pes_Nome`,`pes_Sexo`,`pes_Nascimento`,`pes_Idade`,`pes_Telefone`,`pes_Celular`) " +
                                    "VALUES(" +
                                    "@ENDERECOID," +
                                    "@NOME," +
                                    "@SEXO," +
                                    "@NASCIMENTO," +
                                    "@IDADE," +
                                    "@TELEFONE," +
                                    "@CELULAR); ";
            if (command.ExecuteNonQuery() == 1)
            {
                MySqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT MAX(pes_ID) FROM tb_pessoa;";
                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            else
            {
                return -1;
            }

        }

        public int InserirConsultora(Consultora consultora, int pessoaID)
        {
            MySqlConnection sqlConnection = fileConn.PrepareConnection();
            sqlConnection.Open();
            MySqlCommand command = sqlConnection.CreateCommand();
            command.Parameters.AddWithValue("PESID", pessoaID);
            command.Parameters.AddWithValue("CODCONSULTORA", consultora.Codigo);
            command.Parameters.AddWithValue("DATACAD", consultora.DataCadastro);
            command.Parameters.AddWithValue("OK", consultora.EstaOk);
            command.Parameters.AddWithValue("OBS", consultora.Observacoes);
            command.CommandText = "INSERT INTO `tupper`.`tb_consultora`(`pes_ID`,`con_Codigo`,`con_DataCadastro`,`con_EstaOk`,`con_Observacoes`)" +
                                                                "VALUES(@PESID," +
                                                                "@CODCONSULTORA," +
                                                                "@DATACAD," +
                                                                "@OK," +
                                                                "@OBS);";
            if (command.ExecuteNonQuery() == 1)
            {
                MySqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "SELECT MAX(con_ID) FROM tb_consultora;";
                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            else
            {
                return -1;
            }
        }
    }
}
