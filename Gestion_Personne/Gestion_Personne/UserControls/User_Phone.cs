using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Gestion_Personne.UserControls
{
    public partial class User_Phone : UserControl
    {
        private static User_Phone phone;
        public int idP;
        private Classes.Config config;
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;
        private DialogResult Dr;
        public static User_Phone instace
        {
            get
            {
                if(phone == null)
                {
                    phone = new User_Phone();
                }
                return phone;
            }
        }
        public User_Phone()
        {
            InitializeComponent();
        }

        public void DisplayPhone(String text)
        {
            config = new Classes.Config();
            sqlcon = config.getSqlConnection();
            mycon = config.getMySqlConnection();
            String proc = "SearchPhone";
            if (config.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        tablePhone.Rows.Clear();
                        sqlcmd = new SqlCommand(proc, sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@fullname", SqlDbType.VarChar, 250)).Value = text;
                        sqlcmd.Parameters.Add(new SqlParameter("@initial", SqlDbType.VarChar, 4)).Value = text;
                        sqlcmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar, 9)).Value = text;
                        SqlDataReader dataReader = sqlcmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tablePhone.Rows.Add(num, dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                                num++;
                            }
                            catch (Exception sqlEx)
                            {
                                MessageBox.Show(sqlEx.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
            }
                        dataReader.Close();
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                try
                {
                    mycon.Open();
                    if (mycon.State == ConnectionState.Open)
                    {
                        tablePhone.Rows.Clear();
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@fullname", MySqlDbType.VarChar, 250)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@initial", MySqlDbType.VarChar, 4)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@numero", MySqlDbType.VarChar, 9)).Value = text;
                        MySqlDataReader dataReader = mycmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tablePhone.Rows.Add(num, dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                                num++;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "MySql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        dataReader.Close();

                    }
                }
                catch (MySqlException myEx)
                {
                    MessageBox.Show(myEx.Message, "MySql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void textSearch_Enter(object sender, EventArgs e)
        {
            if (textSearch.Text == "Search")
            {
                textSearch.Text = "";
                textSearch.ForeColor = Color.DimGray;
            }
        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            if (textSearch.Text == "" || textSearch.Text == "Search")
            {
                textSearch.Text = "Search";
                textSearch.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void User_Phone_Load(object sender, EventArgs e)
        {
            DisplayPhone("");
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if(textSearch.Text == "" || textSearch.Text == "Search")
            {
                DisplayPhone("");
            }
            else
            {
                tablePhone.Rows.Clear();
                DisplayPhone(textSearch.Text);
            }
        }
    }
}
