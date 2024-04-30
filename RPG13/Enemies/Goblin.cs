using RPG13.Factories.Interfaces;
using RPG13.Logging;
using RPG13.Services;

namespace RPG13.Enemies
{
    public class Goblin : Enemy
    {
        public Goblin(IRandomService randomService, IWeaponsFactory weaponsFactory, ILogger logger)
            : base(randomService, weaponsFactory, logger, "Max the goblin")
        {
            Health = 20;
            MinDamage = 3;
            MaxDamage = 5;
        }
    }
}