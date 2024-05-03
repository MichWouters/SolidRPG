using RPG13.Business.Enemies;
using RPG13.Business.Weapon.Interfaces;

namespace RPG13.Business.Player
{
    public interface IPlayer
    {
        int Health { get; set; }
        int Intelligence { get; }
        string Name { get; }
        int Strength { get; }
        int DamageDone { get; }
        int EnemiesKilled { get; }
        IWeapon MeleeWeapon { get; set; }
        IRangedWeapon RangedWeapon { get; set; }
        object? Potions { get; set; }

        void Attack(IEnemy enemy);

        void Die();
        void DrinkPotion(int potionHealValue);
        void PickUpWeapon(IWeapon weapon, bool pickup);

        void TakeDamage(int damage);

        string ToString();
    }
}