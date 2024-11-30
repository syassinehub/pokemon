using System.Windows;
using System.Windows.Controls;
using POkemonLikeCsharpB2.ViewModels;
using POkemonLikeCsharpB2;

namespace POkemonLikeCsharpB2.Views
{
    public partial class LoginView : Window
    {
        private readonly LoginViewModel _viewModel;

        public LoginView()
        {
            InitializeComponent();
            _viewModel = new LoginViewModel();
            DataContext = _viewModel;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Username = UsernameTextBox.Text;
            _viewModel.Password = PasswordBox.Password;

            if (_viewModel.Login())
            {
                MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);

                // Ouvrir la fenêtre principale ou de gestion des monstres
                var mainWindow = new MainWindow(); // Remplacez par une autre vue si nécessaire
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
