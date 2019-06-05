using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class FinalViewModel
    {
        public Completions Completions { get; set; }
        public Table table { get; set; }
        public TeamsEnum teams {get; set;} 
        public bool TableCompleted { get; set; }
    }
}