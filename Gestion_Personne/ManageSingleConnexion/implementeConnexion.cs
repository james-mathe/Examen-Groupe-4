using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSingleConnexion
{
   public class implementeConnexion: Iconnexion
    {
        private implementeConnexion()
        {
        }

        //private ConnexionType _conType;
        private IDbConnection _conn = null;
        private static implementeConnexion _instance = null;

        //public ConnexionType ConType
        //{
        //    get
        //    {
        //        return _conType;
        //    }

        //    set
        //    {
        //        _conType = value;
        //    }
        //}

        public IDbConnection Conn
        {
            get
            {
                return _conn;
            }

            set
            {
                _conn = value;
            }
        }

        public static implementeConnexion Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new implementeConnexion();
                return _instance;
            }
        }

        public IDbConnection Initialise(Connexion connexion, Connexiontype connexionType)
        {
            switch (connexionType)
            {
                case Connexiontype.SQLServer:
                    _conn = new SqlConnection(string.Format("Data source={0};Initial catalog={1};User ID={2};Password={3}",
                        connexion.Serveur, connexion.Database, connexion.User, connexion.Password));
                    break;
                case Connexiontype.MySQL:
                    _conn = new MySqlConnection(string.Format("Server={0};Database={1};UserID={2};Password={3}",
                        connexion.Serveur, connexion.Database, connexion.User, connexion.Password));
                    break;
                case Connexiontype.PostGrsSQL:
                    return null;
                case Connexiontype.Oracle:
                    return null;
                case Connexiontype.Access:
                    return null;
            }
            return _conn;
        }
    }
}

