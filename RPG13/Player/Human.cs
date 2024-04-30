using RPG13.Logging;
using RPG13.Service;

namespace RPG13.Player
{
    public class Human : Player
    {
        public Human(IDiceService diceService, ILogger logger, string name) : base(diceService, logger, name)
        {
            Strength = DiceService.RollTheDices().Sum();
            Intelligence = DiceService.RollTheDices().Sum();
            Health = DiceService.RollTheDices().Sum();

            Logger.Log(this.ToString());
        }
    }
}