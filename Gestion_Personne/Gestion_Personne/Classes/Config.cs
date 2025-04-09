using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Personne.Classes
{
    class Config : IConnection
    {
        //public MySqlConnection getMySqlConnection(string host, int portMysql,int portServ, string username, string password)
        //{
        //    return new MySqlConnection("datasource=" + host +":"+portServ+";port="+ portMysql+"; Initial catalog=g_personne;username="+username+";Password="+password);
        //}

        public MySqlConnection getMySqlConnection(string host, string username, string password)
        {
            return new MySqlConnection("Server=" + host + ";Database=g_personne;UserID=" + username + ";Password=" + password);
        }

        public SqlConnection getSqlConnection(string serverName, string username, string password)
        {
            return new SqlConnection("Data source=" + serverName + ";Initial catalog=g_personne;User=" + username + ";Password=" + password);
        }
    }
}
