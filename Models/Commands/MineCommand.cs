using System.Runtime.Serialization;
using CloneCraft.Models.Commands.Params;

namespace CloneCraft.Models.Commands
{
    [DataContract]
    public class MineCommand : Command
    {
        public MineCommand(int minionId, int x, int y)
        {
            CommandName = "mine";
            MinionId = minionId;
            Params = new MineParams(x, y);
        }

        [DataMember(Name = "params")]
        public MineParams Params { get; set; }
    }
}