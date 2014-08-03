using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    public class Base : Entity
    {
        public int Size = 3;
        [JsonProperty("h")]
        public int Health { get; set; }
        [JsonProperty("g")]
        public int Gold { get; set; }
    }
}