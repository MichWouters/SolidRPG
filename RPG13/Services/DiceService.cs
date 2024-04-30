﻿namespace RPG13.Service
{
    public class DiceService : IDiceService
    {
        public int RollDice()
        {
            Random random = new Random();
            return random.Next(1, 7);
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