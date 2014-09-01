using System.Web.Http;
using CloneCraft.Interfaces;
using CloneCraft.Models;
using Newtonsoft.Json.Linq;

namespace CloneCraft.WebApi.Controllers
{
    //TODO: replace this with a Commodore once matches have game associations
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
