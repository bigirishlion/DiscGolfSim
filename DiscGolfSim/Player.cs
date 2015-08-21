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

        public Player() {}

        public Player(string playerName)
        {
            this.Name = playerName;
        }
    }
}