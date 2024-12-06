using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace POkemonLikeCsharpB2.ViewModels
{
    public class LoginViewModel
    {
        public bool AuthenticateUser(string username, string password)
        {
            using (var dbContext = new GameDbContext())
            {
                string hashedPassword = HashPassword(password);
                var user = dbContext.Logins
                    .FirstOrDefault(u => u.Username == username && u.PasswordHash == hashedPassword);

                if (user != null)
                {
                    return true; // Connexion réussie
                }

                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                return false; // Échec de connexion
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
