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
        public int CurrentHole { get; set; }
        private int _holesAmount { get; set; }
        private List<Hole> _holesList { get; set; }
        private Random _random;

        public Game(List<Player> players, int holesAmount)
        {
            _random = new Random();
            Course course = new Course("Pine Ridge", 18);

            _holesList = course.GetCourseHoles(_random);

            Players = players;
            _holesAmount = holesAmount;
            Play();
        }

        public void Play()
        {
            for (int i = 1; i < _holesAmount + 1; i++)
            {
                CurrentHole = i; 
                foreach (var player in Players)
                {
                    var hole = _holesList.FirstOrDefault(h => h.HoleNumber == CurrentHole);
                    hole.PlayHole(player);
                }
            }
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