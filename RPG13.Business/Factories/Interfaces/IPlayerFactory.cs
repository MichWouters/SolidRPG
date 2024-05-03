using RPG13.Business.Player;

namespace RPG13.Business.Factories.Interfaces
{
    public interface IPlayerFactory
    {
        IPlayer Create(PlayerType playerType);
    }
}