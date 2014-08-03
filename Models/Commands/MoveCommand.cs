using CloneCraft.Models.Commands.Params;
using Newtonsoft.Json;

namespace CloneCraft.Models.Commands
{
    public class MoveCommand : Command
    {
        public MoveCommand(int minionId, char direction)
        {
            CommandName = "move";
            MinionId = minionId;
            Params = new MoveParams(direction);
        }

        [JsonProperty("params")]
        public MoveParams Params { get; set; }
    }
}