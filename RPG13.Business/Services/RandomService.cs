namespace RPG13.Business.Services
{
    public class RandomService : IRandomService
    {
        private Random random = new Random();

        public int GetRandomValue(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
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