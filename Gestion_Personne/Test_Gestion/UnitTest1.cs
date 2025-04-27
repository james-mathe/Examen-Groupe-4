using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Gestion_Personne.Classes;
using System.Data.SqlClient;

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
                bool isOpen = con.State == System.Data.ConnectionState.Open;

                Assert.IsTrue(isOpen);
                con.Close();
            }
            
        }
        [TestMethod]
        public void TestInsertUser()
        {
            Gestion_Personne.Classes.User.AddUpdateDeleteUser user = new Gestion_Personne.Classes.User.AddUpdateDeleteUser();
            Config db = new Config();
            if(db.ServerType == "Sql Server")
            {
                Assert.IsTrue(user.addUserSql("james", "1234"), "User Not added");
            }
        }
    }
}
