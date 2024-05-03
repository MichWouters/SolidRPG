using RPG13.Business.Factories.Interfaces;
using RPG13.Business.Logging;
using RPG13.Business.Player;
using RPG13.Business.Services;
using RPG13.Business.Weapon.Interfaces;

namespace RPG13.Business.Enemies
{
    public abstract class Enemy : IEnemy
    {
        protected IRandomService _randomService;
        protected IWeaponsFactory _weaponsFactory;
        protected ILogger _logger;

        public int Health { get; protected set; } = 20;
        public int MaxDamage { get; protected set; }
        public int MinDamage { get; protected set; }
        public string Name { get; protected set; }

        public Enemy(IRandomService randomService, IWeaponsFactory weaponsFactory, ILogger logger, string name)
        {
            _weaponsFactory = weaponsFactory;
            _randomService = randomService;
            _logger = logger;

            Name = name;
            logger.Log($"A wild {Name} appeared!");
        }

        public virtual void Attack(IPlayer player)
        {
            int damage = _randomService.GetRandomValue(MinDamage, MaxDamage);
            player.TakeDamage(damage);
        }

        public IWeapon? Die(int maxLootLevel = 3)
        {
            _logger.Log($"{Name} died!");
            if (_randomService.RollForSuccess(40))
            {
                IWeapon loot = DropLoot(maxLootLevel);
                _logger.Log($"{Name} dropped loot! Found a {loot.Name}");
                return loot;
            }
            else
            {
                return null;
            }
        }

        public virtual void TakeDamage(int damage)
        {
            _logger.Log($"{Name} took {damage} damage! Health remaining: {Health}");
            Health -= damage;
            if (Health <= 0)
            {
                Die();
            }
        }

        protected virtual IWeapon DropLoot(int maxLevel)
        {
            return _weaponsFactory.GetRandomLoot(maxLevel);
        }
    }
}