using System.Collections.Generic;
using System.Runtime.Serialization;
using CloneCraft.Models.Entities;

namespace CloneCraft.Models
{
    [DataContract]
    public class Vision
    {
        [DataMember(Name = "bases")]
        public List<Base> EnemyBases { get; set; }
        [DataMember(Name = "minions")]
        public List<Minion> EnemyMinions { get; set; }
        [DataMember]
        public List<Resource> Resources { get; set; }
    }
}