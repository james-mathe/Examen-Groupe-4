using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Gestion_Personne.Classes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test_Gestion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConnection()
        {
            Config db = new Config();
            db.ServerName = "james-mat";
            db.Username = "sa";
            db.Password = "james";

            SqlConnection con = db.getSqlConnection();
            con.Open();
            bool isactiv = con.State == ConnectionState.Open;

            Assert.IsTrue(isactiv == true);

        }

        [TestMethod]
        public void test()
        {
            Assert.AreEqual(8, somme(4, 4));
        }

        public int somme(int a,int b)
        {
            return a+b;
        }
    }
}
