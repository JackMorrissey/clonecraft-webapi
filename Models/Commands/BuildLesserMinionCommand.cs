using System.Runtime.Serialization;
using CloneCraft.Models.Commands.Params;

namespace CloneCraft.Models.Commands
{
    [DataContract]
    public class BuildLesserMinionCommand : Command
    {
        public BuildLesserMinionCommand(int damage, int range, int health, int mining, int speed, int vision, int x, int y)
        {
            CommandName = "build lesser";
            MinionId = null;
            Params = new BuildParams(new Stats
                {
                    Damage = damage,
                    Range = range,
                    Health = health,
                    Mining = mining,
                    Speed = speed,
                    Vision = vision
                }, x, y);
        }

        [DataMember(Name = "params")]
        public BuildParams Params { get; set; }
    }
}