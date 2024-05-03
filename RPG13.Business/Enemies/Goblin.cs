using RPG13.Business.Factories.Interfaces;
using RPG13.Business.Logging;
using RPG13.Business.Services;

namespace RPG13.Business.Enemies
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