using Moq;
using RPG13.Business.Enemies;
using RPG13.Business.Factories.Interfaces;
using RPG13.Business.Logging;
using RPG13.Business.Services;

namespace RPG13.Business.Tests.Enemies
{
    internal class EnemyTests
    {
        [Test]
        public void WhenEnemyTakesDamage_TheirHealthIsDecreased()
        {
            //Arrange
            int enemyHP = 100;
            int expectedHP = 95;
            int damage = 5;

            Mock<IRandomService> randomService = new Mock<IRandomService>();
            Mock<IWeaponsFactory> weaponsFactory = new Mock<IWeaponsFactory>();
            Mock<ILogger> logger = new Mock<ILogger>();

            IEnemy goblin = new Goblin(randomService.Object, weaponsFactory.Object, logger.Object);
            goblin.Health = enemyHP;
            //Act
            goblin.TakeDamage(damage);

            //Assert
            Assert.That(goblin.Health, Is.EqualTo(expectedHP));
        }
    }
}