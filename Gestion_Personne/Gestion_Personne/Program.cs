using Gestion_Personne.Modals;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Personne
{
    static class Program
    {
        static string configFilePath = Application.StartupPath + @"\config.ini"; // Chemin du fichier de configuration

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (File.Exists(configFilePath) && IsConfigValid(configFilePath))
            {
                // Si la configuration est valide, on affiche le LogForm
                Application.Run(new Connection());
            }
            else
            {
                // Si le fichier n'existe pas ou que la configuration est invalide, on affiche le Server Form
                Application.Run(new server_config());
            }
        }

        /// <summary>
        /// Vérifie si le fichier de configuration contient des informations valides.
        /// </summary>
        private static bool IsConfigValid(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                // Vérifier s'il y a au moins 5 lignes (Type de serveur, Serveur, Base de données, Utilisateur, Mot de passe)
                if (lines.Length < 5 || lines.Any(string.IsNullOrWhiteSpace))
                {
                    return false; // Fichier incomplet ou contient des lignes vides
                }

                // On peut ajouter ici une vérification plus avancée (ex: tester une connexion à la base de données)

                return true; // Configuration valide
            }
            catch
            {
                return false; // En cas d'erreur de lecture, on considère que le fichier est invalide
            }
        }
    }
}
