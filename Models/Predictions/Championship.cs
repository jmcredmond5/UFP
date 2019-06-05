using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class Championship
    {
        public int Id { get; set; }
        public string User { get; set; }
        public ChampionshipTeamsEnum Title { get; set; }
        public ChampionshipTeamsEnum RunnerUp { get; set; }
        public ChampionshipTeamsEnum Playoff1 { get; set; }
        public ChampionshipTeamsEnum Playoff2 { get; set; }
        public ChampionshipTeamsEnum Playoff3 { get; set; }
        public ChampionshipTeamsEnum Playoff4 { get; set; }
        public ChampionshipTeamsEnum PlayoffWinner { get; set; }
        public ChampionshipTeamsEnum Relegation1 { get; set; }
        public ChampionshipTeamsEnum Relegation2 { get; set; }
        public ChampionshipTeamsEnum Relegation3 { get; set; }

    }
}