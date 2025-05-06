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
    public class AddUpdateDeleteUser
    {
        private Config db = new Config();
        private Cryptage cryptage;
        private SqlConnection sqlcon;
        private SqlCommand sqlcmd;
        private MySqlConnection mycon;
        private MySqlCommand mycmd;

        public bool addUser(String username, String password)
        {
            sqlcon = db.getSqlConnection();
            mycon = db.getMySqlConnection();
            cryptage = new Cryptage();
            if (db.ServerType == "Sql Server")
            {
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
                            return true;
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

            }
            else
            {

                try
                {
                    mycon.Open();
                    if (mycon.State == ConnectionState.Open)
                    {
                        String proc = "AddUser";
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@usernames", MySqlDbType.VarChar, 250)).Value = username;
                        mycmd.Parameters.Add(new MySqlParameter("@pwds", MySqlDbType.VarChar, 250)).Value = cryptage.HashPassword(password);
                        if (mycmd.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "MySql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (mycon.State == ConnectionState.Open)
                    {
                        mycon.Close();
                    }
                }
            }
            return false;
        }

        public bool UpdateUser(int id, String username, String password)
        {
            sqlcon = db.getSqlConnection();
            mycon = db.getMySqlConnection();
            cryptage = new Cryptage();
            if(db.ServerType == "Sql Server")
            {
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
                            return true;
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

            }
            else
            {
                try
                {
                    mycon.Open();
                    if (mycon.State == ConnectionState.Open)
                    {
                        String proc = "UpdateUser";
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = id;
                        mycmd.Parameters.Add(new MySqlParameter("@usernames", MySqlDbType.VarChar, 250)).Value = username;
                        mycmd.Parameters.Add(new MySqlParameter("@pwds", MySqlDbType.VarChar, 250)).Value = cryptage.HashPassword(password);

                        if (mycmd.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "MySql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (mycon.State == ConnectionState.Open)
                    {
                        mycon.Close();
                    }
                }
            }
            return false;
        }

        public bool DeleteUser(int id)
        {
            sqlcon = db.getSqlConnection();
            mycon = db.getMySqlConnection();
            if(db.ServerType == "Server Type")
            {
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
                            return true;
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

            }
            else
            {
                try
                {
                    mycon.Open();
                    if (mycon.State == ConnectionState.Open)
                    {
                        String proc = "DeleteUser";
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = id;

                        if (mycmd.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "MySql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (mycon.State == ConnectionState.Open)
                    {
                        mycon.Close();
                    }
                }
            }
            return false;
        }

        public bool addUserMySql(String username, String password)
        {
            mycon = db.getMySqlConnection();
            cryptage = new Cryptage();
            try
            {
                mycon.Open();
                if (mycon.State == ConnectionState.Open)
                {
                    String proc = "AddUser";
                    mycmd = new MySqlCommand(proc, mycon);
                    mycmd.CommandType = CommandType.StoredProcedure;
                    mycmd.Parameters.Add(new MySqlParameter("@usernames", MySqlDbType.VarChar, 250)).Value = username;
                    mycmd.Parameters.Add(new MySqlParameter("@pwds", MySqlDbType.VarChar, 250)).Value = cryptage.HashPassword(password);
                    if (mycmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "MySql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mycon.State == ConnectionState.Open)
                {
                    mycon.Close();
                }
            }
            return false;
        }

        public bool UpdateUserMySql(int id, String username, String password)
        {
            bool saved = false;
            mycon = db.getMySqlConnection();
            cryptage = new Cryptage();
            try
            {
                mycon.Open();
                if (mycon.State == ConnectionState.Open)
                {
                    String proc = "UpdateUser";
                    mycmd = new MySqlCommand(proc, mycon);
                    mycmd.CommandType = CommandType.StoredProcedure;
                    mycmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = id;
                    mycmd.Parameters.Add(new MySqlParameter("@usernames", MySqlDbType.VarChar, 250)).Value = username;
                    mycmd.Parameters.Add(new MySqlParameter("@pwds", MySqlDbType.VarChar, 250)).Value = cryptage.HashPassword(password);

                    if (mycmd.ExecuteNonQuery() > 0)
                    {
                        saved = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "MySql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mycon.State == ConnectionState.Open)
                {
                    mycon.Close();
                }
            }
            return saved;
        }

        public bool DeleteUserMySql(int id)
        {
            bool saved = false;
            mycon = db.getMySqlConnection();
            try
            {
                mycon.Open();
                if (mycon.State == ConnectionState.Open)
                {
                    String proc = "DeleteUser";
                    mycmd = new MySqlCommand(proc, mycon);
                    mycmd.CommandType = CommandType.StoredProcedure;
                    mycmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = id;

                    if (mycmd.ExecuteNonQuery() > 0)
                    {
                        saved = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "MySql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (mycon.State == ConnectionState.Open)
                {
                    mycon.Close();
                }
            }
            return saved;
        }
    }
}
