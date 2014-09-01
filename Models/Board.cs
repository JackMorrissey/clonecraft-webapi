using System.Runtime.Serialization;

namespace CloneCraft.Models
{
    [DataContract]
    public class Board
    {
        [DataMember(Name = "w")]
        public int Width { get; set; }
        [DataMember(Name = "h")]
        public int Height { get; set; }
    }
}