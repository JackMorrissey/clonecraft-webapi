using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    public class GameResult
    {
        [JsonProperty("won")]
        public bool Won { get; set; }
        [JsonProperty("match_over")]
        public bool MatchOver { get; set; }
    }
}