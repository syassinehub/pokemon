using POkemonLikeCsharpB2.Model;
using POkemonLikeCsharpB2.ViewModels;
using System.Collections.ObjectModel;

public class MonsterManagementViewModel : BaseViewModel
{
    private ObservableCollection<Monster> _monsters;
    public ObservableCollection<Monster> Monsters
    {
        get => _monsters;
        set
        {
            _monsters = value;
            OnPropertyChanged();
        }
    }

    private Monster _selectedMonster;
    public Monster SelectedMonster
    {
        get => _selectedMonster;
        set
        {
            _selectedMonster = value;
            OnPropertyChanged();
            LoadSpellsForMonster();
        }
    }

    public ObservableCollection<Spell> Spells { get; set; }

    public MonsterManagementViewModel()
    {
        LoadMonsters();
    }

    private void LoadMonsters()
    {
        using (var context = new ExerciceMonsterContext())
        {
            Monsters = new ObservableCollection<Monster>(context.Monsters.ToList());
        }
    }

    private void LoadSpellsForMonster()
    {
        if (SelectedMonster == null) return;

        using (var context = new ExerciceMonsterContext())
        {
            var spells = context.MonsterSpells
                .Where(ms => ms.MonsterID == SelectedMonster.ID)
                .Select(ms => ms.Spell)
                .ToList();
            Spells = new ObservableCollection<Spell>(spells);
        }
    }
}
