using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageSingleConnexion;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Connexion connection = new Connexion();

                connection.Serveur = "DESKTOP-1PQ7N3N";
                connection.Database = "g_personne";
                connection.User = "sa";
                connection.Password = "20032020@";

                implementeConnexion.Instance.Initialise(connection, Connexiontype.SQLServer);

                if (implementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Closed)
                    implementeConnexion.Instance.Conn.Open();

                Console.WriteLine("Connection Successfuly !!!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Connection error, " + ex.Message);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Connection error, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection error, " + ex.Message);
            }
            finally
            {
                if (implementeConnexion.Instance.Conn != null)
                {
                    if (implementeConnexion.Instance.Conn.State == System.Data.ConnectionState.Open)
                        implementeConnexion.Instance.Conn.Close();
                }
            }

            Console.ReadLine();
        }
    
    }
}

