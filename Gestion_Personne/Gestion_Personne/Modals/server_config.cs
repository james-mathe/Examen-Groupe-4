using Gestion_Personne.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSingleConnexion;

namespace Gestion_Personne.Modals
{
    public partial class server_config : Form
    {
        private readonly string configFilePath = Application.StartupPath + @"\config.ini";

        public server_config()
        {
            InitializeComponent();
        }

        private void SaveConnectionInfo()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(configFilePath))
                {
                    writer.WriteLine(cboDBType.Text);
                    writer.WriteLine(txtserver.Text);
                    writer.WriteLine(txtbd.Text);
                    writer.WriteLine(txtuser.Text);
                    writer.WriteLine(Cryptage.Encrypt(txtpass.Text)); // Crypter le mot de passe
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement de la configuration : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void open()
        {
            try
            {
                Connexion conn = new Connexion()
                {
                    Serveur = txtserver.Text,
                    Database = txtbd.Text,
                    User = txtuser.Text,
                    Password = txtpass.Text
                };

                Connexiontype type = Connexiontype.SQLServer; // Par défaut

                switch (cboDBType.Text.Trim().ToLower())
                {
                    case "sqlserver":
                        type = Connexiontype.SQLServer;
                        break;
                    case "mysql":
                        type = Connexiontype.MySQL;
                        break;
                    case "postgresql":
                        type = Connexiontype.PostGrsSQL;
                        break;
                    case "oracle":
                        type = Connexiontype.Oracle;
                        break;
                    case "access":
                        type = Connexiontype.Access;
                        break;
                    default:
                        MessageBox.Show("Type de serveur non reconnu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                IDbConnection connection = implementeConnexion.Instance.Initialise(conn, type);
                connection.Open();
                SaveConnectionInfo();

                MessageBox.Show("Connexion réussie et configuration enregistrée.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection log = new Connection();
                log.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void server_config_Load(object sender, EventArgs e)
        {
            cboDBType.DataSource = Enum.GetNames(typeof(Connexiontype));
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            open();
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
