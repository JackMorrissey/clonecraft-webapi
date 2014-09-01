using System.Collections.Generic;
using System.Runtime.Serialization;
using CloneCraft.Models.Entities;

namespace CloneCraft.Models
{
    [DataContract]
    public class BoardStatus
    {

        [DataMember]
        public string GameId { get; set; }
        [DataMember]
        public int Round { get; set; }
        [DataMember]
        public Board Board { get; set; }
        [DataMember(Name = "base")]
        public Base YourBase { get; set; }
        [DataMember(Name = "minions")]
        public List<Minion> YourMinions { get; set; }
        [DataMember]
        public Vision Vision { get; set; }
        [DataMember]
        public int NextMinionId { get; set; }
    }
}