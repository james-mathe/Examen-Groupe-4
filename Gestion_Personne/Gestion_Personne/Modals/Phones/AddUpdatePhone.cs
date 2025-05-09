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

namespace Gestion_Personne.Modals.Phones
{
    public partial class AddUpdatePhone : Form
    {
        private UserControl phone;
        public int idP;
        public int idT;
        private Classes.Config config;
        private SqlConnection sqlcon;
        private MySqlConnection mycon;
        private SqlCommand sqlcmd;
        private MySqlCommand mycmd;
        private DialogResult Dr;
        private Dictionary<string, string> africanCountries = new Dictionary<string, string>();
        public AddUpdatePhone(UserControl user)
        {
            InitializeComponent();
            this.phone = user;
            PopulateCountryData();
            InitializeComboBox();
        }

        private void PopulateCountryData()
        {
            africanCountries.Add("Algérie", "+213");
            africanCountries.Add("Angola", "+244");
            africanCountries.Add("Bénin", "+229");
            africanCountries.Add("Botswana", "+267");
            africanCountries.Add("Burkina Faso", "+226");
            africanCountries.Add("Burundi", "+257");
            africanCountries.Add("Cabo Verde", "+238");
            africanCountries.Add("Cameroun", "+237");
            africanCountries.Add("République Centrafricaine", "+236");
            africanCountries.Add("Tchad", "+235");
            africanCountries.Add("Comores", "+269");
            africanCountries.Add("République Démocratique du Congo", "+243"); 
            africanCountries.Add("République du Congo", "+242");
            africanCountries.Add("Côte d'Ivoire", "+225");
            africanCountries.Add("Djibouti", "+253");
            africanCountries.Add("Égypte", "+20");
            africanCountries.Add("Guinée Équatoriale", "+240");
            africanCountries.Add("Érythrée", "+291");
            africanCountries.Add("Eswatini", "+268");
            africanCountries.Add("Éthiopie", "+251");
            africanCountries.Add("Gabon", "+241");
            africanCountries.Add("Gambie", "+220");
            africanCountries.Add("Ghana", "+233");
            africanCountries.Add("Guinée", "+224");
            africanCountries.Add("Guinée-Bissau", "+245");
            africanCountries.Add("Kenya", "+254");
            africanCountries.Add("Lesotho", "+266");
            africanCountries.Add("Libéria", "+231");
            africanCountries.Add("Libye", "+218");
            africanCountries.Add("Madagascar", "+261");
            africanCountries.Add("Malawi", "+265");
            africanCountries.Add("Mali", "+223");
            africanCountries.Add("Mauritanie", "+222");
            africanCountries.Add("Maurice", "+230");
            africanCountries.Add("Maroc", "+212");
            africanCountries.Add("Mozambique", "+258");
            africanCountries.Add("Namibie", "+264");
            africanCountries.Add("Niger", "+227");
            africanCountries.Add("Nigéria", "+234");
            africanCountries.Add("Rwanda", "+250");
            africanCountries.Add("Sao Tomé-et-Principe", "+239");
            africanCountries.Add("Sénégal", "+221");
            africanCountries.Add("Seychelles", "+248");
            africanCountries.Add("Sierra Leone", "+232");
            africanCountries.Add("Somalie", "+252");
            africanCountries.Add("Afrique du Sud", "+27");
            africanCountries.Add("Soudan du Sud", "+211");
            africanCountries.Add("Soudan", "+249");
            africanCountries.Add("Tanzanie", "+255");
            africanCountries.Add("Togo", "+228");
            africanCountries.Add("Tunisie", "+216");
            africanCountries.Add("Ouganda", "+256");
            africanCountries.Add("Zambie", "+260");
            africanCountries.Add("Zimbabwe", "+263");
        }

        private void InitializeComboBox()
        {
            comboCountry.Items.Clear();

            foreach (string countryName in africanCountries.Keys.OrderBy(name => name))
            {
                comboCountry.Items.Add(countryName);
            }

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

        public String isEmpty()
        {
            if(textfullname.Text == "")
            {
                return "Select the person!!";
            }
            if(textinitial.Text == "")
            {
                return "Select the Country!!";
            }
            if(textnumber.Text == "" || textnumber.Text == "9xx")
            {
                return "Fill The Number Field!!";
            }
            if(textnumber.TextLength < 9)
            {
                return "Phone Number must have 9 Characters";
            }
            return null;
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
            if (textSearch.Text == "" || textSearch.Text == "Search" || textSearch.Text.Contains(" "))
            {
                textSearch.Text = "Search";
                textSearch.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void tablePerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddUpdatePhone_Load(object sender, EventArgs e)
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
                if (config.ServerType == "Sql Server")
                {
                    DisplayPerson(textSearch.Text);

                }
            }
        }

        private void tablePerson_Click(object sender, EventArgs e)
        {
            if(tablePerson.Rows.Count > 0)
            {
                idP = Convert.ToInt32(tablePerson.CurrentRow.Cells[1].Value);
                String name = tablePerson.CurrentRow.Cells[2].Value.ToString();
                String lastname = tablePerson.CurrentRow.Cells[3].Value.ToString();
                String firstname = tablePerson.CurrentRow.Cells[4].Value.ToString();
                String fullname = name+" "+lastname+" "+firstname;
                textfullname.Text = fullname;
            }
            else
            {
                MessageBox.Show("Table is Empty, fill it before", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textnumber_Enter(object sender, EventArgs e)
        {
            if(textnumber.Text == "9xx")
            {
                textnumber.Text = "";
                textnumber.ForeColor = Color.DimGray;
            }
        }

        private void textnumber_Leave(object sender, EventArgs e)
        {
            if(textnumber.Text == "" || textnumber.Text == "9xx" || textnumber.Text.Contains(" "))
            {
                textnumber.Text = "9xx";
                textnumber.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void btsavePerson_Click(object sender, EventArgs e)
        {
            if(isEmpty() == null)
            {
                if (titlePhone.Text == "Add Number")
                {
                    Classes.Phones.AddUpdateDeletePhones add = new Classes.Phones.AddUpdateDeletePhones();
                    if (add.addPhone(idP, textinitial.Text, textnumber.Text) == true)
                    {
                        (phone as UserControls.User_Phone).DisplayPhone("");
                        MessageBox.Show("Phone Number Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error Adding Phone Number", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Classes.Phones.AddUpdateDeletePhones update = new Classes.Phones.AddUpdateDeletePhones();
                    Dr = MessageBox.Show("Do you Want to Update this Phone Number??", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dr == DialogResult.Yes)
                    {
                        if (update.UpdatePhone(idT, idP, textinitial.Text, textnumber.Text) == true)
                        {
                            (phone as UserControls.User_Phone).DisplayPhone("");
                            MessageBox.Show("Phone Number Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error Updated Phone Number", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void textnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar > 47 && e.KeyChar < 58 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void comboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = comboCountry.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedCountry))
            {
                if (africanCountries.TryGetValue(selectedCountry, out string countryCode))
                {
                    textinitial.Text = countryCode;
                }
                else
                {
                    comboCountry.Text = "Select Country";
                    comboCountry.ForeColor = Color.FromArgb(198, 190, 255);
                }
            }
            else
            {
                comboCountry.Text = "Select Country";
                comboCountry.ForeColor = Color.FromArgb(198, 190, 255);
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
            if(comboCountry.Text == "" || comboCountry.Text == "Select Country")
            {
                comboCountry.Text = "Select Country";
                comboCountry.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }
    }
}
