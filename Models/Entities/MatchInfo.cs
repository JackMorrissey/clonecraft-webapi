using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    public class MatchInfo
    {
        [JsonProperty("best_of")]
        public int BestOf { get; set; }
        [JsonProperty("opponent_name")]
        public string OpponentName { get; set; }
    }
}
