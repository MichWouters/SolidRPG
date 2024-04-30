using RPG13.Enemies;
using RPG13.Weapon.Interfaces;

namespace RPG13.Player
{
    public interface IPlayer
    {
        int Health { get; }
        int Intelligence { get; }
        string Name { get; }
        int Strength { get; }
        int DamageDone { get; }
        int EnemiesKilled { get; }
        IWeapon MeleeWeapon { get; set; }
        IRangedWeapon RangedWeapon { get; set; }


        void Attack(IEnemy enemy);

        void Die();

        void PickUpWeapon(IWeapon weapon, bool pickup);

        void TakeDamage(int damage);

        string ToString();
    }
}