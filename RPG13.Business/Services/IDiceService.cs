namespace RPG13.Business.Service
{
    public interface IDiceService
    {
        int RollDice(int maxSides = 6);

        int[] RollTheDices(int amount = 2);
    }
}