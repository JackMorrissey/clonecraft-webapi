using CloneCraft.Models.Commands.Params;
using Newtonsoft.Json;

namespace CloneCraft.Models.Commands
{
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

        [JsonProperty("params")]
        public BuildParams Params { get; set; }
    }
}