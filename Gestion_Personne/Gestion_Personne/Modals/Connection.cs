using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageSingleConnexion;
using Ets_Management.Class;

namespace Gestion_Personne.Modals
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer la connexion depuis LoadConnection
                IDbConnection connection = LoadConnection.Instance.Initialise();

                // Vérifie si la connexion a réussi
                if (connection == null)
                {
                    MessageBox.Show("Erreur de connexion au serveur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                connection.Open();

                string query = "SELECT * FROM Utilisateur WHERE username = @username AND password = @password";

                using (IDbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = query;

                    // Ajout des paramètres pour éviter l'injection SQL
                    IDbDataParameter paramUser = cmd.CreateParameter();
                    paramUser.ParameterName = "@username";
                    paramUser.Value = txtusername.Text;
                    cmd.Parameters.Add(paramUser);

                    IDbDataParameter paramPass = cmd.CreateParameter();
                    paramPass.ParameterName = "@password";
                    paramPass.Value = txtpassword.Text;
                    cmd.Parameters.Add(paramPass);

                    using (IDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Menu main = new Menu();
                            main.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
