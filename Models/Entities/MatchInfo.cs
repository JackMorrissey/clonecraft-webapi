using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    [DataContract]
    public class MatchInfo
    {
        [DataMember(Name = "best_of")]
        public int BestOf { get; set; }
        [DataMember(Name = "opponent_name")]
        public string OpponentName { get; set; }
    }
}
