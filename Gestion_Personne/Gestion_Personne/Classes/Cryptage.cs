using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string HashPassword(string plainPassword)
        {
            if (string.IsNullOrEmpty(plainPassword))
            {
                throw new ArgumentNullException(nameof(plainPassword), "Password cannot be null or empty.");
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(plainPassword, workFactor: 11);
            return hashedPassword;
        }
        public bool VerifyPassword(string enteredPassword, string storedHash)
        {
            try
            {
                // BCrypt.Verify extrait automatiquement le sel du 'storedHash',
                // re-hache 'enteredPassword' avec ce sel et compare les résultats.
                return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
            }
            catch (BCrypt.Net.SaltParseException ex)
            {
                // Gérer le cas où le hash stocké n'est pas valide (format incorrect)
                Console.WriteLine($"Error verifying password: Invalid hash format. {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Gérer d'autres erreurs potentielles
                Console.WriteLine($"An unexpected error occurred during password verification: {ex.Message}");
                return false;
            }
        }
    }
}
