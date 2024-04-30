using RPG13.Services;

namespace RPG13.Enemies
{
    public class GoblinWithShield : Enemy
    {
        private IRandomService randomService;

        public GoblinWithShield(): base("Goblin with Shield")
        {
            randomService = new RandomService();
            MinDamage = 4;
            MaxDamage = 7;
            Health = 40;
        }

        public override void TakeDamage(int damage)
        {
            bool ableToBlock = randomService.RollForSuccess(25);
            if (!ableToBlock)
            {
                base.TakeDamage(damage);
            }
            else
            {
                logger.Log($"{Name} was able to block! Enemy took no damage!");
            }
        }
    }
}