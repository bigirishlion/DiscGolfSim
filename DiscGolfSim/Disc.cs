using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscGolfSim
{
    public class Disc
    {
        private Random _random;
        private int _distance { get; set; }
        private int _maxDistance { get; set; }
        private int _minDistance { get; set; }

        public void Throw(Player player, int holeNumber, List<Hole> holes, Random random)
        {
            _random = random;
            int strokesTaken = 0;
            var currentHole = holes.FirstOrDefault(h => h.HoleNumber == holeNumber);
            this._distance = currentHole.Footage;
            this._minDistance = 50;
            this._maxDistance = 200;

            while (this._distance > 0)
            {
                int driveDistance = 0;

                //first drive
                if (strokesTaken == 0)
                    driveDistance = _random.Next(_minDistance, _maxDistance);
                else if (this._distance > _maxDistance) // > 200
                    driveDistance = _random.Next(_minDistance, _maxDistance);
                else if (this._distance > _minDistance) // > 50
                    driveDistance = _random.Next(this._distance - 2, this._distance + 1);
                else if (this._distance > 20) // > 20
                    driveDistance = _random.Next(this._distance - 2, this._distance + 1);
                else
                    driveDistance = _random.Next(this._distance, this._distance + 1);

                this._distance = this._distance - driveDistance;

                if (this._distance < 0)
                {
                    strokesTaken++;
                    this._distance = 0;
                }
                strokesTaken++;
            }
            player.Strokes += strokesTaken;
        }
    }
}