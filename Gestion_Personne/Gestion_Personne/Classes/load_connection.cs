using Gestion_Personne.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Ets_Management.Class
{
    public class LoadConnection
    {
        private static LoadConnection _instance = null;
        private IDbConnection _conn;
        private static readonly string configFilePath = Application.StartupPath + @"\config.ini";

        // Constructeur privé (singleton)
        private LoadConnection()
        {
            LoadConfiguration();
        }

        // Singleton access
        public static LoadConnection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoadConnection();
                return _instance;
            }
        }

        public IDbConnection Conn
        {
            get { return _conn; }
            set { _conn = value; }
        }

        public IDbConnection Initialise()
        {
            try
            {
                switch (ConfigurationManager.ServerType.ToLower())
                {
                    case "sqlserver":
                        _conn = new SqlConnection($"Server={ConfigurationManager.ServerName};Database={ConfigurationManager.DatabaseName};User Id={ConfigurationManager.Username};Password={ConfigurationManager.Password};");
                        break;

                    case "mysql":
                        _conn = new MySqlConnection($"Server={ConfigurationManager.ServerName};Database={ConfigurationManager.DatabaseName};UserID={ConfigurationManager.Username};Password={ConfigurationManager.Password};");
                        break;

                    default:
                        throw new NotImplementedException("Type de serveur non supporté : " + ConfigurationManager.ServerType);
                }

                return _conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'initialisation de la connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void LoadConfiguration()
        {
            try
            {
                if (!File.Exists(configFilePath))
                {
                    MessageBox.Show("Le fichier config.ini est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(configFilePath);
                if (lines.Length >= 5)
                {
                    ConfigurationManager.ServerType = lines[0].Trim();
                    ConfigurationManager.ServerName = lines[1].Trim();
                    ConfigurationManager.DatabaseName = lines[2].Trim();
                    ConfigurationManager.Username = lines[3].Trim();
                    ConfigurationManager.Password = Cryptage.Decrypt(lines[4].Trim());

                }
                else
                {
                    MessageBox.Show("Le fichier config.ini est incomplet.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de la configuration : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Gestionnaire de configuration
    public static class ConfigurationManager
    {
        public static string ServerType { get; set; }
        public static string ServerName { get; set; }
        public static string DatabaseName { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
    }
}
