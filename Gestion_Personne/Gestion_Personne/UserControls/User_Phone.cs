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
using Microsoft.Reporting.WinForms;

namespace Gestion_Personne.UserControls
{
    public partial class User_Phone : UserControl
    {
        private static User_Phone phone;
        public int idT;
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
                        mycmd.Parameters.Add(new MySqlParameter("@fullnames", MySqlDbType.VarChar, 250)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@initials", MySqlDbType.VarChar, 4)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@numeros", MySqlDbType.VarChar, 9)).Value = text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Modals.Phones.AddUpdatePhone addModal = new Modals.Phones.AddUpdatePhone(this);
            addModal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tablePhone.Rows.Count > 0)
            {
                Modals.Phones.AddUpdatePhone update = new Modals.Phones.AddUpdatePhone(this);
                update.idT = Convert.ToInt32(tablePhone.CurrentRow.Cells[1].Value);
                update.idP = Convert.ToInt32(tablePhone.CurrentRow.Cells[2].Value);
                update.textfullname.Text = tablePhone.CurrentRow.Cells[3].Value.ToString();
                update.textinitial.Text = tablePhone.CurrentRow.Cells[4].Value.ToString();
                update.textnumber.Text = tablePhone.CurrentRow.Cells[5].Value.ToString();

                update.textinitial.ForeColor = Color.DimGray;
                update.textnumber.ForeColor = Color.DimGray;
                update.titlePhone.Text = "Update Number";
                update.btsavePhone.Text = "Update";
                update.ShowDialog();
            }
            else
            {
                MessageBox.Show("Table is Empty, Fill it before", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tablePhone.Rows.Count > 0)
            {
                Classes.Phones.AddUpdateDeletePhones delete = new Classes.Phones.AddUpdateDeletePhones();
                idT = Convert.ToInt32(tablePhone.CurrentRow.Cells[1].Value);
                Dr = MessageBox.Show("Do you Want to Delete this Phone Number??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {

                    delete.DeletePhone(idT);
                    DisplayPhone("");
                    MessageBox.Show("Phone Number Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete action Canceled", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Table is Empty, Fill it before", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayPhone("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modals.RapportModal printer = new Modals.RapportModal();
            config = new Classes.Config();
            sqlcon = config.getSqlConnection();
            mycon = config.getMySqlConnection();
            if (tablePhone.Rows.Count > 0)
            {
                try
                {
                    if (config.ServerType == "Sql Server")
                    {
                        sqlcon.Open();
                        try
                        {
                            if (sqlcon.State == ConnectionState.Open)
                            {
                                String sql = "select * from listTelPersonne";

                                sqlcmd = new SqlCommand(sql, sqlcon);
                                SqlDataAdapter data = new SqlDataAdapter(sqlcmd);
                                DataTable tablePersonWithNum = new DataTable();
                                data.Fill(tablePersonWithNum);
                                var listPersonneWithNum = tablePersonWithNum;

                                printer.reportpreview.LocalReport.ReportEmbeddedResource = "Gestion_Personne.Rapport.RapportPersonWithNumber.rdlc";
                                printer.reportpreview.LocalReport.DataSources.Add(new ReportDataSource("PersonWithNumber", listPersonneWithNum));
                                printer.reportpreview.RefreshReport();
                                printer.ShowDialog();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        mycon.Open();
                        try
                        {
                            if (mycon.State == ConnectionState.Open)
                            {
                                String sql = "select * from listPersonNumber";

                                mycmd = new MySqlCommand(sql, mycon);
                                MySqlDataAdapter data = new MySqlDataAdapter(mycmd);
                                DataTable tablePersonWithNum = new DataTable();
                                data.Fill(tablePersonWithNum);
                                var listPersonneWithNum = tablePersonWithNum;

                                printer.reportpreview.LocalReport.ReportEmbeddedResource = "Gestion_Personne.Rapport.RapportPersonWithNumber.rdlc";
                                printer.reportpreview.LocalReport.DataSources.Add(new ReportDataSource("PersonWithNumber", listPersonneWithNum));
                                printer.reportpreview.RefreshReport();
                                printer.ShowDialog();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Table is Empty, fill it before", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
