using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscGolfSim
{
    public class Hole
    {
        public int HoleNumber { get; set; }
        public int Footage { get; set; }

        public void PlayHole(Player player)
        {
            // i've got the current player object but I feel like i lose it once I call this method.
            player.ThrowDisc(Footage);
        }
    }
}