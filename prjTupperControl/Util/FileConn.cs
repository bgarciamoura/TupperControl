using prjTupperControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace prjTupperControl.Controller
{
    class FileConn
    {
            private String server;
            private String database;
            private String user;
            private String password;

            public FileConn()
            {
            }

            public FileConn(string password, string user, string database, string server)
            {
                Password = password;
                User = user;
                Database = database;
                Server = server;
            }

            public String Password
            {
                get { return password; }
                set { password = value; }
            }

            public String User
            {
                get { return user; }
                set { user = value; }
            }

            public String Database
            {
                get { return database; }
                set { database = value; }
            }

            public String Server
            {
                get { return server; }
                set { server = value; }
            }
        
        
        /*public void CriarXML()
        {
            String Server   = "localhost";
            String Database = "tupper";
            String User  = "root";
            String Password = "J4queline@";
            String Schema   = "tupper";

            XmlTextWriter writer = new XmlTextWriter(@"C:\temp\temp.xml", null);//Encoding.GetEncoding("iso-8859-1"));

            writer.WriteStartDocument();

            writer.Formatting = Formatting.Indented;
            writer.WriteComment("Conexão com Banco de Dados.");
            writer.WriteStartElement("Conexao");

            //Criptografa os dados
            var SchemaBytes = System.Text.Encoding.UTF8.GetBytes(Schema);
            var ServerBytes = System.Text.Encoding.UTF8.GetBytes(Server);
            var DatabaseBytes = System.Text.Encoding.UTF8.GetBytes(Database);
            var UserBytes = System.Text.Encoding.UTF8.GetBytes(User);
            var PasswordBytes = System.Text.Encoding.UTF8.GetBytes(Password);


            writer.WriteElementString("Schema", Convert.ToBase64String(SchemaBytes));
            writer.WriteElementString("Server", Convert.ToBase64String(ServerBytes));
            writer.WriteElementString("Database", Convert.ToBase64String(DatabaseBytes));
            writer.WriteElementString("User", Convert.ToBase64String(UserBytes));
            writer.WriteElementString("Password", Convert.ToBase64String(PasswordBytes));

            writer.WriteEndElement();
            writer.Close();

        }*/

        public void OpenXml()
        {
            XmlDocument document = new XmlDocument();
            string path = @"c:\temp\temp.xml";
            document.Load(path);
            Server = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(document.SelectSingleNode("Conexao").ChildNodes[0].InnerText));
            Database = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(document.SelectSingleNode("Conexao").ChildNodes[1].InnerText));
            User = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(document.SelectSingleNode("Conexao").ChildNodes[2].InnerText));
            Password = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(document.SelectSingleNode("Conexao").ChildNodes[3].InnerText));
        }

        public String createStringConn()
        {
            String conn = "Server={0};Database={1};Uid={2};Pwd={3}";
            conn = String.Format(conn, new object[] { Server, Database, User, Password });
            return conn;
        }
    }
}
