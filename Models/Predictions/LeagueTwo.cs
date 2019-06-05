using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class LeagueTwo
    {
        public int Id { get; set; }
        public string User { get; set; }
        public LeagueTwoTeamsEnum Title { get; set; }
        public LeagueTwoTeamsEnum RunnerUp { get; set; }
        public LeagueTwoTeamsEnum Playoff1 { get; set; }
        public LeagueTwoTeamsEnum Playoff2 { get; set; }
        public LeagueTwoTeamsEnum Playoff3 { get; set; }
        public LeagueTwoTeamsEnum Playoff4 { get; set; }
        public LeagueTwoTeamsEnum PlayoffWinner { get; set; }
        public LeagueTwoTeamsEnum Relegation1 { get; set; }
        public LeagueTwoTeamsEnum Relegation2 { get; set; }
        public LeagueTwoTeamsEnum Relegation3 { get; set; }

    }
}