using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Gestion_Personne.Classes
{
    class Cryptage
    {
        public String EncryptData(string plainText)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(plainText));
        }

        public String DecryptData(string encryptedText)
        {
            try
            {
                return Encoding.Unicode.GetString(Convert.FromBase64String(encryptedText));
            }
            catch
            {
                return String.Empty;
            }
        }
    }
}
