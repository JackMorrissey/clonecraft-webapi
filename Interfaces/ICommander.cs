using System.Collections.Generic;
using CloneCraft.Models.Commands;
using CloneCraft.Models.Entities;

namespace CloneCraft.Interfaces
{
    public interface ICommander
    {
        /// <summary>
        /// This method runs at the end of every game, you may want to use the game results
        /// You may want to adjust your strategy if you lost a game
        /// </summary>
        /// <param name="gameResult"></param>
        void GameResult(GameResult gameResult);
        
        /// <summary>
        /// This method runs at the start of every match
        /// you may want to reset and strategy adjustments from your previous match
        /// you may want to hardcode certain strategies against certain opponents
        /// </summary>
        /// <param name="matchInfo"></param>
        void StartingMatch(MatchInfo matchInfo);
        
        /// <summary>
        /// This method runs at the start of a new game on turn 1, do any initialization or resetting here
        /// </summary>
        /// <returns></returns>
        void Initialize(BoardStatus status);
        
        /// <summary>
        /// Given a status, do these commands
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        List<Command> GetCommands(BoardStatus status);
    }
}
