using System.Collections.Generic;
using System.Web.Http;
using CloneCraft.Commodore;
using CloneCraft.Models;
using CloneCraft.Models.Commands;
using Newtonsoft.Json.Linq;

namespace CloneCraft.WebApi.Controllers
{
    public class TurnController : ApiController
    {
        private readonly ICommodore _commodore;
        public TurnController(ICommodore commodore)
        {
            _commodore = commodore;
        }

        public List<Command> Post([FromBody]JToken json)
        {
            var boardStatus = json.ToObject<BoardStatus>();
            var commander = _commodore.GetCommander(boardStatus.GameId);
            if (boardStatus.Round == 1) commander.Initialize(boardStatus);

            // Create commands to do
            var commands = commander.GetCommands(boardStatus);
            return commands;
        }
    }
}
