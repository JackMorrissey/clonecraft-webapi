using System.Collections.Generic;
using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    public class BoardStatus
    {
        public int Round { get; set; }
        public Board Board { get; set; }
        [JsonProperty("base")]
        public Base YourBase { get; set; }
        [JsonProperty("minions")]
        public List<Minion> YourMinions { get; set; }
        public Vision Vision { get; set; }
        public int NextMinionId { get; set; }
    }
}