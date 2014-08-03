using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CloneCraft.Interfaces;

namespace CloneCraft.WebApi.Controllers
{
    public class ResetController : ApiController
    {
        private readonly ICommander _commander;
        public ResetController(ICommander commander)
        {
            _commander = commander;
        }

        public string Get()
        {
            return _commander.StartingGame();
        }
    }
}
