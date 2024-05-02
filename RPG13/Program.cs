using Microsoft.Extensions.DependencyInjection;
using RPG13;
using RPG13.Player;

// 3. Dependencies are initialised at the TOP of the application
//ILogger logger = new CloudLogger();
//IDiceService diceService = new DiceService();
//IPlayerFactory playerFactory = new PlayerFactory(logger, diceService);
//IWeaponsFactory weaponsFactory = new WeaponsFactory();
//IRandomService randomService = new RandomService();
//IEnemyFactory enemyFactory = new EnemyFactory(randomService, weaponsFactory, logger);
//IGame game = new Game(logger, enemyFactory, weaponsFactory, playerFactory);

// 4. Better way using a Dependency Injection framework
ServiceCollection serviceCollection = new Startup().RegisterServices();
ServiceProvider provider = serviceCollection.BuildServiceProvider();
IGame game = provider.GetService<IGame>();

game.StartGame();
IPlayer player = game.CreatePlayer();
game.CreateAndEquipDefaultWeapon(player);
game.StartEncounter(player);
game.EndGame(player);