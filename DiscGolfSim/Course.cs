using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscGolfSim
{
    public class Course
    {
        public string CourseName { get; set; }
        public List<Hole> holes  { get; set; }
        private int _totalHoles { get; set; }
        private Random _random;

        public Course(string courseName, int totalHoles)
        {
            this.CourseName = courseName;
            this._totalHoles = totalHoles;
        }

        public List<Hole> generateCourseHoles(Random random)
        {
            _random = random;
            List<Hole> holeList = new List<Hole>();
            for (int i = 1; i < _totalHoles + 1; i++)
            {
                Hole hole = new Hole() { HoleNumber = i, Footage = _random.Next(275, 450) };
                holeList.Add(hole);
            }
            return holeList;
        }
    }
}