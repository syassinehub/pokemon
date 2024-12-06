using CommunityToolkit.Mvvm.Input;
using POkemonLikeCsharpB2.ViewModels;
using System.Configuration;
using System.Windows.Input;

public class SettingsViewModel : BaseViewModel
{
    private string _connectionString;
    public string ConnectionString
    {
        get => _connectionString;
        set
        {
            _connectionString = value;
            OnPropertyChanged();
        }
    }

    public ICommand SaveSettingsCommand { get; }

    public SettingsViewModel()
    {
        // Charger la chaîne de connexion depuis un fichier de configuration ou autre source.
        _connectionString = ConfigurationManager.AppSettings["DatabaseConnection"];
        SaveSettingsCommand = new RelayCommand(SaveSettings);
    }

    private void SaveSettings()
    {
        // Enregistrer la chaîne de connexion dans un fichier de configuration.
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["DatabaseConnection"].Value = _connectionString;
        config.Save(ConfigurationSaveMode.Modified);
        ConfigurationManager.RefreshSection("appSettings");
    }
}
