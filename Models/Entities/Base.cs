using System.Runtime.Serialization;

namespace CloneCraft.Models.Entities
{
    [DataContract]
    public class Base : Entity
    {
        public override int Size {
            get { return 3; }
        }

        [DataMember(Name = "h")]
        public int Health { get; set; }
        [DataMember(Name = "g")]
        public int Gold { get; set; }
    }
}