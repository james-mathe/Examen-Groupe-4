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
    public class AddUpdateDeletePerson
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

        public bool addPerson(String name,String lastname,String firstname,char sex)
        {
            if(db.ServerType == "Sql Server")
            {
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
                        String sql = "AddPerson";
                        mycmd = new MySqlCommand(sql, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@noms", MySqlDbType.VarChar, 250)).Value = name;
                        mycmd.Parameters.Add(new MySqlParameter("@pnom", MySqlDbType.VarChar, 250)).Value = lastname;
                        mycmd.Parameters.Add(new MySqlParameter("@prnom", MySqlDbType.VarChar, 250)).Value = firstname;
                        mycmd.Parameters.Add(new MySqlParameter("@sex", MySqlDbType.VarChar, 1)).Value = sex;

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

        public bool updatePerson(int id,String name, String lastname, String firstname, char sex)
        {
            if (db.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        String sql = "UpdatePerson";
                        sqlcmd = new SqlCommand(sql, sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@id", SqlDbType.BigInt)).Value = id;
                        sqlcmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 250)).Value = name;
                        sqlcmd.Parameters.Add(new SqlParameter("@pnom", SqlDbType.VarChar, 250)).Value = lastname;
                        sqlcmd.Parameters.Add(new SqlParameter("@prnom", SqlDbType.VarChar, 250)).Value = firstname;
                        sqlcmd.Parameters.Add(new SqlParameter("@sex", SqlDbType.Char, 1)).Value = sex;

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
                        String sql = "UpdatePerson";
                        mycmd = new MySqlCommand(sql, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)).Value = id;
                        mycmd.Parameters.Add(new MySqlParameter("@noms", MySqlDbType.VarChar, 250)).Value = name;
                        mycmd.Parameters.Add(new MySqlParameter("@pnom", MySqlDbType.VarChar, 250)).Value = lastname;
                        mycmd.Parameters.Add(new MySqlParameter("@prnom", MySqlDbType.VarChar, 250)).Value = firstname;
                        mycmd.Parameters.Add(new MySqlParameter("@sex", MySqlDbType.VarChar, 1)).Value = sex;

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

        public bool deletePerson(int id)
        {
            if (db.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        String sql = "DeletePerson";
                        sqlcmd = new SqlCommand(sql, sqlcon);
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
                        String sql = "DeletePerson";
                        mycmd = new MySqlCommand(sql, mycon);
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
        public int selectPhoneById(int idP)
        {
            int totPhone = 0;
            if (db.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        String sql = "select COUNT(idP) from telephone where idP=@idP";
                        sqlcmd = new SqlCommand(sql, sqlcon);
                        sqlcmd.Parameters.AddWithValue("@idP", idP);
                        totPhone = (int)sqlcmd.ExecuteScalar();

                        if (sqlcmd.ExecuteNonQuery() > 0)
                        {
                            return totPhone;
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
                        String sql = "select COUNT(idP) from telephone where idP=@idP";
                        mycmd = new MySqlCommand(sql, mycon);
                        mycmd.Parameters.AddWithValue("@idP", idP);
                        totPhone = (int)mycmd.ExecuteScalar();

                        if (mycmd.ExecuteNonQuery() > 0)
                        {
                            return totPhone;
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
            
            return totPhone;
        }
        public int selectAddressById(int idP)
        {
            int totaddress = 0;
            if (db.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        String sql = "select COUNT(idP) from adresse where idP=@idP";
                        sqlcmd = new SqlCommand(sql, sqlcon);
                        sqlcmd.Parameters.AddWithValue("@idP", idP);
                        totaddress = (int)sqlcmd.ExecuteScalar();

                        if (sqlcmd.ExecuteNonQuery() > 0)
                        {
                            return totaddress;
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
                        String sql = "select COUNT(idP) from adresse where idP=@idP";
                        mycmd = new MySqlCommand(sql, mycon);
                        mycmd.Parameters.AddWithValue("@idP", idP);
                        totaddress = (int)mycmd.ExecuteScalar();

                        if (mycmd.ExecuteNonQuery() > 0)
                        {
                            return totaddress;
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
            
            return totaddress;
        }
    }
}
