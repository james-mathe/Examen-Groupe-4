using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Gestion_Personne.Classes;
using System.Data.SqlClient;
using System.Data;

namespace Test_Gestion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConnection()
        {
            Config db = new Config();
            if(db.ServerType == "Sql Server")
            {
                SqlConnection con = db.getSqlConnection();
                con.Open();
                bool isOpen = false;
                Assert.IsTrue(isOpen,"Erreur de Connexion");
                con.Close();
            }
            
        }
        [DataTestMethod]
        public void TestInsertUser()
        {
            Gestion_Personne.Classes.User.AddUpdateDeleteUser user = new Gestion_Personne.Classes.User.AddUpdateDeleteUser();
            Config db = new Config();
            if(db.ServerType == "Sql Server")
            {
                Assert.AreEqual(true, user.addUserSql("james", "1234"));
            }
        }

        [TestMethod]
        public void TestUpdateUser()
        {
            Gestion_Personne.Classes.User.AddUpdateDeleteUser user = new Gestion_Personne.Classes.User.AddUpdateDeleteUser();
            Config db = new Config();
            if (db.ServerType == "Sql Server")
            {
                Assert.IsTrue(user.UpdateUserSql(3,"james", "1234") == true, "User Not Updated");
            }
        }

        [TestMethod]
        public void test()
        {
            Assert.AreEqual(true, somme(4, 4));
        }

        public bool somme(int a,int b)
        {
            return true;
        }
    }
}
