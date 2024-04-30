using RPG13.Enemies;
using RPG13.Factories.Interfaces;

namespace RPG13.Factories
{
    public class EnemyFactory : IEnemyFactory
    {
        public IEnemy Create(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Goblin:
                    return new Goblin();

                case EnemyType.GoblinThief:
                    return new GoblinThief();

                case EnemyType.GoblinWithShield:
                    return new GoblinWithShield();

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