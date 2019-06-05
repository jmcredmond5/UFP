using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class NationalLeague
    {
        public int Id { get; set; }
        public string User { get; set; }
        public NationalLeagueTeamsEnum Title { get; set; }
        public NationalLeagueTeamsEnum PlayoffWinner { get; set; }
        
    }
}