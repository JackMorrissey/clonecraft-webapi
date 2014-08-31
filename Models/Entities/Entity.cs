using System;
using System.Runtime.Serialization;
using CloneCraft.Models.Interfaces;
using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    [DataContract]
    public abstract class Entity: IEntity
    {
        [DataMember]
        public int Id { get; set; }

        public virtual int Size
        {
            get { return 1; }
        }

        [DataMember]
        public int X { get; set; }
        [DataMember]
        public int Y { get; set; }
    }
}