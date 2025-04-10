using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Gestion_Personne.Classes.Address
{
    class AddUpdateDeleteAddress
    {
        private Config db;
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;

        public bool addAddress(int idP,String quarter,String avenue,String com,String city,String Contry)
        {
            return true;

        }
    }
}
