using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Gestion_Personne.Classes.Phones
{
    public class AddUpdateDeletePhones
    {   
        private Config db = new Config();
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;

        public AddUpdateDeletePhones()
        {
            db = new Config();
            sqlcon = db.getSqlConnection();
            mycon = db.getMySqlConnection();
        }

        public bool addPhone(int idP,String initial,String num)
        {
            
            if(db.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        String proc = "AddPhone";
                        sqlcmd = new SqlCommand(proc, sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@idP", SqlDbType.BigInt)).Value = idP;
                        sqlcmd.Parameters.Add(new SqlParameter("@initial", SqlDbType.VarChar, 4)).Value = initial;
                        sqlcmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar, 9)).Value = num;

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
                        String proc = "AddPhone";
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@idPs", MySqlDbType.Int32)).Value = idP;
                        mycmd.Parameters.Add(new MySqlParameter("@initials", MySqlDbType.VarChar, 4)).Value = initial;
                        mycmd.Parameters.Add(new MySqlParameter("@numeros", MySqlDbType.VarChar, 9)).Value = num;

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

        public bool UpdatePhone(int id,int idP, String initial, String num)
        {
            if (db.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        String proc = "UpdatePhone";
                        sqlcmd = new SqlCommand(proc, sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@idT", SqlDbType.BigInt)).Value = id;
                        sqlcmd.Parameters.Add(new SqlParameter("@idP", SqlDbType.BigInt)).Value = idP;
                        sqlcmd.Parameters.Add(new SqlParameter("@initial", SqlDbType.VarChar, 4)).Value = initial;
                        sqlcmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar, 9)).Value = num;

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
                        String proc = "UpdatePhone";
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = id;
                        mycmd.Parameters.Add(new MySqlParameter("@idPs", MySqlDbType.Int32)).Value = idP;
                        mycmd.Parameters.Add(new MySqlParameter("@initials", MySqlDbType.VarChar, 4)).Value = initial;
                        mycmd.Parameters.Add(new MySqlParameter("@numeros", MySqlDbType.VarChar, 9)).Value = num;

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

        public bool DeletePhone(int id)
        {
            if (db.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        String proc = "DeletePhone";
                        sqlcmd = new SqlCommand(proc, sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@idT", SqlDbType.BigInt)).Value = id;

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
                        String proc = "DeletePhone";
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
    }
}
