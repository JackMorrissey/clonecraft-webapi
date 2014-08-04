using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    [DataContract]
    public class BoardStatus
    {
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