using System.Runtime.Serialization;

namespace CloneCraft.Models.Commands.Params
{
    [DataContract]
    public class MoveParams
    {
        public MoveParams(char direction)
        {
            Direction = direction;
        }
        [DataMember(Name = "direction")]
        public char Direction { get; set; }
    }
}