using System;
using System.Runtime.Serialization;
using CloneCraft.Models.Commands.Params;
using Newtonsoft.Json;

namespace CloneCraft.Models.Commands
{
    [DataContract]
    public class AttackCommand : Command
    {
        public AttackCommand(int minionId, int x, int y)
        {
            CommandName = "attack";
            MinionId = minionId;
            Params = new AttackParams(x, y);
        }

        [DataMember(Name = "params")]
        public AttackParams Params { get; set; }
    }
}