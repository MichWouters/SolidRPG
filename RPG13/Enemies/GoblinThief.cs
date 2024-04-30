using RPG13.Player;
using RPG13.Services;

namespace RPG13.Enemies
{
    public class GoblinThief : Enemy
    {
        private IRandomService randomService;

        public GoblinThief(): base("Sneaky Goblin")
        {
            randomService = new RandomService();
            MinDamage = 1;
            Health = 10;
        }

        public override void TakeDamage(int damage)
        {
            bool canDodge = randomService.RollForSuccess(15);

            if (!canDodge)
            {
                base.TakeDamage(damage);
            }
        }

        public override void Attack(IPlayer player)
        {
            bool isCriticalHit = randomService.RollForSuccess(25);

            if (isCriticalHit)
            {
                int damage = randomService.GetRandomValue(MinDamage, MaxDamage);
                logger.Log($"{Name} landed a critical hit! Double damage!");
                player.TakeDamage(damage * 2);
            }
            else
            {
                base.Attack(player);
            }
        }
    }
}