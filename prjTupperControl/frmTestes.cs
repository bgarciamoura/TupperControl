using prjTupperControl.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prjTupperControl
{
    public partial class frmTestes : Form
    {
        private FileConn conn = new FileConn();
        private String connectionString = "";

        public frmTestes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.OpenXml();
            connectionString = "Server=" + conn.Server + ";Database=" + conn.Database + ";Uid=" + conn.User + ";Pwd=" + conn.Password + ";";
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            MySqlCommand command = sqlConnection.CreateCommand();
            try
            {
                sqlConnection.Open();
                if (sqlConnection.State == ConnectionState.Open)
                {
                    command.CommandText = "INSERT INTO `tupper`.`tb_UnidadeMedida` (`uni_Nome`, `uni_Sigla`) VALUES ('Teste', 'T');";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Conexão realizada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao se conectar ao servidor: \n" + ex.ToString(), "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }

            //MessageBox.Show(conn.Server);
            
        }
    }
}
