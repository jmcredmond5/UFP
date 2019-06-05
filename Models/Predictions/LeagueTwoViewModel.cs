using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class LeagueTwoViewModel
    {
        public Completions Completions { get; set; }
        public LeagueTwo LeagueTwo { get; set; }
        public bool LeagueTwoCompleted { get; set; }
    }
}