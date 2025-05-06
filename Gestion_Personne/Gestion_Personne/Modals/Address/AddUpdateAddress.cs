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

namespace Gestion_Personne.Modals.Address
{
    public partial class AddUpdateAddress : Form
    {
        private UserControl address;
        public int idP;
        public int idA;
        private Classes.Config config;
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;
        private DialogResult Dr;
        public AddUpdateAddress(UserControl user)
        {
            InitializeComponent();
            this.address = user;
            PopulateCountryData();
            // call to fill the ComboCountry
        }

        private void PopulateCountryData()
        {
            comboCountry.Items.Add("Algérie");
            comboCountry.Items.Add("Angola");
            comboCountry.Items.Add("Bénin");
            comboCountry.Items.Add("Botswana");
            comboCountry.Items.Add("Burkina Faso");
            comboCountry.Items.Add("Burundi");
            comboCountry.Items.Add("Cabo Verde");
            comboCountry.Items.Add("Cameroun");
            comboCountry.Items.Add("République Centrafricaine");
            comboCountry.Items.Add("Tchad");
            comboCountry.Items.Add("Comores");
            comboCountry.Items.Add("République Démocratique du Congo");
            comboCountry.Items.Add("République du Congo");
            comboCountry.Items.Add("Côte d'Ivoire");
            comboCountry.Items.Add("Djibouti");
            comboCountry.Items.Add("Égypte");
            comboCountry.Items.Add("Guinée Équatoriale");
            comboCountry.Items.Add("Érythrée");
            comboCountry.Items.Add("Eswatini");
            comboCountry.Items.Add("Éthiopie");
            comboCountry.Items.Add("Gabon");
            comboCountry.Items.Add("Gambie");
            comboCountry.Items.Add("Ghana" );
            comboCountry.Items.Add("Guinée" );
            comboCountry.Items.Add("Guinée-Bissau" );
            comboCountry.Items.Add("Kenya" );
            comboCountry.Items.Add("Lesotho" );
            comboCountry.Items.Add("Libéria" );
            comboCountry.Items.Add("Libye" );
            comboCountry.Items.Add("Madagascar" );
            comboCountry.Items.Add("Malawi" );
            comboCountry.Items.Add("Mali" );
            comboCountry.Items.Add("Mauritanie" );
            comboCountry.Items.Add("Maurice" );
            comboCountry.Items.Add("Maroc" );
            comboCountry.Items.Add("Mozambique" );
            comboCountry.Items.Add("Namibie");
            comboCountry.Items.Add("Niger" );
            comboCountry.Items.Add("Nigéria" );
            comboCountry.Items.Add("Rwanda" );
            comboCountry.Items.Add("Sao Tomé-et-Principe" );
            comboCountry.Items.Add("Sénégal" );
            comboCountry.Items.Add("Seychelles" );
            comboCountry.Items.Add("Sierra Leone" );
            comboCountry.Items.Add("Somalie" );
            comboCountry.Items.Add("Afrique du Sud" );
            comboCountry.Items.Add("Soudan du Sud" );
            comboCountry.Items.Add("Soudan" );
            comboCountry.Items.Add("Tanzanie" );
            comboCountry.Items.Add("Togo" );
            comboCountry.Items.Add("Tunisie" );
            comboCountry.Items.Add("Ouganda" );
            comboCountry.Items.Add("Zambie" );
            comboCountry.Items.Add("Zimbabwe" );
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        public String isEmpty()
        {
            if(textfullname.Text == "")
            {
                return "Select a Person";
            }
            if (comboCountry.Text == "" || comboCountry.Text == "Select Country")
            {
                return "Select a Country";
            }
            if (textTown.Text == "" || textTown.Text == "Town")
            {
                return "Fill the Town Field";
            }
            if (textCity.Text == "" || textCity.Text == "City")
            {
                return "Fill the City Field";
            }
            if (textqua.Text == "" || textqua.Text == "Quarter")
            {
                return "Fill the Quarter Field";
            }
            if (textAv.Text == "" || textAv.Text == "Avenue")
            {
                return "Fill the Avenue Field";
            }
            return null;

        }
        public void DisplayPerson(String text)
        {
            config = new Classes.Config();
            sqlcon = config.getSqlConnection();
            mycon = config.getMySqlConnection();
            String proc = "SearchPerson";
            if (config.ServerType == "Sql Server")
            {
                try
                {
                    sqlcon.Open();
                    if (sqlcon.State == ConnectionState.Open)
                    {
                        tablePerson.Rows.Clear();
                        sqlcmd = new SqlCommand(proc, sqlcon);
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
                                tablePerson.Rows.Add(num, dataReader.GetValue(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3));
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
                        tablePerson.Rows.Clear();
                        mycmd = new MySqlCommand(proc, mycon);
                        mycmd.CommandType = CommandType.StoredProcedure;
                        mycmd.Parameters.Add(new MySqlParameter("@noms", MySqlDbType.VarChar, 250)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@pnom", MySqlDbType.VarChar, 250)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@prnom", MySqlDbType.VarChar, 250)).Value = text;
                        mycmd.Parameters.Add(new MySqlParameter("@sex", MySqlDbType.VarChar, 250)).Value = text;
                        MySqlDataReader dataReader = mycmd.ExecuteReader();
                        int num = 1;
                        while (dataReader.Read())
                        {
                            try
                            {
                                tablePerson.Rows.Add(num, dataReader.GetValue(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3));
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

        private void AddUpdateAddress_Load(object sender, EventArgs e)
        {
            DisplayPerson("");
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text == "" || textSearch.Text == "Search")
            {
                DisplayPerson("");
            }
            else
            {
                tablePerson.Rows.Clear();
                DisplayPerson(textSearch.Text);
            }
        }

        private void tablePerson_Click(object sender, EventArgs e)
        {
            if (tablePerson.Rows.Count > 0)
            {
                idP = Convert.ToInt32(tablePerson.CurrentRow.Cells[1].Value);
                String name = tablePerson.CurrentRow.Cells[2].Value.ToString();
                String lastname = tablePerson.CurrentRow.Cells[3].Value.ToString();
                String firstname = tablePerson.CurrentRow.Cells[4].Value.ToString();
                String fullname = name + " " + lastname + " " + firstname;
                textfullname.Text = fullname;
            }
            else
            {
                MessageBox.Show("Table is Empty, fill it before", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btsaveAddress_Click(object sender, EventArgs e)
        {
            if(isEmpty() == null)
            {
                if (titleAddress.Text == "Add Address")
                {
                    Classes.Address.AddUpdateDeleteAddress add = new Classes.Address.AddUpdateDeleteAddress();
                    if (add.addAddress(idP, textAv.Text, textqua.Text, textTown.Text, textCity.Text, comboCountry.Text) == true)
                    {
                        (address as UserControls.User_Address).DisplayAddress("");
                        MessageBox.Show("Address Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error Adding Address", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Classes.Address.AddUpdateDeleteAddress update = new Classes.Address.AddUpdateDeleteAddress();
                    DialogResult DR = MessageBox.Show("Do you Want to Update this Address??", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DR == DialogResult.Yes)
                    {
                        if (update.UpdateAddress(idA, idP, textAv.Text, textqua.Text, textTown.Text, textCity.Text, comboCountry.Text) == true)
                        {
                            (address as UserControls.User_Address).DisplayAddress("");
                            MessageBox.Show("Address Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error Updated Address", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Updated Canceled", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show(isEmpty(), "Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboCountry_Enter(object sender, EventArgs e)
        {
            if(comboCountry.Text == "Select Country")
            {
                comboCountry.Text = "";
                comboCountry.ForeColor = Color.DimGray;
            }
        }

        private void comboCountry_Leave(object sender, EventArgs e)
        {
            if(comboCountry.Text == "" || comboCountry.Text == "Select Country" || comboCountry.Text.Contains(" "))
            {
                comboCountry.Text = "Select Country";
                comboCountry.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void textCity_Enter(object sender, EventArgs e)
        {
            if (textCity.Text == "City")
            {
                textCity.Text = "";
                textCity.ForeColor = Color.DimGray;
            }
        }

        private void textCity_Leave(object sender, EventArgs e)
        {
            if (textCity.Text == "" || textCity.Text == "City" || textCity.Text.Contains(" "))
            {
                textCity.Text = "City";
                textCity.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void textTown_Enter(object sender, EventArgs e)
        {
            if (textTown.Text == "Town")
            {
                textTown.Text = "";
                textTown.ForeColor = Color.DimGray;
            }
        }

        private void textTown_Leave(object sender, EventArgs e)
        {
            if (textTown.Text == "" || textTown.Text == "Town" || textTown.Text.Contains(" "))
            {
                textTown.Text = "Town";
                textTown.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void textqua_Enter(object sender, EventArgs e)
        {
            if (textqua.Text == "Quarter")
            {
                textqua.Text = "";
                textqua.ForeColor = Color.DimGray;
            }
        }

        private void textqua_Leave(object sender, EventArgs e)
        {
            if (textqua.Text == "" || textqua.Text == "Quarter" || textqua.Text.Contains(" "))
            {
                textqua.Text = "Quarter";
                textqua.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void textAv_Enter(object sender, EventArgs e)
        {
            if (textAv.Text == "Avenue")
            {
                textAv.Text = "";
                textAv.ForeColor = Color.DimGray;
            }
        }

        private void textAv_Leave(object sender, EventArgs e)
        {
            if (textAv.Text == "" || textAv.Text == "Avenue" || textAv.Text.Contains(" "))
            {
                textAv.Text = "Avenue";
                textAv.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }
    }
}
