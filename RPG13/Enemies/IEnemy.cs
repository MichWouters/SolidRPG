using RPG13.Player;
using RPG13.Weapon.Interfaces;

namespace RPG13.Enemies
{
    public interface IEnemy
    {
        int Health { get; }
        int MaxDamage { get; }
        int MinDamage { get; }
        string Name { get; }

        void Attack(IPlayer player);

        IWeapon? Die(int percentageOfDroppingLoot = 40);

        void TakeDamage(int damage);
    }
}