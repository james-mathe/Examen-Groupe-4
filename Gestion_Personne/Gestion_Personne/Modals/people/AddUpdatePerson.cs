using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Gestion_Personne.Modals.people
{
    public partial class AddUpdatePerson : Form
    {
        private UserControl person;
        public int idP;
        private Classes.Config config;
        public AddUpdatePerson(UserControl p)
        {
            InitializeComponent();
            this.person = p;
        }

        private void textname_Enter(object sender, EventArgs e)
        {
            if(textname.Text == "name")
            {
                textname.Text = "";
                textname.ForeColor = Color.DimGray;
            }
        }

        public String isEmpty()
        {
            if(textname.Text == "" || textname.Text == "name")
            {
                return "Fill the Name Field";
            }
            if (textLastname.Text == "" || textLastname.Text == "lastname")
            {
                return "Fill the lastname Field";
            }
            if (textFirstname.Text == "" || textFirstname.Text == "firstname")
            {
                return "Fill the firstname Field";
            }
            if (comboGender.Text == "" || comboGender.Text == "select gender")
            {
                return "Fill the Name Field";
            }
            return null;
        }

        private void textname_Leave(object sender, EventArgs e)
        {
            if(textname.Text == "" || textname.Text == "name")
            {
                textname.Text = "name";
                textname.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void textLastname_Enter(object sender, EventArgs e)
        {
            if (textLastname.Text == "lastname")
            {
                textLastname.Text = "";
                textLastname.ForeColor = Color.DimGray;
            }
        }

        private void textLastname_Leave(object sender, EventArgs e)
        {
            if (textLastname.Text == "" || textLastname.Text == "lastname")
            {
                textLastname.Text = "lastname";
                textLastname.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void textFirstname_Enter(object sender, EventArgs e)
        {
            if (textFirstname.Text == "firstname")
            {
                textFirstname.Text = "";
                textFirstname.ForeColor = Color.DimGray;
            }
        }

        private void textFirstname_Leave(object sender, EventArgs e)
        {
            if (textFirstname.Text == "" || textFirstname.Text == "firstname")
            {
                textFirstname.Text = "firstname";
                textFirstname.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void comboGender_Enter(object sender, EventArgs e)
        {
            if (comboGender.Text == "select gender")
            {
                comboGender.Text = "";
                comboGender.ForeColor = Color.DimGray;
            }
        }

        private void comboGender_Leave(object sender, EventArgs e)
        {
            if (comboGender.Text == "" || comboGender.Text == "select gender")
            {
                comboGender.Text = "select gender";
                comboGender.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void AddUpdatePerson_Load(object sender, EventArgs e)
        {

        }

        private void btsavePerson_Click(object sender, EventArgs e)
        {
            config = new Classes.Config();
            SqlConnection sqlcon = config.getSqlConnection();
            if (isEmpty() != null)
            {
                MessageBox.Show(isEmpty(), "Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(config.ServerType == "Sql Server")
                {
                    try
                    {
                        sqlcon.Open();
                        if(sqlcon.State == ConnectionState.Open)
                        {
                            if (titlePerson.Text == "Add Person")
                            {
                                Classes.People.AddUpdateDeletePerson sqladd = new Classes.People.AddUpdateDeletePerson();
                                if(sqladd.addPersonSql(textname.Text,textLastname.Text,textFirstname.Text,Convert.ToChar(comboGender.Text)) == true)
                                {
                                    (person as UserControls.User_Personne).DisplayPerson("");
                                    MessageBox.Show("Person Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error Adding Person", "Add", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                Classes.People.AddUpdateDeletePerson sqlupdate = new Classes.People.AddUpdateDeletePerson();
                                DialogResult DR = MessageBox.Show("Do you Want to Update this Person??", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (DR == DialogResult.Yes)
                                {
                                    if(sqlupdate.updatePersonSql(idP, textname.Text, textLastname.Text, textFirstname.Text, Convert.ToChar(comboGender.Text)) == true)
                                    {
                                        (person as UserControls.User_Personne).DisplayPerson("");
                                        MessageBox.Show("Person Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error Updated Person", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        this.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Updated Canceled", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Sql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {

                }
                
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
