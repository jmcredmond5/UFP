using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class ScoresViewModel
    {
        public Scores scores {get; set;}
        public Completions Completions { get; set; }
        public bool ScoresCompleted { get; set; }
    }
}