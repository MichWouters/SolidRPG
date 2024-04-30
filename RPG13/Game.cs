using RPG13.Enemies;
using RPG13.Factories;
using RPG13.Factories.Interfaces;
using RPG13.Logging;
using RPG13.Player;
using RPG13.Weapon;
using RPG13.Weapon.Interfaces;

namespace RPG13
{
    public class Game : IGame
    {
        // 1. Dependencies declareren we altijd bovenaan de klasse
        private ILogger Logger;
        private IEnemyFactory EnemyFactory;
        private IWeaponsFactory WeaponsFactory;
        private IPlayerFactory PlayerFactory;

        // 2. Dependencies initialiseren we in de constructor
        public Game(ILogger logger, IEnemyFactory enemyFactory, IWeaponsFactory weaponsFactory, IPlayerFactory playerFactory)
        {
            Logger = logger;
            EnemyFactory = enemyFactory;
            WeaponsFactory = weaponsFactory;
            PlayerFactory = playerFactory;
        }

        public void EndGame(IPlayer player)
        {
            Logger.LogEmptyLine();
            Logger.Log("Game over!");
            Logger.Log($"{player.Name} did {player.DamageDone} worth of damage and killed {player.EnemiesKilled} enemy(ies)");
            Console.ReadLine();
        }

        public void StartEncounter(IPlayer player)
        {
            Logger.LogEmptyLine();
            IEnemy enemy = EnemyFactory.SpawnRandomEnemy();
            player.Attack(enemy);
            enemy.Attack(player);
        }

        public void CreateAndEquipDefaultWeapon(IPlayer player)
        {
            IMeleeWeapon dagger = (IMeleeWeapon)WeaponsFactory.GetWeapon(WeaponEnum.Dagger);
            player.PickUpWeapon(dagger, true);
        }

        public IPlayer CreatePlayer()
        {
            int choice = int.Parse(Console.ReadLine());
            PlayerType playerType = (PlayerType)choice;
            IPlayer player = PlayerFactory.Create(playerType);
            return player;
        }

        public void StartGame(ILogger logger)
        {
            logger.Log("The dungeon lies before you!");
            logger.Log($"Pick your character.{Environment.NewLine}1. Human{Environment.NewLine}2. Elf{Environment.NewLine}3. Dwarf");
            logger.LogEmptyLine();
        }
    }
}