using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Gestion_Personne.Classes.Address
{
    public class AddUpdateDeleteAddress
    {
        private Config db = new Config();
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;

        public AddUpdateDeleteAddress()
        {
            db = new Config();
            sqlcon = db.getSqlConnection();
            mycon = db.getMySqlConnection();
        }
        public bool addAddress(int idP, String Av, String Qua, String com, String ville, String pays)
        {
            
            if(db.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        String proc = "AddAddress";
                        sqlcmd = new SqlCommand(proc, sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@idP", SqlDbType.BigInt)).Value = idP;
                        sqlcmd.Parameters.Add(new SqlParameter("@av", SqlDbType.VarChar, 250)).Value = Av;
                        sqlcmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.VarChar, 250)).Value = Qua;
                        sqlcmd.Parameters.Add(new SqlParameter("@com", SqlDbType.VarChar, 250)).Value = com;
                        sqlcmd.Parameters.Add(new SqlParameter("@ville", SqlDbType.VarChar, 250)).Value = ville;
                        sqlcmd.Parameters.Add(new SqlParameter("@pays", SqlDbType.VarChar, 250)).Value = pays;

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
                        String proc = "AddAddress";
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@idPs", MySqlDbType.Int32)).Value = idP;
                        mycmd.Parameters.Add(new MySqlParameter("@av", MySqlDbType.VarChar, 250)).Value = Av;
                        mycmd.Parameters.Add(new MySqlParameter("@qua", MySqlDbType.VarChar, 250)).Value = Qua;
                        mycmd.Parameters.Add(new MySqlParameter("@com", MySqlDbType.VarChar, 250)).Value = com;
                        mycmd.Parameters.Add(new MySqlParameter("@villes", MySqlDbType.VarChar, 250)).Value = ville;
                        mycmd.Parameters.Add(new MySqlParameter("@payss", MySqlDbType.VarChar, 250)).Value = pays;

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

        public bool UpdateAddress(int id, int idP, String Av, String Qua, String com, String ville, String pays)
        {

            if (db.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        String proc = "UpdateAddress";
                        sqlcmd = new SqlCommand(proc, sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@idA", SqlDbType.BigInt)).Value = id;
                        sqlcmd.Parameters.Add(new SqlParameter("@idP", SqlDbType.BigInt)).Value = idP;
                        sqlcmd.Parameters.Add(new SqlParameter("@av", SqlDbType.VarChar, 250)).Value = Av;
                        sqlcmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.VarChar, 250)).Value = Qua;
                        sqlcmd.Parameters.Add(new SqlParameter("@com", SqlDbType.VarChar, 250)).Value = com;
                        sqlcmd.Parameters.Add(new SqlParameter("@ville", SqlDbType.VarChar, 250)).Value = ville;
                        sqlcmd.Parameters.Add(new SqlParameter("@pays", SqlDbType.VarChar, 250)).Value = pays;

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
                        String proc = "UpdateAddress";
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = id;
                        mycmd.Parameters.Add(new MySqlParameter("@idPs", MySqlDbType.Int32)).Value = idP;
                        mycmd.Parameters.Add(new MySqlParameter("@av", MySqlDbType.VarChar, 250)).Value = Av;
                        mycmd.Parameters.Add(new MySqlParameter("@qua", MySqlDbType.VarChar, 250)).Value = Qua;
                        mycmd.Parameters.Add(new MySqlParameter("@com", MySqlDbType.VarChar, 250)).Value = com;
                        mycmd.Parameters.Add(new MySqlParameter("@villes", MySqlDbType.VarChar, 250)).Value = ville;
                        mycmd.Parameters.Add(new MySqlParameter("@payss", MySqlDbType.VarChar, 250)).Value = pays;

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

        public bool DeleteAddress(int id)
        {

            if (db.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        String proc = "DeleteAddress";
                        sqlcmd = new SqlCommand(proc, sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@idA", SqlDbType.BigInt)).Value = id;

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
                        String proc = "DeleteAddress";
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
