using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POkemonLikeCsharpB2.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private const string ConfigFile = "db_config.txt";
        private string _connectionString;

        public string ConnectionString
        {
            get => _connectionString;
            set
            {
                _connectionString = value;
                OnPropertyChanged(nameof(ConnectionString));
            }
        }

        public SettingsViewModel()
        {
            LoadConnectionString();
        }

        private void LoadConnectionString()
        {
            if (File.Exists(ConfigFile))
            {
                ConnectionString = File.ReadAllText(ConfigFile);
            }
        }

        public void SaveConnectionString()
        {
            File.WriteAllText(ConfigFile, ConnectionString);
        }
    }
}
