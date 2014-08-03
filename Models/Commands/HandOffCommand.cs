using CloneCraft.Models.Commands.Params;
using Newtonsoft.Json;

namespace CloneCraft.Models.Commands
{
    public class HandOffCommand : Command
    {
        public HandOffCommand(int handerId, int handeeId)
        {
            CommandName = "hand off";
            MinionId = handerId;
            Params = new HandOffParams(handeeId);
        }

        [JsonProperty("params")]
        public HandOffParams Params { get; set; }
    }
}