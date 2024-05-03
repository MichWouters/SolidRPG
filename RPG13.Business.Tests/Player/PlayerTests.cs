using Moq;
using RPG13.Business.Enemies;
using RPG13.Business.Factories.Interfaces;
using RPG13.Business.Logging;
using RPG13.Business.Player;
using RPG13.Business.Service;
using RPG13.Business.Services;

namespace RPG13.Business.Tests.Player
{
    internal class PlayerTests
    {
        [Test]
        public void WhenPlayerAttacks_ThenDamageDone_ShouldBeAddedToTotalDamage()
        {
            // Arrange -> Gather all data necessary here
            Mock<ILogger> mockLogger = new Mock<ILogger>();
            Mock<IDiceService> mockDiceService = new Mock<IDiceService>();
            Mock<IRandomService> mockRandomService = new Mock<IRandomService>();
            Mock<IWeaponsFactory> mockWeaponsFactory = new Mock<IWeaponsFactory>();

            string name = "Foobar the feeble";
            int expectedDamage = 0;

            IPlayer playerUnderTest = new Human(mockDiceService.Object, mockLogger.Object, name);
            IEnemy unluckyGoblin = new Goblin(mockRandomService.Object, mockWeaponsFactory.Object, mockLogger.Object);

            // Act -> Execute the method under test here
            playerUnderTest.Attack(unluckyGoblin);

            // Assert -> Validate that the result is what was expected
            Assert.That(playerUnderTest.DamageDone, Is.EqualTo(expectedDamage));
        }


        [Test]
        public void WhenPlayerTakesDamage_TheirHealthIsDecreased()
        {
            // Arrange
            int playerHP = 100;
            int expectedHP = 95;
            int damage = 5;

            Mock<IDiceService> mockDiceService = new Mock<IDiceService>();
            Mock<ILogger> mockLogger = new Mock<ILogger>();
            string name = "Foobar the feeble";

            IPlayer unluckyPlayer = new Human(mockDiceService.Object, mockLogger.Object, name);
            unluckyPlayer.Health = playerHP;

            // Act
            unluckyPlayer.TakeDamage(damage);

            // Assert
            Assert.That(unluckyPlayer.Health, Is.EqualTo(expectedHP));
        }
    }
}