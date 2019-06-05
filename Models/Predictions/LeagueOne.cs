using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class LeagueOne
    {
        public int Id { get; set; }
        public string User { get; set; }
        public LeagueOneTeamsEnum Title { get; set; }
        public LeagueOneTeamsEnum RunnerUp { get; set; }
        public LeagueOneTeamsEnum Playoff1 { get; set; }
        public LeagueOneTeamsEnum Playoff2 { get; set; }
        public LeagueOneTeamsEnum Playoff3 { get; set; }
        public LeagueOneTeamsEnum Playoff4 { get; set; }
        public LeagueOneTeamsEnum PlayoffWinner { get; set; }
        public LeagueOneTeamsEnum Relegation1 { get; set; }
        public LeagueOneTeamsEnum Relegation2 { get; set; }
        public LeagueOneTeamsEnum Relegation3 { get; set; }

    }
}