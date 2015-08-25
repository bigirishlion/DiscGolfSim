using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscGolfSim
{
    public class Player
    {
        public string Name { get; set; }
        public int Strokes { get; set; }
        public int Level { get; set; }
        public Dictionary<string, int> ThrowDistances = new Dictionary<string, int>();

        public Player() {}

        public Player(string playerName)
        {
            this.Name = playerName;
        }

        public int ThrowDisc(Random randomDistance)
        {
            Disc disc = new Disc() { MinDistance = 25, MaxDistance = 175};
            return disc.SimulateFlight(randomDistance);
        }
    }
}