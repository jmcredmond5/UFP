using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class FirstsViewModel
    {
        public Completions Completions { get; set; }
        public FirstPredictions FirstPredictions { get; set; }
        public bool FirstsCompleted { get; set; }
    }
}