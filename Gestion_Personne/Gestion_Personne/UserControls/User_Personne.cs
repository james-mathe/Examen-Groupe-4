using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Personne.Modals.people;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Gestion_Personne.UserControls
{
    public partial class User_Personne : UserControl
    {
        private static User_Personne person;
        public int idP;
        private Classes.Config config;
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;
        private DialogResult Dr;

        public static User_Personne instance
        {
            get
            {
                if(person == null)
                {
                    person = new User_Personne();
                }
                return person;
            }
        }
        public User_Personne()
        {
            InitializeComponent();
        }

        public void DisplayPerson(String text)
        {
            config = new Classes.Config();
            sqlcon = config.getSqlConnection();
            mycon = config.getMySqlConnection();
            String proc = "SearchPerson";
            String sql = "Select * from personne where nom like '%'+@nom+'%' or postnom like '%'+@pnom+'%' or prenom like '%'+@prnom+'%' or sexe like '%'+@sex+'%'";
            if (config.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        tablePerson.Rows.Clear();
                        sqlcmd = new SqlCommand(proc, sqlcon);
                        //sqlcmd.Parameters.AddWithValue("@nom", text);
                        //sqlcmd.Parameters.AddWithValue("@pnom", text);
                        //sqlcmd.Parameters.AddWithValue("@prnom", text);
                        //sqlcmd.Parameters.AddWithValue("@sex", text);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@nom", SqlDbType.VarChar, 250)).Value = text;
                        sqlcmd.Parameters.Add(new SqlParameter("@pnom", SqlDbType.VarChar, 250)).Value = text;
                        sqlcmd.Parameters.Add(new SqlParameter("@prnom", SqlDbType.VarChar, 250)).Value = text;
                        sqlcmd.Parameters.Add(new SqlParameter("@sex", SqlDbType.VarChar, 250)).Value = text;
                        SqlDataReader dataReader = sqlcmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tablePerson.Rows.Add(num, dataReader.GetValue(0), dataReader.GetString(3), dataReader.GetString(2), dataReader.GetString(1), dataReader.GetString(4));
                                num++;
                            }
                            catch(Exception sqlEx)
                            {
                                MessageBox.Show(sqlEx.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        dataReader.Close();
                    }
                }
                catch(SqlException sqlEx)
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
                        tablePerson.Rows.Clear();
                        mycmd = new MySqlCommand(sql, mycon);
                        MySqlDataReader dataReader = mycmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tablePerson.Rows.Add(num, dataReader.GetValue(0), dataReader.GetString(3), dataReader.GetString(2), dataReader.GetString(1), dataReader.GetString(4));
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
            if(textSearch.Text == "Search")
            {
                textSearch.Text = "";
                textSearch.ForeColor = Color.DimGray;
            }
        }

        private void textSearch_Leave(object sender, EventArgs e)
        {
            if(textSearch.Text == "" || textSearch.Text == "Search")
            {
                textSearch.Text = "Search";
                textSearch.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void User_personne_Load(object sender, EventArgs e)
        {
            DisplayPerson("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUpdatePerson addPerson = new AddUpdatePerson(this);
            addPerson.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tablePerson.Rows.Count > 0)
            {
                AddUpdatePerson updatePerson = new AddUpdatePerson(this);
                updatePerson.idP = Convert.ToInt32(tablePerson.CurrentRow.Cells[1].Value);
                updatePerson.textname.Text = tablePerson.CurrentRow.Cells[4].Value.ToString();
                updatePerson.textLastname.Text = tablePerson.CurrentRow.Cells[3].Value.ToString();
                updatePerson.textFirstname.Text = tablePerson.CurrentRow.Cells[2].Value.ToString();
                updatePerson.comboGender.Text = tablePerson.CurrentRow.Cells[5].Value.ToString();

                updatePerson.textname.ForeColor = Color.DimGray;
                updatePerson.textLastname.ForeColor = Color.DimGray;
                updatePerson.textFirstname.ForeColor = Color.DimGray;
                updatePerson.comboGender.ForeColor = Color.DimGray;

                updatePerson.titlePerson.Text = "Update Person";
                updatePerson.titlePerson.Location = new Point(59, 13); 
                updatePerson.btsavePerson.Text = "Update";
                updatePerson.ShowDialog();
            }
            else
            {
                MessageBox.Show("Table is Empty fill it before", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tablePerson.Rows.Count > 0)
            {
                
                idP = Convert.ToInt32(tablePerson.CurrentRow.Cells[1].Value);
                Classes.People.AddUpdateDeletePerson sqldelete = new Classes.People.AddUpdateDeletePerson();
                int numtel = sqldelete.selectPhoneByIdsql(1);
                int numaddres = sqldelete.selectAddressByIdsql(1);
                if(numtel > 0 && numaddres == 0)
                {
                    Dr = MessageBox.Show("This Persone has " + numtel + " phone number. Do you still Want to Delete this Person??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqldelete.deletePersonSql(idP);
                        DisplayPerson("");
                        MessageBox.Show("Person and phone number Deleted Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete action Canceled", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if(numtel == 0 && numaddres > 0)
                {
                    Dr = MessageBox.Show("This Persone has " + numaddres + " Address. Do you still Want to Delete this Person??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqldelete.deletePersonSql(idP);
                        DisplayPerson("");
                        MessageBox.Show("Person and Address Deleted Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete action Canceled", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    Dr = MessageBox.Show("Do you Want to Delete this Person??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        sqldelete.deletePersonSql(idP);
                        DisplayPerson("");
                        MessageBox.Show("Person Deleted Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Delete action Canceled", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            else
            {
                MessageBox.Show("Table is Empty, fill it before", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tablePerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            SqlDataReader dataReader;
            if (textSearch.Text == "" || textSearch.Text == "Search")
            {
                DisplayPerson("");
            }
            else
            {
                tablePerson.Rows.Clear();
                if (config.ServerType == "Sql Server")
                {
                    DisplayPerson(textSearch.Text);

                }
            }
        }
    }
}
