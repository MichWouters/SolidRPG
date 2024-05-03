using RPG13.Business.Enemies;

namespace RPG13.Business.Factories.Interfaces
{
    public interface IEnemyFactory
    {
        IEnemy SpawnRandomEnemy();

        IEnemy Create(EnemyType type);
    }
}