using RPG13.Enemies;
using RPG13.Weapon.Interfaces;

namespace RPG13.Player
{
    public interface IPlayer
    {
        int Health { get; }
        int Intelligence { get; }
        IWeapon MeleeWeapon { get; set; }
        string Name { get; }
        IRangedWeapon RangedWeapon { get; set; }
        int Strength { get; }

        void Attack(IEnemy enemy);

        void Die();

        void PickUpWeapon(IWeapon weapon, bool pickup);

        void TakeDamage(int damage);

        string ToString();

        int DamageDone { get; }

        int EnemiesKilled { get; }  
    }
}