using System.Runtime.Serialization;

namespace CloneCraft.Models.Commands.Params
{
    [DataContract]
    public class BuildParams
    {
        public BuildParams(Stats stats, int x, int y)
        {
            Stats = stats;
            X = x;
            Y = y;
        }
        [DataMember(Name = "x")]
        public int X { get; set; }
        [DataMember(Name = "y")]
        public int Y { get; set; }
        [DataMember(Name = "stats")]
        public Stats Stats { get; set; }
    }

    [DataContract]
    public class Stats
    {
        [DataMember(Name = "d")]
        public int Damage { get; set; }
        [DataMember(Name = "r")]
        public int Range { get; set; }
        [DataMember(Name = "h")]
        public int Health { get; set; }
        [DataMember(Name = "m")]
        public int Mining { get; set; }
        [DataMember(Name = "s")]
        public int Speed { get; set; }
        [DataMember(Name = "v")]
        public int Vision { get; set; }

    }
}