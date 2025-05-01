using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personne.UserControls
{
    public partial class User_User : UserControl
    {
        private static User_User user;
        public int idU;
        private Classes.Config config;
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;
        private Classes.Cryptage cryptage;
        private DialogResult Dr;

        public static User_User instance
        {
            get
            {
                if(user == null)
                {
                    user = new User_User();
                }
                return user;
            }
        }
        public User_User()
        {
            InitializeComponent();
        }

        public void DisplayUser(String text)
        {
            config = new Classes.Config();
            sqlcon = config.getSqlConnection();
            mycon = config.getMySqlConnection();
            String proc = "SearchUser";
            if (config.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        tableUser.Rows.Clear();
                        sqlcmd = new SqlCommand(proc, sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar, 250)).Value = text;
                        SqlDataReader dataReader = sqlcmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tableUser.Rows.Add(num, dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetString(2));
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
                        tableUser.Rows.Clear();
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@username", MySqlDbType.VarChar, 250)).Value = text;
                        MySqlDataReader dataReader = mycmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tableUser.Rows.Add(num, dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetString(2));
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
        private void User_User_Load(object sender, EventArgs e)
        {
            DisplayUser("");
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

        private void button1_Click(object sender, EventArgs e)
        {
            Modals.Users.AddUpdateUser addModal = new Modals.Users.AddUpdateUser(this);
            addModal.ShowDialog();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if(textSearch.Text == "" || textSearch.Text == "Search")
            {
                DisplayUser("");
            }
            else
            {
                tableUser.Rows.Clear();
                DisplayUser(textSearch.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tableUser.Rows.Count > 0)
            {
                cryptage = new Classes.Cryptage();
                Modals.Users.AddUpdateUser updateModal = new Modals.Users.AddUpdateUser(this);
                updateModal.idU = Convert.ToInt32(tableUser.CurrentRow.Cells[1].Value);
                updateModal.textUser.Text = tableUser.CurrentRow.Cells[2].Value.ToString();
                updateModal.textPass.Text = cryptage.DecryptData(tableUser.CurrentRow.Cells[3].Value.ToString());
                updateModal.textPass.UseSystemPasswordChar = false;
                updateModal.eyes.Image = Properties.Resources.icons8_hide_24px;

                updateModal.titleUser.Text = "Update User";
                updateModal.titleUser.Location = new Point();
                updateModal.btsaveUser.Text = "Update";
                updateModal.textUser.ForeColor = Color.DimGray;
                updateModal.textPass.ForeColor = Color.DimGray;
                updateModal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Table is Empty, Fill it before", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tableUser.Rows.Count > 0)
            {
                if(tableUser.Rows.Count == 1)
                {
                    MessageBox.Show("You Can't Delete All the User Because you Need at least one User to Log in", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Classes.User.AddUpdateDeleteUser delete = new Classes.User.AddUpdateDeleteUser();
                    idU = Convert.ToInt32(tableUser.CurrentRow.Cells[1].Value);
                    Dr = MessageBox.Show("Do you Want to Delete this User??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        delete.DeleteUserSql(idU);
                        DisplayUser("");
                        MessageBox.Show("User Deleted Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete action Canceled", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Table is Empty, Fill it before", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
