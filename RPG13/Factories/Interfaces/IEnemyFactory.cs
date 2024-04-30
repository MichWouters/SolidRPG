using RPG13.Enemies;

namespace RPG13.Factories.Interfaces
{
    public interface IEnemyFactory
    {
        IEnemy SpawnRandomEnemy();

        IEnemy Create(EnemyType type);
    }
}