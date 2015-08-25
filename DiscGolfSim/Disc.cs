using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscGolfSim
{
    public class Disc
    {
        public int DiscType { get; set; }
        public Random _random;
        public int MaxDistance { get; set; }
        public int MinDistance { get; set; }

        public int SimulateFlight(Random random)
        {
            _random = random;
            return _random.Next(MinDistance, MaxDistance);
        }

        /*
        public int RandomzieFlight()
        {
            return RandomDistance.Next(MinDistance, MaxDistance);
        }
         */
    }
}