using System.IO;
using System.Windows;

namespace POkemonLikeCsharpB2.Views
{
    public partial class SettingsView : Window
    {
        private const string ConfigFile = "db_config.txt";

        public SettingsView()
        {
            InitializeComponent();
            LoadConnectionString();
        }

        private void LoadConnectionString()
        {
            if (File.Exists(ConfigFile))
            {
                ConnectionStringTextBox.Text = File.ReadAllText(ConfigFile);
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText(ConfigFile, ConnectionStringTextBox.Text);
            MessageBox.Show("Paramètres sauvegardés avec succès.");
            Close();
        }
    }
}
