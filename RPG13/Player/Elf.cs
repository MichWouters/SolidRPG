namespace RPG13.Player
{
    public class Elf : Player
    {
        public Elf(string name) : base(name)
        {
            Strength = diceService.RollTheDices(1).Sum();
            Intelligence = diceService.RollTheDices(3).Sum();
            Health = diceService.RollTheDices(2).Sum();

            logger.Log(this.ToString());
        }
    }
}