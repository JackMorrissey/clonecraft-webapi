using System.Collections.Generic;
using Newtonsoft.Json;

namespace CloneCraft.Models.Entities
{
    public class Vision
    {
        [JsonProperty("bases")]
        public List<Base> EnemyBases { get; set; }
        [JsonProperty("minions")]
        public List<Minion> EnemyMinions { get; set; }
        public List<Resource> Resources { get; set; }
    }
}