using System.Runtime.Serialization;

namespace CloneCraft.Models.Commands.Params
{
    [DataContract]
    public class MineParams
    {
        public MineParams(int x, int y)
        {
            X = x;
            Y = y;
        }
        [DataMember(Name = "x")]
        public int X { get; set; }
        [DataMember(Name = "y")]
        public int Y { get; set; }
    }
}