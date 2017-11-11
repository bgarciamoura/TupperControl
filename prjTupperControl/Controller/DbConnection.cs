using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTupperControl.Controller
{
    class DbConnection
    {
        private FileConn fileConn = new FileConn();
        private String connectionString = "";
        private MySqlConnection conn;

        public MySqlConnection AbreConexao()
        {
            fileConn.OpenXml();
            connectionString = fileConn.createStringConn();
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao abrir a conexão com o banco de dados:\n" + ex.ToString(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void FechaConexao()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao fechar a conexão com o banco de dados:\n" + ex.ToString(), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        
    }
}
