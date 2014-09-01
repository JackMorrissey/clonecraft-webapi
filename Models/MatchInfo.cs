using System.Runtime.Serialization;

namespace CloneCraft.Models
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
