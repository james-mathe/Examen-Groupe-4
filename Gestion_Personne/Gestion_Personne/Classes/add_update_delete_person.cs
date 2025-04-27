using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Personne.Classes.person
{
    class  Add_update_delete_person{
        private Config db;
        private SqlConnection sqlcon;
        private SqlCommand sqlcmd;
        
        public bool addPerson(string name, string lastname, string firstname, char sex){
            sqlcon = db.getSqlConnection();
            string sql = "insert into personne(nom,postnom,prenom,sexe) values('"+name+"',"+lastname+"',"+firstname+"','"+sex+"')";
            sqlcmd = new SqlCommand(sqlcmd,sqlcon);
            if(sqlcmd.ExecuteNoQuery() > 0){
                return true;
            }
            return false;
        }
    }
}
