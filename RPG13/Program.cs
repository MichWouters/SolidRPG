using RPG13;
using RPG13.Factories;
using RPG13.Factories.Interfaces;
using RPG13.Logging;
using RPG13.Player;
using RPG13.Service;
using RPG13.Services;

// 3. Dependencies are initialised at the TOP of the application
ILogger logger = new ConsoleLogger();
IDiceService diceService = new DiceService();
IPlayerFactory playerFactory = new PlayerFactory(logger, diceService);
IWeaponsFactory weaponsFactory = new WeaponsFactory();
IRandomService randomService = new RandomService();
IEnemyFactory enemyFactory = new EnemyFactory(randomService, weaponsFactory, logger);
IGame game = new Game(logger, enemyFactory, weaponsFactory, playerFactory);

game.StartGame(logger);
IPlayer player = game.CreatePlayer();
game.CreateAndEquipDefaultWeapon(player);
game.StartEncounter(player);
game.EndGame(player);