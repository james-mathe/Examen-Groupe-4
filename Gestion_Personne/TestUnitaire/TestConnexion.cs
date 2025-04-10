using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using NUnit.Framework;
using NUnit.Framework.Legacy;


namespace TestUnitaire
{
    public enum ConnexionType
    {
        SQLServer,
        MySQL,
        PostGreSQL,
        Oracle,
        Access
    }

    public class Connexion
    {
        public string Serveur { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }

    [TestFixture]
    public class TestConnexion
    {
        private IDbConnection _conn = null;
        private Connexion _connexion;
        private ConnexionType _connexionType;

        [SetUp]
        public void SetUp()
        {
            // Initialiser les valeurs de _connexion et _connexionType ici
            // Par exemple :
            _connexion = new Connexion
            {
                Serveur = "votre_serveur",
                Database = "votre_base_de_données",
                User = "votre_utilisateur",
                Password = "votre_mot_de_passe"
            };
            _connexionType = ConnexionType.SQLServer; // ou ConnexionType.MySQL, etc.
        }

        private void Initialise()
        {
            switch (_connexionType)
            {
                case ConnexionType.SQLServer:
                    _conn = new SqlConnection($"Data Source={_connexion.Serveur};Initial Catalog={_connexion.Database};User ID={_connexion.User};Password={_connexion.Password}");
                    break;
                case ConnexionType.MySQL:
                    _conn = new MySqlConnection($"Server={_connexion.Serveur};Database={_connexion.Database};User ID={_connexion.User};Password={_connexion.Password}");
                    break;
                // Ajoutez les autres cas selon les besoins
                default:
                    _conn = null;
                    break;
            }
        }

        [Test]
        public void TestConnexionBaseDeDonnees()
        {
            // Arrange
            Initialise();

            // Act
            _conn.Open();
            bool estOuverte = _conn.State == ConnectionState.Open;
            _conn.Close();

            // Assert
            Assert.That(estOuverte, Is.True); // Utilisation de Assert.That au lieu de Assert.IsTrue
        }
    }
}
