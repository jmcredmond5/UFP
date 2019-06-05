using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class FACupViewModel
    {
        public Completions Completions { get; set; }
        public FACup FACup { get; set; }
        public bool FACupCompleted { get; set; }
    }
}