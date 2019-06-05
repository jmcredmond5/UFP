using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class ChristmasViewModel
    {
        public Completions Completions { get; set; }
        public ChristmasPredictions ChristmasPredictions { get; set; }
        public bool ChristmasCompleted { get; set; }
    }
}