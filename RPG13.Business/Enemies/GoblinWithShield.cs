using RPG13.Business.Factories.Interfaces;
using RPG13.Business.Logging;
using RPG13.Business.Services;

namespace RPG13.Business.Enemies
{
    public class GoblinWithShield : Enemy
    {
        public GoblinWithShield(IRandomService randomService, IWeaponsFactory weaponsFactory, ILogger logger)
            : base(randomService, weaponsFactory, logger, "Goblin with Shield")
        {
            MinDamage = 4;
            MaxDamage = 7;
            Health = 40;
        }

        public override void TakeDamage(int damage)
        {
            bool ableToBlock = _randomService.RollForSuccess(25);
            if (!ableToBlock)
            {
                base.TakeDamage(damage);
            }
            else
            {
                _logger.Log($"{Name} was able to block! Enemy took no damage!");
            }
        }
    }
}