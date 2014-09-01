using System.Runtime.Serialization;

namespace CloneCraft.Models.Commands.Params
{
    [DataContract]
    public class HandOffParams
    {
        public HandOffParams(int minionId)
        {
            MinionId = minionId;
        }
        [DataMember(Name = "minionId")]
        public int MinionId { get; set; }
    }
}