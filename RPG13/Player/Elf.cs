using RPG13.Logging;
using RPG13.Service;

namespace RPG13.Player
{
    public class Elf : Player
    {
        public Elf(IDiceService diceService, ILogger logger, string name) : base(diceService, logger, name)
        {
            Strength = DiceService.RollTheDices(1).Sum();
            Intelligence = DiceService.RollTheDices(3).Sum();
            Health = DiceService.RollTheDices(2).Sum();

            Logger.Log(this.ToString());
        }
    }
}