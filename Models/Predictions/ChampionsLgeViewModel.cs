using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class ChampionsLgeViewModel
    {
        public Completions Completions { get; set; }
        public ChampionsLge ChampionsLge { get; set; }
        public bool ChampLgeCompleted { get; set; }
    }
}