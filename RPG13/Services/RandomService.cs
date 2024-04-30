namespace RPG13.Services
{
    public class RandomService : IRandomService
    {
        private Random random = new Random();

        public int GetRandomValue(int minDamage, int maxDamage)
        {
            return random.Next(minDamage, maxDamage + 1);
        }

        public bool RollForSuccess(int chanceOfSuccess)
        {
            if (random.Next(100) < chanceOfSuccess)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}