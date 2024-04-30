using RPG13.Logging;
using RPG13.Service;

namespace RPG13.Player
{
    public class Dwarf : Player
    {
        public Dwarf(IDiceService diceService, ILogger logger, string name) : base(diceService, logger, name)
        {
            Strength = DiceService.RollTheDices(3).Sum();
            Intelligence = DiceService.RollTheDices(1).Sum();
            Health = DiceService.RollTheDices(4).Sum();

            Logger.Log(this.ToString());
        }
    }
}