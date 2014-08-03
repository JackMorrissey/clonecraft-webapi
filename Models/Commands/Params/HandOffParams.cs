using Newtonsoft.Json;

namespace CloneCraft.Models.Commands.Params
{
    public class HandOffParams
    {
        public HandOffParams(int minionId)
        {
            MinionId = minionId;
        }
        [JsonProperty("minionId")]
        public int MinionId { get; set; }
    }
}