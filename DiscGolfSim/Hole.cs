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

        public void PlayHole(Player player, Random random)
        {
            int holeDistance = Footage;
            int strokesAmount = 0;
            string holeKey = "";
            while (holeDistance > 0)
            {
                int throwDistance = 0;
                throwDistance = player.ThrowDisc(random);
                holeDistance -= throwDistance;
                strokesAmount++;
                holeKey = String.Format("{0} on Hole: {1}-{2}", player.Name, HoleNumber, strokesAmount);
                player.ThrowDistances.Add(holeKey, throwDistance);
            }
            player.Strokes += strokesAmount;
        }
    }
}