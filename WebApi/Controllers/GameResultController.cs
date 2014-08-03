using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CloneCraft.Interfaces;
using CloneCraft.Models.Entities;

namespace CloneCraft.WebApi.Controllers
{
    public class GameResultController : ApiController
    {
        private readonly ICommander _commander;
        public GameResultController(ICommander commander)
        {
            _commander = commander;
        }
        public void Post(GameResult gameResult)
        {
            _commander.GameResult(gameResult);
        }
    }
}
