using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSingleConnexion
{
    public class Connexion
    {
        public static Connexion _instance = null;

        public static Connexion GetInstance()
        {
            if (_instance == null)
                _instance = new Connexion();
            return _instance;
        }
        public Connexion()
        {
            Serveur = "votre_serveur";
            Database = "votre_base_de_données";
            User = "votre_utilisateur";
            Password = "votre_mot_de_passe";
        }

        string _serveur = "serveur";
        string _database = "database";
        string _user = "user";
        string _password = "password";
        int _port = 5432;

        public string Serveur
        {
            get
            {
                return _serveur;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidOperationException("Please specify a valid Server !!!");
                else
                    _serveur = value;
            }
        }

        public string Database
        {
            get
            {
                return _database;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidOperationException("Please specify a valid Database !!!");
                else
                    _database = value;
            }
        }

        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidOperationException("Please specify a valid Username !!!");
                else
                    _user = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidOperationException("Please specify a valid Password !!!");
                else
                    _password = value;
            }
        }

        public int Port
        {
            get
            {
                return _port;
            }

            set
            {
                if (value <= 0)
                    throw new InvalidOperationException("Please specify a valid Port number !!!");
                else
                    _port = value;
            }
        }
}
}
