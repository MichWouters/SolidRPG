SOLID Exercise -> Create a basic RPG
Your company is working on creating a Console app, a simple RPG game. Your task is to make the following objects SOLID, extendable, and reusable. You are required to meet at least the following requirements.
Make extensive use of SOLID principles and abstraction (Interfaces & Factories) to implement the below as correctly as possible. Keep it simple though! This is a task for just a few hours. Also, abstractly log all actions to the console (Player created, enemy dealt damage, etc.). For this assignment, working in groups of 2 - 3 is allowed. Good luck!
(Try to keep the code simple, it's just an exercise. Beware the feature creep)
Player creation.
Players have at least 3 parameters: Strength, Intelligence, and Hitpoints. These statistics are rolled; the game uses X number of 6-sided dice to determine the player's statistics. From now on, dice will be indicated as XdY -> X number of dice, Y number of sides. For example, 2d6 means 2 standard dice. The number of dice is determined by the player's race.
Race Dice(Strength, Intelligence, Health)
Human 2D6
Elf 1D6, 3D6, 2D6
Dwarf 4D6, 1D6, 2D6
Weapons
Players have 2 ways of attacking: Melee with Strength weapons and Ranged with Int weapons. Weapons have at least the following properties:

Primary attribute (Strength or Int)
Minimum Strength
Minimum Intelligence
Damage
If a player does not meet the minimum attributes, a weapon cannot be used. When creating a player, default them with a dagger. Minimum strength: 1, minimum intelligence: 1, damage: 2.
Monster Attacks
When attacking monsters, the gameplay loop is calculated as follows: The player attacks first: damage * Primary attribute. If the damage exceeds the enemy's health, the gameplay loop ends. If an enemy dies, there is a chance it will drop a weapon.
Enemy Types
Default: No bonus
Shield: A shield gives an enemy a 25% chance to block some of the damage.
Critical: This type of enemy has a chance to deal 2X critical damage.
Then the enemy attacks. An enemy has hard-coded minimum and maximum damage. If the player's health is depleted, the game ends. Then log the number of defeated enemies and the total amount of damage the player has dealt. Display a game-over message afterward.
