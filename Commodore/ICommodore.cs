using CloneCraft.Interfaces;

namespace CloneCraft.Commodore
{
    public interface ICommodore
    {
        ICommander GetCommander(string gameId);
    }
}
