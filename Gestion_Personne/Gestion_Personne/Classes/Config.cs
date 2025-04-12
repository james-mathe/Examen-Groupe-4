using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personne.Classes
{
    class Config : IConnection
    {
        private readonly string configFilePath = Application.StartupPath + @"\config.ini";
        public String ServerType;
        public String ServerName;
        public String Username;
        public String Password;
        public Config()
        {
            
            if (File.Exists(configFilePath))
            {
                LoadConfiguration();
            }
        }
        private void LoadConfiguration()
        {
            try
            {
                string[] lines = File.ReadAllLines(configFilePath);
                if (lines.Length == 4)
                {
                    ServerType = lines[0].Trim();
                    ServerName = lines[1].Trim();
                    Username = lines[2].Trim();
                    Password = lines[3].Trim();

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
        public MySqlConnection getMySqlConnection()
        {
            return new MySqlConnection("Server=" + ServerName + ";Database=g_personne;UserID=" + Username + ";Password=" + Password);
        }

        public SqlConnection getSqlConnection()
        {
            return new SqlConnection("Data source=" + ServerName + ";Initial catalog=g_personne;User=" + Username + ";Password=" + Password);
        }
    }
}
