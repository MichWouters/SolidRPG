using RPG13.Factories.Interfaces;
using RPG13.Logging;
using RPG13.Player;
using RPG13.Services;
using RPG13.Weapon.Interfaces;

namespace RPG13.Enemies
{
    public abstract class Enemy : IEnemy
    {
        protected IRandomService RandomService;
        protected IWeaponsFactory WeaponsFactory;
        protected ILogger Logger;

        public int Health { get; protected set; } = 20;
        public int MaxDamage { get; protected set; }
        public int MinDamage { get; protected set; }
        public string Name { get; protected set; }

        public Enemy(IRandomService randomService, IWeaponsFactory weaponsFactory, ILogger logger, string name)
        {
            WeaponsFactory = weaponsFactory;
            RandomService = randomService;
            Logger = logger;

            Name = name;
            logger.Log($"A wild {Name} appeared!");
        }

        public virtual void Attack(IPlayer player)
        {
            int damage = RandomService.GetRandomValue(MinDamage, MaxDamage);
            player.TakeDamage(damage);
        }

        public IWeapon? Die(int maxLootLevel = 3)
        {
            Logger.Log($"{Name} died!");
            if (RandomService.RollForSuccess(40))
            {
                IWeapon loot = DropLoot(maxLootLevel);
                Logger.Log($"{Name} dropped loot! Found a {loot.Name}");
                return loot;
            }
            else
            {
                return null;
            }

            
        }

        public virtual void TakeDamage(int damage)
        {
            Logger.Log($"{Name} took {damage} damage! Health remaining: {Health}");
            Health -= damage;
            if (Health <= 0)
            {
                Die();
            }
        }

        protected virtual IWeapon DropLoot(int maxLevel)
        {
            return WeaponsFactory.GetRandomLoot(maxLevel);
        }
    }
}