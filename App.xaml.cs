using System;
using System.Configuration;
using System.Windows;

namespace POkemonLikeCsharpB2
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Vérification de la connexion à la base de données
            try
            {
                using (var context = new Model.ExerciceMonsterContext())
                {
                    if (!context.Database.CanConnect())
                    {
                        MessageBox.Show("Impossible de se connecter à la base de données.\nVeuillez vérifier votre configuration dans les paramètres.",
                            "Erreur de connexion", MessageBoxButton.OK, MessageBoxImage.Error);
                        Application.Current.Shutdown();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite lors de la tentative de connexion à la base de données :\n{ex.Message}",
                    "Erreur critique", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
            }
        }
    }
}
