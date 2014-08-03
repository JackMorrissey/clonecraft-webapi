using CloneCraft.Models.Commands.Params;
using Newtonsoft.Json;

namespace CloneCraft.Models.Commands
{
    public class AttackCommand : Command
    {
        public AttackCommand(int minionId, int x, int y)
        {
            CommandName = "attack";
            MinionId = minionId;
            Params = new AttackParams(x, y);
        }

        [JsonProperty("params")]
        public AttackParams Params { get; set; }
    }
}