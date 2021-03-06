﻿using System.Web.Http;
using CloneCraft.Interfaces;
using CloneCraft.Models;
using Newtonsoft.Json.Linq;

namespace CloneCraft.WebApi.Controllers
{
    //TODO: replace this with a Commodore once matches have game associations
    public class GameResultController : ApiController
    {
        private readonly ICommander _commander;
        public GameResultController(ICommander commander)
        {
            _commander = commander;
        }
        public void Post([FromBody]JToken json)
        {
            var gameResult = json.ToObject<GameResult>();
            _commander.GameResult(gameResult);
        }
    }
}
