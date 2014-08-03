using Newtonsoft.Json;

namespace CloneCraft.Models.Commands
{
	abstract public class Command
    {
        [JsonProperty("commandName")]
        public string CommandName { get; set; }
        [JsonProperty("minionId")]
		public int? MinionId { get; set; }
	}
}