using RPG13.Factories.Interfaces;
using RPG13.Logging;
using RPG13.Player;
using RPG13.Services;

namespace RPG13.Enemies
{
    public class GoblinThief : Enemy
    {
        public GoblinThief(IRandomService randomService, IWeaponsFactory weaponsFactory, ILogger logger)
            : base(randomService, weaponsFactory, logger, "Sneaky Goblin")
        {
            MinDamage = 1;
            Health = 10;
        }

        public override void TakeDamage(int damage)
        {
            bool canDodge = _randomService.RollForSuccess(15);

            if (!canDodge)
            {
                base.TakeDamage(damage);
            }
        }

        public override void Attack(IPlayer player)
        {
            bool isCriticalHit = _randomService.RollForSuccess(25);

            if (isCriticalHit)
            {
                int damage = _randomService.GetRandomValue(MinDamage, MaxDamage);
                _logger.Log($"{Name} landed a critical hit! Double damage!");
                player.TakeDamage(damage * 2);
            }
            else
            {
                base.Attack(player);
            }
        }
    }
}