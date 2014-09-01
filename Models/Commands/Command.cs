using System.Runtime.Serialization;

namespace CloneCraft.Models.Commands
{
    [DataContract]
	abstract public class Command
    {
        [DataMember(Name = "commandName")]
        public string CommandName { get; set; }
        [DataMember(Name = "minionId")]
		public int? MinionId { get; set; }
	}
}