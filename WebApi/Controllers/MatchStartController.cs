using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CloneCraft.Interfaces;
using CloneCraft.Models;
using CloneCraft.Models.Entities;
using Newtonsoft.Json.Linq;

namespace CloneCraft.WebApi.Controllers
{
    public class MatchStartController : ApiController
    {
        private readonly ICommander _commander;
        public MatchStartController(ICommander commander)
        {
            _commander = commander;
        }

        public void Post([FromBody]JToken json)
        {
            var matchInfo = json.ToObject<MatchInfo>();
            _commander.StartingMatch(matchInfo);
        }
    }
}
