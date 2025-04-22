using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personne.Classes.User
{
    class AddUpdateDeleteUser
    {
        private Config db = new Config();
        private Cryptage cryptage;
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;

        public bool addUserSql(String username, String password)
        {
            bool saved = false;
            sqlcon = db.getSqlConnection();
            cryptage = new Cryptage();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String proc = "AddUser";
                    sqlcmd = new SqlCommand(proc, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar, 250)).Value = username;
                    sqlcmd.Parameters.Add(new SqlParameter("@pwd", SqlDbType.VarChar, 250)).Value = cryptage.HashPassword(password);
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
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return saved;
        }

        public bool UpdateUserSql(int id, String username, String password)
        {
            bool saved = false;
            sqlcon = db.getSqlConnection();
            cryptage = new Cryptage();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String proc = "UpdateUser";
                    sqlcmd = new SqlCommand(proc, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@id", SqlDbType.BigInt)).Value = id;
                    sqlcmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar, 250)).Value = username;
                    sqlcmd.Parameters.Add(new SqlParameter("@pwd", SqlDbType.VarChar, 250)).Value = cryptage.HashPassword(password);

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
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return saved;
        }

        public bool DeleteUserSql(int id)
        {
            bool saved = false;
            sqlcon = db.getSqlConnection();
            try
            {
                sqlcon.Open();
                if (sqlcon.State == ConnectionState.Open)
                {
                    String proc = "DeleteUser";
                    sqlcmd = new SqlCommand(proc, sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.Add(new SqlParameter("@id", SqlDbType.BigInt)).Value = id;

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
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return saved;
        }
    }
}
