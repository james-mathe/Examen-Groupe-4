using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gestion_Personne.Classes
{
    interface IConnection
    {
        SqlConnection getSqlConnection(String serverName, String username, String password);
    }
}
