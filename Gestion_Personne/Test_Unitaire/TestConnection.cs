using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace Test_Unitaire
{
    public enum Connexiontype
    {
        SQLServer,
        MySQL
        // Ajoutez d'autres types de connexions si nécessaire
    }

    [TestClass]
    public class TestConnection
    {
        private Connexiontype _connexionType;
        private IDbConnection _conn = null;
        private Connexion _connexion;

        public class Connexion
        {
            public string Serveur { get; set; }
            public string Database { get; set; }
            public string User { get; set; }
            public string Password { get; set; }
        }

        [TestInitialize]
        public void SetUp()
        {
            _connexion = new Connexion
            {
                Serveur = "DESKTOP-1PQ7N3N",
                Database = "g_personne",
                User = "sa",
                Password = "20032020@"
            };
            _connexionType = Connexiontype.SQLServer;
            // Initialiser les valeurs de _connexion et _connexionType ici
            // ou Connexiontype.MySQL, etc.
        }

        private void Initialise()
        {
            switch (_connexionType)
            {
                case Connexiontype.SQLServer:
                    _conn = new SqlConnection($"Data Source={_connexion.Serveur};Initial Catalog={_connexion.Database};User ID={_connexion.User};Password={_connexion.Password}");
                    break;
                case Connexiontype.MySQL:
                    _conn = new MySqlConnection($"Server={_connexion.Serveur};Database={_connexion.Database};User ID={_connexion.User};Password={_connexion.Password}");
                    break;
                // Ajoutez les autres cas selon les besoins
                default:
                    _conn = null;
                    break;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            Initialise();

            // Act
            _conn.Open();
            bool estOuverte = _conn.State == ConnectionState.Open;
            _conn.Close();

            // Assert
            Assert.IsTrue(estOuverte, "La connexion n'a pas pu être ouverte.");
        }
    }
}
