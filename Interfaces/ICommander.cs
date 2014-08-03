using System.Collections.Generic;
using CloneCraft.Models.Commands;
using CloneCraft.Models.Entities;

namespace CloneCraft.Interfaces
{
    public interface ICommander
    {
        void GameResult(GameResult gameResult);
        void StartingMatch(MatchInfo bestOf);
        string StartingGame();
        List<Command> GetCommands(BoardStatus status);
    }
}
