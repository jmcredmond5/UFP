using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class ChampionshipViewModel
    {
        public Completions Completions { get; set; }
        public Championship Championship { get; set; }
        public bool ChampCompleted { get; set; }
    }
}