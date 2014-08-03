using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    public abstract class Entity
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}