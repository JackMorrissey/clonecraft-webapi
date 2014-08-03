using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CloneCraft.Interfaces;
using CloneCraft.Models.Commands;
using CloneCraft.Models.Entities;

namespace CloneCraft.WebApi.Controllers
{
    public class TurnController : ApiController
    {
        private readonly ICommander _commander;
        public TurnController(ICommander commander)
        {
            _commander = commander;
        }

        public List<Command> Post(BoardStatus boardStatus)
        {
            if (boardStatus.Round == 1) _commander.StartingGame();

            // Create commands to do
            var commands = _commander.GetCommands(boardStatus);
            return commands;
        }
    }
}
