using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    [DataContract]
    public class Base : Entity
    {
        public int Size = 3;
        [DataMember(Name = "h")]
        public int Health { get; set; }
        [DataMember(Name = "g")]
        public int Gold { get; set; }
    }
}