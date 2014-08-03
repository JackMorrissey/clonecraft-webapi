using System.Web.Http;

namespace CloneCraft.WebApi.Controllers
{
    public class HeartbeatController : ApiController
    {
        /// <summary>
        /// Thump Thump
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            return "Heart is beating!";
        }
    }
}