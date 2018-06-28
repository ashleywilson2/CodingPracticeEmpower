using System;
using System.Collections.Generic;
using System.Text;

namespace BeerOlympics
{
    public class Contestant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IndScore { get; set; }
        public string TeamName { get; set; }
        public int TeamScore { get; set; }
        public string FavObstacle { get; set; }

        //this is a constructor so that you only enter in info in one line instead of stacking it...types less :)
        //public Contestant(string name, int indScore, string teamName, int teamScore, string favObstacle)
        //{
        //    Name = name;
        //    IndScore = indScore;
        //    TeamName = teamName;
        //    TeamScore = teamScore;
        //    FavObstacle = favObstacle;
        //}
    }
}
