using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class ChampionsLge
    {
        public int Id { get; set; }
        public string User { get; set; }
        public ChampionsTeamsEnum QF1 { get; set; }
        public ChampionsTeamsEnum QF2 { get; set; }
        public ChampionsTeamsEnum QF3 { get; set; }
        public ChampionsTeamsEnum QF4 { get; set; }
        public ChampionsTeamsEnum QF5 { get; set; }
        public ChampionsTeamsEnum QF6 { get; set; }
        public ChampionsTeamsEnum QF7 { get; set; }
        public ChampionsTeamsEnum QF8 { get; set; }
        public ChampionsTeamsEnum SF1 { get; set; }
        public ChampionsTeamsEnum SF2 { get; set; }
        public ChampionsTeamsEnum SF3 { get; set; }
        public ChampionsTeamsEnum SF4 { get; set; }
        public ChampionsTeamsEnum Winner { get; set; }
        public ChampionsTeamsEnum RunnerUp { get; set; }
        public ChampionsTeamsEnum TopScoreTeam { get; set; }
        public string TopScorePlayer { get; set; }
    }
}