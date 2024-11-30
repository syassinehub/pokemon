using System.Linq;
using System.Windows;
using System.Windows.Controls;
using POkemonLikeCsharpB2.Model;

namespace POkemonLikeCsharpB2.Views
{
    public partial class MonsterManagementView : Window
    {
        private readonly ExerciceMonsterContext _context = new();

        public MonsterManagementView()
        {
            InitializeComponent();
            LoadMonsters();
        }

        private void LoadMonsters()
        {
            var monsters = _context.Monsters.ToList();
            MonstersListView.ItemsSource = monsters;
        }

        private void MonstersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MonstersListView.SelectedItem is Monster selectedMonster)
            {
                MonsterNameTextBlock.Text = selectedMonster.Name;
                MonsterHealthTextBlock.Text = selectedMonster.Health.ToString();

                var spells = selectedMonster.Spells.ToList();
                SpellsListBox.ItemsSource = spells.Select(s => $"{s.Name} (Dégâts: {s.Damage})");
            }
        }
    }
}
