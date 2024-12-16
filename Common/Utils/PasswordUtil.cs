using System.Security.Cryptography;
using System.Text;

namespace HeinHtetNaing_ADI.Common.Utils
{
    internal class PasswordUtil
    {
        /// <summary>
        /// Hashes a password using SHA256 and converts it to a hexadecimal string.
        /// </summary>
        /// <param name="password">The plaintext password to hash.</param>
        /// <returns>A hexadecimal string representation of the hashed password.</returns>
        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));

            using var sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToHexString(hashBytes);
        }

        /// <summary>
        /// Verifies whether a given plaintext password matches a hashed password.
        /// </summary>
        /// <param name="password">The plaintext password to verify.</param>
        /// <param name="hashedPassword">The hashed password to compare against.</param>
        /// <returns>True if the passwords match; otherwise, false.</returns>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password cannot be null or empty.", nameof(password));
            if (string.IsNullOrEmpty(hashedPassword))
                throw new ArgumentException("Hashed password cannot be null or empty.", nameof(hashedPassword));

            string computedHash = HashPassword(password);
            return string.Equals(computedHash, hashedPassword, StringComparison.OrdinalIgnoreCase);
        }
    }
}
