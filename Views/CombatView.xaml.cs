using System.Windows;
using POkemonLikeCsharpB2.Model;

namespace POkemonLikeCsharpB2.Views
{
	public partial class CombatView : Window
	{
		private Monster _playerMonster;
		private Monster _enemyMonster;

		public CombatView()
		{
			InitializeComponent();

			// Initialisation des monstres avec des valeurs par défaut
			_playerMonster = new Monster
			{
				Name = "DefaultPlayer",
				Health = 100
			};

			_enemyMonster = new Monster
			{
				Name = "DefaultEnemy",
				Health = 100
			};

			// Affichage initial des informations
			PlayerMonsterName.Text = _playerMonster.Name;
			EnemyMonsterName.Text = _enemyMonster.Name;
			PlayerMonsterHP.Value = _playerMonster.Health;
			EnemyMonsterHP.Value = _enemyMonster.Health;
		}

		private void AttackButton_Click(object sender, RoutedEventArgs e)
		{
			// Logique pour l'attaque
			_enemyMonster.Health -= 10; // Réduit la santé de l'ennemi

			if (_enemyMonster.Health < 0) _enemyMonster.Health = 0;
			EnemyMonsterHP.Value = _enemyMonster.Health;

			// Vérifie si l'ennemi est mort
			if (_enemyMonster.Health == 0)
			{
				MessageBox.Show("Vous avez vaincu l'ennemi !");
			}
		}

		private void RestartCombatButton_Click(object sender, RoutedEventArgs e)
		{
			// Relancer le combat en réinitialisant les monstres
			_playerMonster.Health = 100;
			_enemyMonster.Health = 100;
			PlayerMonsterHP.Value = _playerMonster.Health;
			EnemyMonsterHP.Value = _enemyMonster.Health;
		}
	}
}
