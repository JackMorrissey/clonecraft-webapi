using System.Runtime.Serialization;

namespace CloneCraft.Models.Entities
{
    [DataContract]
    public class Minion : Entity
    {
        [DataMember(Name = "g")]
        public int Gold { get; set; }
        [DataMember(Name = "hp")]
        public int Health { get; set; }
        [DataMember(Name = "mi")]
        public int Mining { get; set; }
        [DataMember(Name = "r")]
        public int Range { get; set; }
        [DataMember(Name = "d")]
        public int Damage { get; set; }
        [DataMember(Name = "sp")]
        public int Speed { get; set; }
        [DataMember(Name = "vi")]
        public int Vision { get; set; }
    }
}