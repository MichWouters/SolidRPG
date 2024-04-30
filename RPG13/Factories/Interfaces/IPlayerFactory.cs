using RPG13.Player;

namespace RPG13.Factories.Interfaces
{
    public interface IPlayerFactory
    {
        IPlayer Create(PlayerType playerType);
    }
}