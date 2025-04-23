using Microsoft.Reporting.WinForms;
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
    public partial class User_Address : UserControl
    {
        private static User_Address address;
        public int idA;
        private Classes.Config config;
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;
        private DialogResult Dr;
        public User_Address()
        {
            InitializeComponent();
        }

        public static User_Address instance
        {
            get
            {
                if(address == null)
                {
                    address = new User_Address();
                }
                return address;
            }
        }
        public void DisplayAddress(String text)
        {
            config = new Classes.Config();
            sqlcon = config.getSqlConnection();
            mycon = config.getMySqlConnection();
            String proc = "SearchAddress";
            if (config.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        tableAddress.Rows.Clear();
                        sqlcmd = new SqlCommand(proc, sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.Add(new SqlParameter("@fullname", SqlDbType.VarChar, 250)).Value = text;
                        sqlcmd.Parameters.Add(new SqlParameter("@av", SqlDbType.VarChar, 250)).Value = text;
                        sqlcmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.VarChar, 250)).Value = text;
                        sqlcmd.Parameters.Add(new SqlParameter("@com", SqlDbType.VarChar, 250)).Value = text;
                        sqlcmd.Parameters.Add(new SqlParameter("@ville", SqlDbType.VarChar, 250)).Value = text;
                        sqlcmd.Parameters.Add(new SqlParameter("@pays", SqlDbType.VarChar, 250)).Value = text;
                        SqlDataReader dataReader = sqlcmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tableAddress.Rows.Add(num, dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(6), dataReader.GetString(5), dataReader.GetString(7));
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
                        tableAddress.Rows.Clear();
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@fullname", MySqlDbType.VarChar, 250)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@av", MySqlDbType.VarChar, 250)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@qua", MySqlDbType.VarChar, 250)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@com", MySqlDbType.VarChar, 250)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@ville", MySqlDbType.VarChar, 250)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@pays", MySqlDbType.VarChar, 250)).Value = text;
                        MySqlDataReader dataReader = mycmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tableAddress.Rows.Add(num, dataReader.GetValue(0), dataReader.GetValue(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(6), dataReader.GetString(5), dataReader.GetString(7));
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

        private void User_Address_Load(object sender, EventArgs e)
        {
            DisplayAddress("");
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if(textSearch.Text == "" || textSearch.Text == "Search")
            {
                DisplayAddress("");
            }
            else
            {
                tableAddress.Rows.Clear();
                DisplayAddress(textSearch.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modals.Address.AddUpdateAddress add = new Modals.Address.AddUpdateAddress(this);
            add.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tableAddress.Rows.Count > 0)
            {
                Classes.Address.AddUpdateDeleteAddress delete = new Classes.Address.AddUpdateDeleteAddress();
                idA = Convert.ToInt32(tableAddress.CurrentRow.Cells[1].Value);
                Dr = MessageBox.Show("Do you Want to Delete this Address??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dr == DialogResult.Yes)
                {
                    delete.DeleteAddressSql(idA);
                    DisplayAddress("");
                    MessageBox.Show("Address Deleted Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if(tableAddress.Rows.Count > 0)
            {
                Modals.Address.AddUpdateAddress update = new Modals.Address.AddUpdateAddress(this);
                update.idA = Convert.ToInt32(tableAddress.CurrentRow.Cells[1].Value);
                update.idP = Convert.ToInt32(tableAddress.CurrentRow.Cells[2].Value);
                update.textfullname.Text = tableAddress.CurrentRow.Cells[3].Value.ToString();
                update.textAv.Text = tableAddress.CurrentRow.Cells[4].Value.ToString();
                update.textqua.Text = tableAddress.CurrentRow.Cells[5].Value.ToString();
                update.textTown.Text = tableAddress.CurrentRow.Cells[6].Value.ToString();
                update.textCity.Text = tableAddress.CurrentRow.Cells[7].Value.ToString();
                update.comboCountry.Text = tableAddress.CurrentRow.Cells[8].Value.ToString();

                update.textAv.ForeColor = Color.DimGray;
                update.textqua.ForeColor = Color.DimGray;
                update.textTown.ForeColor = Color.DimGray;
                update.textCity.ForeColor = Color.DimGray;
                update.comboCountry.ForeColor = Color.DimGray;

                update.titleAddress.Text = "Update Address";
                update.btsaveAddress.Text = "Update";

                update.ShowDialog();

            }
            else
            {
                MessageBox.Show("Table is Empty, Fill it before", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayAddress("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modals.RapportModal printer = new Modals.RapportModal();
            config = new Classes.Config();
            sqlcon = config.getSqlConnection();
            if (tableAddress.Rows.Count > 0)
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
                                String sql = "select * from listPersonAddress";

                                sqlcmd = new SqlCommand(sql, sqlcon);
                                SqlDataAdapter data = new SqlDataAdapter(sqlcmd);
                                DataTable tablePersonWithAddr = new DataTable();
                                data.Fill(tablePersonWithAddr);
                                var listPersonneWithAddr = tablePersonWithAddr;

                                printer.reportpreview.LocalReport.ReportEmbeddedResource = "Gestion_Personne.Rapport.RapportPersonWithAddress.rdlc";
                                printer.reportpreview.LocalReport.DataSources.Add(new ReportDataSource("PersonWithAddress", listPersonneWithAddr));
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
                MessageBox.Show("Table is Empty, fill it before", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Modals.RapportModal printer = new Modals.RapportModal();
            config = new Classes.Config();
            sqlcon = config.getSqlConnection();
            if (tableAddress.Rows.Count > 0)
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
                                String sql = "select * from listPersonWithNumberAndAddress";

                                sqlcmd = new SqlCommand(sql, sqlcon);
                                SqlDataAdapter data = new SqlDataAdapter(sqlcmd);
                                DataTable tablePersonWithNumandAddr = new DataTable();
                                data.Fill(tablePersonWithNumandAddr);
                                var listPersonneWithNumandAddr = tablePersonWithNumandAddr;

                                printer.reportpreview.LocalReport.ReportEmbeddedResource = "Gestion_Personne.Rapport.RapportPersonWithNumberAndAddress.rdlc";
                                printer.reportpreview.LocalReport.DataSources.Add(new ReportDataSource("PersonWithNumberAndAddress", listPersonneWithNumandAddr));
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
                MessageBox.Show("Table is Empty, fill it before", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
