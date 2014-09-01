using System.Collections.Generic;
using System.Web.Http;
using CloneCraft.Interfaces;
using CloneCraft.Models;
using CloneCraft.Models.Commands;
using Newtonsoft.Json.Linq;

namespace CloneCraft.WebApi.Controllers
{
    public class TurnController : ApiController
    {
        private readonly ICommander _commander;
        public TurnController(ICommander commander)
        {
            _commander = commander;
        }

        public List<Command> Post([FromBody]JToken json)
        {
            var boardStatus = json.ToObject<BoardStatus>();
            if (boardStatus.Round == 1) _commander.Initialize(boardStatus);

            // Create commands to do
            var commands = _commander.GetCommands(boardStatus);
            return commands;
        }
    }
}
