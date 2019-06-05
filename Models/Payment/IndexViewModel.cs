using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UFPCore.Models.Predictions;

namespace UFPCore.Models.Payment
{
    public class IndexViewModel
    {
        public string StripePublicKey { get; set; }
        public Completions Completions { get; set; }
    }
}