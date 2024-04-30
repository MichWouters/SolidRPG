using RPG13.Enemies;
using RPG13.Logging;
using RPG13.Service;
using RPG13.Weapon.Interfaces;

namespace RPG13.Player
{
    public abstract class Player : IPlayer
    {
        protected ILogger Logger;
        protected IDiceService DiceService;

        public int DamageDone { get; private set; }
        public int EnemiesKilled { get; private set; }
        public int Health { get; protected set; }
        public int Intelligence { get; protected set; }
        public IWeapon MeleeWeapon { get; set; }
        public string Name { get; protected set; }
        public IRangedWeapon RangedWeapon { get; set; }
        public int Strength { get; protected set; }

        public Player(IDiceService diceService, ILogger logger, string name)
        {
            DiceService = diceService;
            Logger = logger;

            Name = name;
            Logger.Log($"Player {Name} entered the fight!");
        }

        public void Attack(IEnemy enemy)
        {
            int meleeDamage = MeleeWeapon?.Damage * Strength ?? 0;
            int rangedDamage = RangedWeapon?.Damage * Intelligence ?? 0;

            Logger.Log($"Player {Name} prepares to do {meleeDamage} points " +
                $"of melee and {rangedDamage} points of magical damage");

            int totalDamage = meleeDamage + rangedDamage;
            enemy.TakeDamage(totalDamage);
            DamageDone += rangedDamage;
        }

        public void Die()
        {
            throw new NotImplementedException();
        }

        public void PickUpWeapon(IWeapon weapon, bool pickup = true)
        {
            if (!pickup) return;

            switch (weapon.WeaponType)
            {
                case WeaponType.Melee:
                    MeleeWeapon = (IMeleeWeapon)weapon;
                    break;

                case WeaponType.Ranged:
                    RangedWeapon = (IRangedWeapon)weapon;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(weapon));
            }

            Logger.Log($"{Name} picked up a {weapon.Name}");
            Logger.Log($"Currently equipped: {MeleeWeapon?.Name}, {RangedWeapon?.Name}");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Logger.Log($"{Name} took damage! Health remaining: {Health}");

            if (Health < 0)
            {
                Die();
            }
        }

        public override string ToString()
        {
            return $"Health: {Health}, Strength: {Strength}, Intelligence: {Intelligence}, Melee: {MeleeWeapon}, Ranged: {RangedWeapon}";
        }
    }
}