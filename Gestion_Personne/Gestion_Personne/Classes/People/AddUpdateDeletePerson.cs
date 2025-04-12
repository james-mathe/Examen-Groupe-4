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
        AddUpdateDeletePerson()
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
                    String sql = "";
                    sqlcmd = new SqlCommand(sql, sqlcon);
                    sqlcmd.Parameters.AddWithValue("@", name);

                    if(sqlcmd.ExecuteNonQuery() > 0)
                    {
                        saved = true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saved;

        }
    }
}
