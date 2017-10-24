using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            connectionString = "Server=" + fileConn.Server + ";Database=" + fileConn.Database + ";Uid=" + fileConn.User + ";Pwd=" + fileConn.Password + ";";
            conn = new MySqlConnection(connectionString);
            return conn;
        }
        
    }
}
