using RPG13.Factories;
using RPG13.Factories.Interfaces;
using RPG13.Logging;
using RPG13.Player;
using RPG13.Services;
using RPG13.Weapon.Interfaces;

namespace RPG13.Enemies
{
    public abstract class Enemy : IEnemy
    {
        private IRandomService randomService;
        private IWeaponsFactory weaponsFactory;
        protected ILogger logger;

        public int Health { get; protected set; } = 20;
        public int MaxDamage { get; protected set; }
        public int MinDamage { get; protected set; }
        public string Name { get; protected set; }

        public Enemy(string name)
        {
            weaponsFactory = new WeaponsFactory();
            randomService = new RandomService();
            logger = new ConsoleLogger();

            Name = name;
            logger.Log($"A wild {Name} appeared!");
        }

        public virtual void Attack(IPlayer player)
        {
            int damage = randomService.GetRandomValue(MinDamage, MaxDamage);
            player.TakeDamage(damage);
        }

        public IWeapon? Die(int maxLootLevel = 3)
        {
            logger.Log($"{Name} died!");
            if (randomService.RollForSuccess(40))
            {
                IWeapon loot = DropLoot(maxLootLevel);
                logger.Log($"{Name} dropped loot! Found a {loot.Name}");
                return loot;
            }
            else
            {
                return null;
            }

            
        }

        public virtual void TakeDamage(int damage)
        {
            logger.Log($"{Name} took {damage} damage! Health remaining: {Health}");
            Health -= damage;
            if (Health <= 0)
            {
                Die();
            }
        }

        protected virtual IWeapon DropLoot(int maxLevel)
        {
            return weaponsFactory.GetRandomLoot(maxLevel);
        }
    }
}