using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscGolfSim
{
    public class Disc
    {
        public int DiscType { get; set; }
        Random _random = new Random();
        private int _distance { get; set; }
        private int _maxDistance { get; set; }
        private int _minDistance { get; set; }
        private int _strokesTaken { get; set; }
        private int _driveDistance { get; set; }

        // Should this return a number of strokes?
        public int SimulateFlight(int footage)
        {
            this._strokesTaken = 0;
            this._distance = footage;
            this._minDistance = 50;
            this._maxDistance = 200;

            while (this._distance > 0)
            {
                _driveDistance = 0;

                //first drive
                if (_strokesTaken == 0)
                    RandomzieFlight(_random);
                else if (this._distance > _maxDistance) // > 200
                    _driveDistance = _random.Next(_minDistance, _maxDistance);
                else if (this._distance > _minDistance) // > 50
                    _driveDistance = _random.Next(this._distance - 2, this._distance + 1);
                else if (this._distance > 20) // > 20
                    _driveDistance = _random.Next(this._distance - 2, this._distance + 1);
                else
                    _driveDistance = _random.Next(this._distance, this._distance + 1);

                this._distance = this._distance - _driveDistance;

                if (this._distance < 0)
                {
                    _strokesTaken++;
                    this._distance = 0;
                }
                _strokesTaken++;
            }           

            // is this a better call? to use the current player object
            // player.Strokes += _strokesTaken;
            return _strokesTaken;
        }

        public void RandomzieFlight(Random random)
        {
            _random = random;
            _driveDistance = _random.Next(_minDistance, _maxDistance);
        }
    }
}