using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
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