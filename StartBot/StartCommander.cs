using System.Linq;
using CloneCraft.Interfaces;
using CloneCraft.Models;
using CloneCraft.Models.Commands;
using System;
using System.Collections.Generic;
using CloneCraft.Models.Entities;

namespace CloneCraft.StartBot
{
    public class Commander : ICommander
    {
        private readonly Random _randomGenerator;
        private List<Command> _commands;
        private List<Minion> _miners;
        private List<Minion> _attackers;
        private BoardStatus _status;

        public Commander()
        {
            _randomGenerator = new Random();
        }

        // This method runs at the end of every game, you may want to use the game results
        public void GameResult(GameResult gameResult)
        {
            //you may want to adjust your strategy here if you lost a game
        }

        // This method runs at the start of every match
        public void StartingMatch(MatchInfo bestOf)
        {
            //you may want to reset and strategy adjustments from your previous match
            //you may want to hardcode certain strategies against certain opponents
        }

        // This method runs at the start of a new game, do any initialization or resetting here 
        public string StartingGame()
        {
            return "good to go!";
        }

        // Do not alter/remove this method signature
        public List<Command> GetCommands(BoardStatus status)
        {
            _status = status;
            _commands = new List<Command>
                {
                    //if its the first round build a miner otherwise try to build an attacker
                    status.Round == 1
                        ? new BuildLesserMinionCommand(1, 1, 1, 4, 2, 1, status.YourBase.X + 1, status.YourBase.Y - 1)
                        : new BuildLesserMinionCommand(3, 2, 1, 1, 2, 1, status.YourBase.X + 1, status.YourBase.Y - 1)
                };

            AssignMinionRoles(status);

            GoMining(_miners);

            if (status.Vision.EnemyBases.Any())
            {
                MoveAndDestroy();
            }
            else
            {
                MoveAround(_attackers);
            }

            return _commands;
        }

        private void MoveAround(IEnumerable<Minion> minions)
        {
            foreach (var minion in minions)
            {
                _commands.Add(new MoveCommand(minion.Id, Constants.EastDirection)); //bug for those who start on the right base

                var directions = new[]
                    {
                        Constants.EastDirection, Constants.NorthDirection, Constants.SouthDirection,
                        Constants.WestDirection
                    };
                //wander
                var randomDirection = _randomGenerator.Next(4);
                _commands.Add(new MoveCommand(minion.Id, directions[randomDirection]));
                randomDirection = _randomGenerator.Next(4);
                _commands.Add(new MoveCommand(minion.Id, directions[randomDirection]));
            }
        }

        private void GoMining(IEnumerable<Minion> minions)
        {
            foreach (var miner in minions)
            {
                if (miner.Gold > 0) //carrying!
                {
                    var moveCommand = MoveNextTo(miner, _status.YourBase);
                    if (moveCommand != null) _commands.Add(moveCommand);
                }
                else //go mine!
                {
                    var closestResource = GetClosestResource(miner);
                    if (closestResource == null)
                    {
                        MoveAround(new List<Minion> { miner });
                        return;
                    }
                    var moveCommand = MoveNextTo(miner, closestResource);
                    if (moveCommand == null)
                    {
                        MineResource(miner, closestResource);
                    }
                    else
                    {
                        _commands.Add(moveCommand);
                    }
                }
            }
        }

        private Command MoveNextTo(Minion minion, Entity entity)
        {
            if (IsNextTo(minion, entity)) return null;

            var directions = new List<char>();
            if (minion.X - entity.X < 0) directions.Add(Constants.EastDirection); //need to travel east 
            if (minion.X - entity.X > 0) directions.Add(Constants.WestDirection);
            if (minion.Y - entity.Y > 0) directions.Add(Constants.NorthDirection);
            if (minion.Y - entity.Y < 0) directions.Add(Constants.SouthDirection);

            var randomDirection = _randomGenerator.Next(directions.Count);

            return new MoveCommand(minion.Id, directions[randomDirection]);
        }

        private void MoveAndDestroy()
        {
            var enemyBase = _status.Vision.EnemyBases.First();
            foreach (var minion in _attackers)
            {
                var moveCommand = MoveNextTo(minion, enemyBase);
                _commands.Add(moveCommand ?? new AttackCommand(minion.Id, enemyBase.X, enemyBase.Y));
            }
        }

        private void AssignMinionRoles(BoardStatus status)
        {
            _miners = new List<Minion>();
            _attackers = new List<Minion>();
            foreach (var minion in status.YourMinions)
            {
                if (minion.Mining > 30)
                {
                    _miners.Add(minion);
                }
                else
                {
                    _attackers.Add(minion);
                }
            }
        }

        private Resource GetClosestResource(Minion miner)
        {
            if (_status.Vision.Resources == null || !_status.Vision.Resources.Any()) return null;
            Resource resourceTarget = null;
            foreach (var resource in _status.Vision.Resources)
            {
                resourceTarget = resource; //just kidding! use the last one in the list
            }
            return resourceTarget;
        }

        private void MineResource(Minion minion, Resource resource)
        {
            _commands.Add(new MineCommand(minion.Id, resource.X, resource.Y));
        }

        private static bool IsNextTo(Entity fromEntity, Entity toEntity)
        {
            var fromSize = 1;
            var toSize = 1;
            if (fromEntity is Base)
            {
                fromSize = (fromEntity as Base).Size;
            }
            if (toEntity is Base)
            {
                toSize = (toEntity as Base).Size;
            }
            if (fromSize == 1 && toSize == 1)
            {
                return CoordsAreAdjacent(fromEntity.X, fromEntity.Y, toEntity.X, toEntity.Y);
            }
            //TODO: check if next to any cell of base not just top left corner
            return CoordsAreAdjacent(fromEntity.X, fromEntity.Y, toEntity.X, toEntity.Y);
        }

        private static bool CoordsAreAdjacent(int x1, int y1, int x2, int y2)
        {
            var toSide = Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 0;
            var aboveOrBelow = Math.Abs(x1 - x2) == 0 && Math.Abs(y1 - y2) == 1;
            return toSide || aboveOrBelow;
        }
    }
}