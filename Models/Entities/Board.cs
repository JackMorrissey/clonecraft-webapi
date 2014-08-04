using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
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