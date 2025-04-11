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
        private readonly string configFilePath = Application.StartupPath + @"\Sqlconfig.ini";
        private Form menu;
        private Config con;
        private String ServerType;
        private String ServerName;
        private String Username;
        private String Password;
        public Server_Config(Form m)
        {
            InitializeComponent();
            this.menu = m;
            this.con = new Config();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement de la configuration : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openSql()
        {
            try
            {
                
                SaveConnectionInfo();

                MessageBox.Show("Connexion réussie et configuration enregistrée.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void LoadConfiguration()
        {
            try
            {
                openSql();
                if (!File.Exists(configFilePath))
                {
                    MessageBox.Show("Le fichier Sqlconfig.ini est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(configFilePath);
                if (lines.Length == 4)
                {
                    ServerType = lines[0].Trim();
                    ServerName = lines[1].Trim();
                    //String DatabaseName = lines[2].Trim();
                    Username = lines[2].Trim();
                    Password = lines[3].Trim();

                }
                else
                {
                    MessageBox.Show("Le fichier Sqlconfig.ini est incomplet.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de la configuration : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadConfiguration();
            SqlConnection sqlcon = con.getSqlConnection(ServerName, Username, Password);
            if(IsEmpty() != null)
            {
                MessageBox.Show(IsEmpty(), "Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (comboDatabase.Text == "Sql Server")
                {
                    try
                    {
                        sqlcon.Open();
                        if (sqlcon.State == ConnectionState.Open)
                        {
                            MessageBox.Show("Connected Successfully to Sql Server", "Sql Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            (menu as Menu).DesactiveConnection();
                            (menu as Menu).ActiveSideBarButtons();
                            (menu as Menu).panelSetting.Visible = false;
                            (menu as Menu).controlPanel.Visible = true;
                            this.Close();
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
                else
                {
                    MessageBox.Show("Select the valide SGBD", "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                textServ.Text = "server name";
                textServ.ForeColor = Color.FromArgb(198, 190, 255);
                textUser.Text = "sa";
                textUser.ForeColor = Color.DimGray;
                textPass.Text = "password";
                textPass.UseSystemPasswordChar = false;
                textPass.ForeColor = Color.FromArgb(198, 190, 255);
            }
        }
    }
}
