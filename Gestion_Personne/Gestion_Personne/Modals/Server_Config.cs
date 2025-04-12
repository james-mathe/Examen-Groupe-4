using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Personne.Classes;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;

namespace Gestion_Personne.Modals
{
    public partial class Server_Config : Form
    {
        private readonly string configFilePath = Application.StartupPath + @"\config.ini";
        private Form menu;
        private Config config;
        public Server_Config(Form m)
        {
            InitializeComponent();
            this.menu = m;
        }

        private void SaveConnectionInfo()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(configFilePath))
                {
                    writer.WriteLine(comboDatabase.Text);
                    writer.WriteLine(textServ.Text);
                    //writer.WriteLine(txtbd.Text);
                    writer.WriteLine(textUser.Text);
                    writer.WriteLine(textPass.Text); // Crypter le mot de passe
                }
                MessageBox.Show("Server Config saved Successfully", "Save Config", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement de la configuration : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String IsEmpty()
        {
            if(comboDatabase.Text == "" || comboDatabase.Text == "select database")
            {
                return "Fill the database field";
            }
            if (textServ.Text == "" || textServ.Text == "server name")
            {
                return "Fill the Server name field";
            }
            if (textUser.Text == "" || textUser.Text == "username")
            {
                return "Fill the username field";
            }
            if (textPass.Text == "password")
            {
                return "Fill the password field";
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(IsEmpty() != null)
            {
                MessageBox.Show(IsEmpty(), "Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaveConnectionInfo();
                this.config = new Config();
                if (config.ServerType == "Sql Server")
                {
                    this.Dispose();
                    SqlConnection sqlcon = config.getSqlConnection();
                    try
                    {
                        sqlcon.Open();
                        if (sqlcon.State == ConnectionState.Open)
                        {
                            
                            MessageBox.Show("Connected Successfully to Sql Server", "Sql Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            Auth auth = new Auth(menu);
                            auth.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Sql server Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        if (sqlcon.State == ConnectionState.Open)
                        {
                            sqlcon.Close();
                        }
                    }

                }
                else if (config.ServerType == "Mysql")
                {
                    this.Dispose();
                    MySqlConnection mycon = config.getMySqlConnection();
                    try
                    {
                        mycon.Open();
                        if (mycon.State == ConnectionState.Open)
                        {

                            MessageBox.Show("Connected Successfully to Mysql", "Mysql Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Auth auth = new Auth(menu);
                            auth.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Mysql Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        if (mycon.State == ConnectionState.Open)
                        {
                            mycon.Close();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Select the valide Server", "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            textPass.UseSystemPasswordChar = false;
        }

        private void textServ_Enter(object sender, EventArgs e)
        {
            if(textServ.Text == "server name")
            {
                textServ.Text = "";
                textServ.ForeColor = Color.DimGray;
            }
        }

        private void textServ_Leave(object sender, EventArgs e)
        {
            if(textServ.Text == "" || textServ.Text == "server name")
            {
                textServ.Text = "server name";
                textServ.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            if(textUser.Text == "username")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.DimGray;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if(textUser.Text == "" || textUser.Text == "username")
            {
                textUser.Text = "username";
                textUser.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if(textPass.Text == "password")
            {
                textPass.Text = "";
                textPass.UseSystemPasswordChar = true;
                textPass.ForeColor = Color.DimGray;
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if(textPass.Text == "" || textPass.Text == "password")
            {
                textPass.Text = "password";
                textPass.UseSystemPasswordChar = false;
                textPass.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void comboDatabase_Enter(object sender, EventArgs e)
        {
            if(comboDatabase.Text == "select database")
            {
                comboDatabase.Text = "";
                comboDatabase.ForeColor = Color.DimGray;
            }
        }

        private void comboDatabase_Leave(object sender, EventArgs e)
        {
            if(comboDatabase.Text == "" || comboDatabase.Text == "select database")
            {
                comboDatabase.Text = "select database";
                comboDatabase.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }

        private void comboDatabase_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboDatabase.Text == "MySql")
            {
                textServ.Text = "localhost";
                textServ.ForeColor = Color.DimGray;
                textUser.Text = "root";
                textUser.ForeColor = Color.DimGray;
                textPass.Text = "";
                textPass.ForeColor = Color.DimGray;
            }
            else if(comboDatabase.Text == "Sql Server")
            {
                comboDatabase.ForeColor = Color.DimGray;
                textServ.Text = "JAMES-MAT";
                textServ.ForeColor = Color.DimGray;
                textUser.Text = "sa";
                textUser.ForeColor = Color.DimGray;
                textPass.Text = "password";
                textPass.UseSystemPasswordChar = false;
                textPass.ForeColor = Color.FromArgb(198, 190, 255);
            }
            else
            {
                MessageBox.Show("Select the valide Server", "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eyes_Click(object sender, EventArgs e)
        {
            if (textPass.UseSystemPasswordChar == true)
            {
                textPass.UseSystemPasswordChar = false;
                eyes.Image = global::Gestion_Personne.Properties.Resources.icons8_hide_24px;
            }
            else
            {
                textPass.UseSystemPasswordChar = true;
                eyes.Image = global::Gestion_Personne.Properties.Resources.icons8_eye_24px;
            }
        }
    }
}
