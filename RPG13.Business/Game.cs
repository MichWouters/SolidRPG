using RPG13.Business.Enemies;
using RPG13.Business.Factories.Interfaces;
using RPG13.Business.Logging;
using RPG13.Business.Player;
using RPG13.Business.Services;
using RPG13.Business.Weapon;
using RPG13.Business.Weapon.Interfaces;

namespace RPG13.Business
{
    public class Game : IGame
    {
        // 1. Dependencies declareren we altijd bovenaan de klasse
        public ILogger Logger { get; private set; }
        private IUserInteraction UserInteraction;
        private IEnemyFactory EnemyFactory;
        private IWeaponsFactory WeaponsFactory;
        private IPlayerFactory PlayerFactory;

        // 2. Dependencies initialiseren / injecteren we in de constructor
        public Game(ILogger logger, IEnemyFactory enemyFactory, IWeaponsFactory weaponsFactory, IPlayerFactory playerFactory, IUserInteraction userInteraction)
        {
            Logger = logger;
            EnemyFactory = enemyFactory;
            WeaponsFactory = weaponsFactory;
            PlayerFactory = playerFactory;
            UserInteraction = userInteraction;
        }

        public void EndGame(IPlayer player)
        {
            Logger.LogEmptyLine();
            Logger.Log("Game over!");
            Logger.Log($"{player.Name} did {player.DamageDone} worth of damage and killed {player.EnemiesKilled} enemy(ies)");
            UserInteraction.GetUserInput();
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
            int choice = int.Parse(UserInteraction.GetUserInput());
            PlayerType playerType = (PlayerType)choice;
            IPlayer player = PlayerFactory.Create(playerType);
            return player;
        }

        public void StartGame()
        {
            Logger.Log("The dungeon lies before you!");
            Logger.Log($"Pick your character.{Environment.NewLine}1. Human{Environment.NewLine}2. Elf{Environment.NewLine}3. Dwarf");
            Logger.LogEmptyLine();
        }
    }
}