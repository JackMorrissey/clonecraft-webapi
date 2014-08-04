using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloneCraft.Models.Commands.Params
{
    [DataContract]
    public class AttackParams
    {
        public AttackParams(int x, int y)
        {
            X = x;
            Y = y;
        }
        [DataMember(Name = "x")]
        public int X { get; set; }
        [DataMember(Name = "y")]
        public int Y { get; set; }
    }
}