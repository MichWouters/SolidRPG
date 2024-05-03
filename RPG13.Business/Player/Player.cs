using RPG13.Business.Enemies;
using RPG13.Business.Logging;
using RPG13.Business.Service;
using RPG13.Business.Weapon.Interfaces;

namespace RPG13.Business.Player
{
    public abstract class Player : IPlayer
    {
        protected ILogger _logger;
        protected IDiceService _diceService;

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
            _diceService = diceService;
            _logger = logger;

            Name = name;
            _logger.Log($"Player {Name} entered the fight!");
        }

        public void Attack(IEnemy enemy)
        {
            int meleeDamage = MeleeWeapon?.Damage * Strength ?? 0;
            int rangedDamage = RangedWeapon?.Damage * Intelligence ?? 0;

            _logger.Log($"Player {Name} prepares to do {meleeDamage} points " +
                $"of melee and {rangedDamage} points of magical damage");

            int totalDamage = meleeDamage + rangedDamage;
            enemy.TakeDamage(totalDamage);
            DamageDone += rangedDamage;
        }

        public void Die()
        {
            _logger.Log($"Player {Name} died!");
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

            _logger.Log($"{Name} picked up a {weapon.Name}");
            _logger.Log($"Currently equipped: {MeleeWeapon?.Name}, {RangedWeapon?.Name}");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            _logger.Log($"{Name} took damage! Health remaining: {Health}");

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