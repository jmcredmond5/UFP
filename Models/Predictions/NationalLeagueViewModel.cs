using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class NationalLeagueViewModel
    {
        public Completions Completions { get; set; }
        public NationalLeague NationalLeague { get; set; }
        public bool NationalLgeCompleted { get; set; }
    }
}