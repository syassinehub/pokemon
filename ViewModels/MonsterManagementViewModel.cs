using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POkemonLikeCsharpB2.Model;

namespace POkemonLikeCsharpB2.ViewModels
{
    public class MonsterManagementViewModel : BaseViewModel
    {
        public ObservableCollection<Monster> Monsters { get; set; }

        public MonsterManagementViewModel()
        {
            using var db = new ExerciceMonsterContext();
            Monsters = new ObservableCollection<Monster>(db.Monsters.ToList());
        }
    }
}
