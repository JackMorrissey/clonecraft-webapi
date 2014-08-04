using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloneCraft.Models.Commands.Params
{
    [DataContract]
    public class MoveParams
    {
        public MoveParams(char direction)
        {
            Direction = direction;
        }
        [DataMember(Name = "direction")]
        public char Direction { get; set; }
    }
}