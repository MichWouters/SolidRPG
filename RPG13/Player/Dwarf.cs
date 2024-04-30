namespace RPG13.Player
{
    public class Dwarf : Player
    {
        public Dwarf(string name) : base(name)
        {
            Strength = diceService.RollTheDices(3).Sum();
            Intelligence = diceService.RollTheDices(1).Sum();
            Health = diceService.RollTheDices(4).Sum();

            logger.Log(this.ToString());
        }
    }
}