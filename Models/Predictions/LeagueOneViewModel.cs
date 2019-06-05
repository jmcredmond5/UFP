using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class LeagueOneViewModel
    {
        public Completions Completions { get; set; }
        public LeagueOne LeagueOne { get; set; }
        public bool LeagueOneCompleted { get; set; }
    }
}