using System;
using System.Security.Cryptography;
using System.Text;

namespace ElectronicsShop.Helpers
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(password));

            var saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes);
            }

            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            var hashBytes = pbkdf2.GetBytes(20);

            var hash = new byte[36];
            Array.Copy(saltBytes, 0, hash, 0, 16);
            Array.Copy(hashBytes, 0, hash, 16, 20);

            return Convert.ToBase64String(hash);
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            if (password == null)
                throw new ArgumentNullException(nameof(password));

            if (hashedPassword == null)
                throw new ArgumentNullException(nameof(hashedPassword));

            var hashBytes = Convert.FromBase64String(hashedPassword);
            var saltBytes = new byte[16];
            Array.Copy(hashBytes, 0, saltBytes, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000);
            var newHashBytes = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != newHashBytes[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
