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
        public MySqlConnection getMySqlConnection(string host, int port, string username, string password)
        {
            throw new NotImplementedException();
        }

        public SqlConnection getSqlConnection(string serverName, string username, string password)
        {
            return new SqlConnection("Data source=" + serverName + ";Initial catalog=g_personne;User=" + username + ";Password=" + password);
        }
    }
}
