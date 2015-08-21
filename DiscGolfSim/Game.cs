using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DiscGolfSim
{
    public class Game
    {
        public List<Player> Players { get; set; }
        private int _holesAmount { get; set; }
        private List<Hole> _holesList { get; set; }
        private int _currentHole { get; set; }
        private Random _random;

        public Game(List<Player> players, int holesAmount)
        {
            _random = new Random();
            Course course = new Course("Pine Ridge", 18);

            _holesList = course.GetCourseHoles(_random);

            Players = players;
            _holesAmount = holesAmount;

            for (int i = 1; i < _holesAmount + 1; i++)
            {
                _currentHole = i;
                PlayHole();
            }
        }

        private void PlayHole()
        {
            foreach (var player in Players)
            {
                takeTurn(player);
            }
        }

        private void takeTurn(Player player)
        {            
            Disc disc = new Disc();
            disc.Throw(player, _currentHole, _holesList, _random);
            // TODO display stroke information
        }

        public string DisplayResults()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(displayCourseInfo());

            foreach (var player in Players)
            {
                sb.Append("<p>");
                sb.Append(player.Name + " Score: " + player.Strokes);
                sb.Append("</p>");
            }
            var winner = Players.OrderBy(p => p.Strokes).FirstOrDefault();
            sb.Append("<p>");
            sb.Append(winner.Name);
            sb.Append(" Wins! </p>");
            return sb.ToString();
        }

        private string displayCourseInfo()
        {
            string result = "";
            result += "<p>";
            foreach (var hole in _holesList)
            {
                result += String.Format("Hole {0} - {1}\" <br>", hole.HoleNumber, hole.Footage);
            }
            result += "</p>";
            return result;
        }
    }
}