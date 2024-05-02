using RPG13.Enemies;
using RPG13.Factories.Interfaces;
using RPG13.Logging;
using RPG13.Services;

namespace RPG13.Factories
{
    public class EnemyFactory : IEnemyFactory
    {
        private IRandomService randomService;
        private IWeaponsFactory weaponsFactory;
        private ILogger logger;

        public EnemyFactory(IRandomService randomService, IWeaponsFactory weaponsFactory, ILogger logger)
        {
            this.randomService = randomService;
            this.weaponsFactory = weaponsFactory;
            this.logger = logger;
        }

        public IEnemy Create(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Goblin:
                    return new Goblin(randomService, weaponsFactory, logger);

                case EnemyType.GoblinThief:
                    return new GoblinThief(randomService, weaponsFactory, logger);

                case EnemyType.GoblinWithShield:
                    return new GoblinWithShield(randomService, weaponsFactory, logger);

                default: throw new ArgumentException(nameof(type));
            }
        }

        public IEnemy SpawnRandomEnemy()
        {
            int amountOfEnemytypes = Enum.GetNames(typeof(EnemyType)).Length;
            int randomEnemy = new Random().Next(0, amountOfEnemytypes);
            EnemyType selectedEnemy = (EnemyType)randomEnemy;

            return Create(selectedEnemy);
        }
    }
}