using System.Runtime.Serialization;
using CloneCraft.Models.Commands.Params;

namespace CloneCraft.Models.Commands
{
    [DataContract]
    public class MoveCommand : Command
    {
        public MoveCommand(int minionId, char direction)
        {
            CommandName = "move";
            MinionId = minionId;
            Params = new MoveParams(direction);
        }

        [DataMember(Name = "params")]
        public MoveParams Params { get; set; }
    }
}