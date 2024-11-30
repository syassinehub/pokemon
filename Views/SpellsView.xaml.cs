using System.Linq;
using System.Windows;
using System.Windows.Controls;
using POkemonLikeCsharpB2.Model;

namespace POkemonLikeCsharpB2.Views
{
    public partial class SpellsView : Window
    {
        private readonly ExerciceMonsterContext _context = new();

        public SpellsView()
        {
            InitializeComponent();
            LoadMonsters();
            LoadSpells();
        }

        private void LoadMonsters()
        {
            var monsters = _context.Monsters.ToList();
            foreach (var monster in monsters)
            {
                MonsterFilterComboBox.Items.Add(monster.Name);
            }
        }

        private void LoadSpells(int? monsterId = null)
        {
            var spells = _context.Spells.AsQueryable();

            if (monsterId.HasValue)
            {
                spells = spells.Where(s => s.Monsters.Any(m => m.Id == monsterId));
            }

            SpellsListView.ItemsSource = spells.ToList();
        }

        private void MonsterFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MonsterFilterComboBox.SelectedIndex == 0)
            {
                LoadSpells();
            }
            else
            {
                var selectedMonsterName = MonsterFilterComboBox.SelectedItem.ToString();
                var monster = _context.Monsters.FirstOrDefault(m => m.Name == selectedMonsterName);

                LoadSpells(monster?.Id);
            }
        }
    }
}
