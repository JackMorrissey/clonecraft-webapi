using Newtonsoft.Json;

namespace CloneCraft.Models.Commands.Params
{
    public class MoveParams
    {
        public MoveParams(char direction)
        {
            Direction = direction;
        }
        [JsonProperty("direction")]
        public char Direction { get; set; }
    }
}