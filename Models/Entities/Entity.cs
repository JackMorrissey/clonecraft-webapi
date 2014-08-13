using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    [DataContract]
    public abstract class Entity
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int X { get; set; }
        [DataMember]
        public int Y { get; set; }
    }
}