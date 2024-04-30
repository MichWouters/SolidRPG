namespace RPG13.Service
{
    public interface IDiceService
    {
        int RollDice();

        int[] RollTheDices(int amount = 2);
    }
}