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

        public List<Hole> GetCourseHoles(Random random)
        {
            _random = random;
            List<Hole> holeList = new List<Hole>();
            for (int i = 1; i < _totalHoles + 1; i++)
            {
                Hole hole = new Hole() { HoleNumber = i, Footage = _random.Next(275, 601) };
                holeList.Add(hole);
            }
            /*
            List<Hole> holesList = new List<Hole>() 
            {
                // Start at 1 index
                new Hole {HoleNumber = 0, Distance = 431 },
                new Hole {HoleNumber = 1, Distance = 320 },
                new Hole {HoleNumber = 2, Distance = 299 }, 
                new Hole {HoleNumber = 3, Distance = 403 }, 
                new Hole {HoleNumber = 4, Distance = 400 }, 
                new Hole {HoleNumber = 5, Distance = 370 }, 
                new Hole {HoleNumber = 6, Distance = 345 }, 
                new Hole {HoleNumber = 7, Distance = 287 }, 
                new Hole {HoleNumber = 8, Distance = 422 }, 
                new Hole {HoleNumber = 9, Distance = 304 }, 
                new Hole {HoleNumber = 10, Distance = 307 }, 
                new Hole {HoleNumber = 11, Distance = 347 }, 
                new Hole {HoleNumber = 12, Distance = 312 }, 
                new Hole {HoleNumber = 13, Distance = 214 }, 
                new Hole {HoleNumber = 14, Distance = 356 }, 
                new Hole {HoleNumber = 15, Distance = 387 }, 
                new Hole {HoleNumber = 16, Distance = 349 }, 
                new Hole {HoleNumber = 17, Distance = 512 }, 
            };
             */
            return holeList;
        }
    }
}