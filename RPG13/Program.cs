using RPG13.Enemies;
using RPG13.Factories;
using RPG13.Factories.Interfaces;
using RPG13.Logging;
using RPG13.Player;
using RPG13.Weapon;
using RPG13.Weapon.Interfaces;

// Dependencies
IPlayerFactory factory = new PlayerFactory();
IWeaponsFactory weaponsFactory = new WeaponsFactory();
IEnemyFactory enemyFactory = new EnemyFactory();
ILogger logger = new ConsoleLogger();

// Start game
logger.Log("The dungeon lies before you!");
logger.Log($"Pick your character.{Environment.NewLine}1. Human{Environment.NewLine}2. Elf{Environment.NewLine}3. Dwarf");
logger.LogEmptyLine();

// Create Player
int choice = int.Parse(Console.ReadLine());
PlayerType playerType = (PlayerType)choice;
IPlayer player = factory.Create(playerType);

// Create and equip default weapon
IMeleeWeapon dagger = (IMeleeWeapon)weaponsFactory.GetWeapon(WeaponEnum.Dagger);
player.PickUpWeapon(dagger, true);

// Start encounter
logger.LogEmptyLine();
IEnemy enemy = enemyFactory.SpawnRandomEnemy();
player.Attack(enemy);
enemy.Attack(player);

// End game
logger.LogEmptyLine();
logger.Log("Game over!");
logger.Log($"{player.Name} did {player.DamageDone} worth of damage and killed {player.EnemiesKilled} enemy(ies)");
Console.ReadLine();