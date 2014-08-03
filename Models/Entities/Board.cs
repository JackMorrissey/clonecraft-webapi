using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    public class Board
    {
        [JsonProperty("w")]
        public int Width { get; set; }
        [JsonProperty("h")]
        public int Height { get; set; }
    }
}