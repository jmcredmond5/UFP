using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class Completions
    {
        public int Id { get; set; }
        public string User { get; set; }
        public bool ScoresCom { get; set; }
        public bool FirstsCom { get; set; }
        public bool FinalCom { get; set; }
        public bool EoSCom { get; set; }
        public bool ChampionsLgeCom { get; set; }
        public bool FACupCom { get; set; }
        public bool ChampionshipCom { get; set; }
        public bool LeagueOneCom { get; set; }
        public bool LeagueTwoCom { get; set; }
        public bool NationalLeagueCom { get; set; }   
    }
}