using System.Runtime.Serialization;
using CloneCraft.Models.Commands.Params;

namespace CloneCraft.Models.Commands
{
    [DataContract]
    public class HandOffCommand : Command
    {
        public HandOffCommand(int handerId, int handeeId)
        {
            CommandName = "hand off";
            MinionId = handerId;
            Params = new HandOffParams(handeeId);
        }

        [DataMember(Name = "params")]
        public HandOffParams Params { get; set; }
    }
}