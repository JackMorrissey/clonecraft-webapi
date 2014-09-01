using System.Runtime.Serialization;

namespace CloneCraft.Models.Entities
{
    [DataContract]
    public class GameResult
    {
        [DataMember(Name = "id")]
        public string GameId { get; set; }
        [DataMember(Name = "won")]
        public bool Won { get; set; }
        [DataMember(Name = "match_over")]
        public bool MatchOver { get; set; }
    }
}