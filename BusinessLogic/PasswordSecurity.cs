using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class PasswordSecurity
    {
        private const int SaltSize = 32;

        /// <summary>
        ///Generates a random sequence of bytes the length of the variable 'SaltSize'. This sequence of bytes, the 'salt'
        ///is added to the password before hashing it, to ensure that a hashed password is unique even compared to the
        ///the same password hashed using the same algorithm in a different application. Salt is to be stored alongside
        ///the password in the database, so it can be retrieved for password authentication.
        /// </summary>
        /// <returns>A cryptographically secure random sequence of bytes the size of SaltSize</returns>
        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[SaltSize];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        /// <summary>
        /// This method uses the SHA256 hashing algorithm to hash the password and the salt so the password is not
        /// stored in plaintext in the database. When authenticating the password the entered password is hashed 
        /// with the salt stored with the user and matched with the hashed and salted password stored in the database
        /// </summary>
        /// <param name="password">The plaintext password entered by the user</param>
        /// <param name="salt">The sequence of bytes used as salt</param>
        /// <returns>Returns the hashed and salted password as a sequence of bytes</returns>
        public static byte[] HashAndSaltPassword(string password, byte[] salt)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            HashAlgorithm hashing = new SHA256Managed();

            byte[] passwordBytesWithSalt = new byte[passwordBytes.Length + salt.Length];

            for (int i = 0; i < passwordBytes.Length; i++)
            {
                passwordBytesWithSalt[i] = passwordBytes[i];
            }
            for (int i = 0, n = passwordBytes.Length; i < n; i++)
            {
                passwordBytesWithSalt[i + n] = salt[i];
            }

            return hashing.ComputeHash(passwordBytesWithSalt);
        }

    }
}
