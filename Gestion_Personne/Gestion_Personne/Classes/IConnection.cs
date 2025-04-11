using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Gestion_Personne.Classes
{
    interface IConnection
    {
        SqlConnection getSqlConnection();
        //MySqlConnection getMySqlConnection(String host, int portMysql, int portServ, String username, String password);
        MySqlConnection getMySqlConnection();
    }
}
