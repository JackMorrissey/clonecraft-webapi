using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    public class Minion : Entity
    {
        [JsonProperty("g")]
        public int Gold { get; set; }
        [JsonProperty("hp")]
        public int Health { get; set; }
        [JsonProperty("mi")]
        public int Mining { get; set; }
        [JsonProperty("r")]
        public int Range { get; set; }
        [JsonProperty("d")]
        public int Damage { get; set; }
        [JsonProperty("sp")]
        public int Speed { get; set; }
        [JsonProperty("vi")]
        public int Vision { get; set; }
    }
}