namespace RPG13.Business.Service
{
    public class DiceService : IDiceService
    {
        public int RollDice(int maxSides = 6)
        {
            Random random = new Random();
            return random.Next(1, maxSides + 1);
        }

        public int[] RollTheDices(int amount = 2)
        {
            var result = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                result[i] = RollDice();
            }

            return result;
        }
    }
}