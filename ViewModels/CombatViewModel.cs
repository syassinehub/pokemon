using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POkemonLikeCsharpB2.Model;

namespace POkemonLikeCsharpB2.ViewModels
{
    public class CombatViewModel : BaseViewModel
    {
        private Monster? _playerMonster;
        private Monster? _enemyMonster;

        public Monster PlayerMonster
        {
            get => _playerMonster!;
            set
            {
                _playerMonster = value;
                OnPropertyChanged(nameof(PlayerMonster));
            }
        }

        public Monster EnemyMonster
        {
            get => _enemyMonster!;
            set
            {
                _enemyMonster = value;
                OnPropertyChanged(nameof(EnemyMonster));
            }
        }

        public CombatViewModel()
        {
            GenerateCombat();
        }

        private void GenerateCombat()
        {
            using var db = new ExerciceMonsterContext();
            PlayerMonster = db.Monsters.First();
            EnemyMonster = db.Monsters.OrderBy(m => Guid.NewGuid()).First();
        }
    }
}
