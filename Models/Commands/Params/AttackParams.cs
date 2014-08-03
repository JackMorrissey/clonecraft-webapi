using Newtonsoft.Json;

namespace CloneCraft.Models.Commands.Params
{
    public class AttackParams
    {
        public AttackParams(int x, int y)
        {
            X = x;
            Y = y;
        }
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}