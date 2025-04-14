using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_Personne.Classes.People
{
    class AddUpdateDeletePerson
    {
        private Config db;
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;
        public AddUpdateDeletePerson()
        {
            db = new Config();
            sqlcon = db.getSqlConnection();
            mycon = db.getMySqlConnection();
        }

        public bool addPersonSql(String name,String lastname,String firstname,char sex)
        {
            bool saved = false;
            try
            {
                sqlcon.Open();
                if(sqlcon.State == ConnectionState.Open)
                {
                    String sql = "AddPerson";
                    sqlcmd = new SqlCommand(sql, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 250)).Value = name;
                    sqlcmd.Parameters.Add(new SqlParameter("@pnom", SqlDbType.VarChar, 250)).Value = lastname;
                    sqlcmd.Parameters.Add(new SqlParameter("@prnom", SqlDbType.VarChar, 250)).Value = firstname;
                    sqlcmd.Parameters.Add(new SqlParameter("@sex", SqlDbType.Char, 1)).Value = sex;

                    if (sqlcmd.ExecuteNonQuery() > 0)
                    {
                        saved = true;
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saved;

        }
    }
}
