using Newtonsoft.Json;

namespace CloneCraft.Models.Commands.Params
{
    public class BuildParams
    {
        public BuildParams(Stats stats, int x, int y)
        {
            Stats = stats;
            X = x;
            Y = y;
        }
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }

    public class Stats
    {
        [JsonProperty("d")]
        public int Damage { get; set; }
        [JsonProperty("r")]
        public int Range { get; set; }
        [JsonProperty("h")]
        public int Health { get; set; }
        [JsonProperty("m")]
        public int Mining { get; set; }
        [JsonProperty("s")]
        public int Speed { get; set; }
        [JsonProperty("v")]
        public int Vision { get; set; }

    }
}