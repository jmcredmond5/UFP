using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class FACup
    {
        public int Id { get; set; }
        public string User { get; set; }
        public CupTeamsEnum QF1 { get; set; }
        public CupTeamsEnum QF2 { get; set; }
        public CupTeamsEnum QF3 { get; set; }
        public CupTeamsEnum QF4 { get; set; }
        public CupTeamsEnum QF5 { get; set; }
        public CupTeamsEnum QF6 { get; set; }
        public CupTeamsEnum QF7 { get; set; }
        public CupTeamsEnum QF8 { get; set; }
        public CupTeamsEnum SF1 { get; set; }
        public CupTeamsEnum SF2 { get; set; }
        public CupTeamsEnum SF3 { get; set; }
        public CupTeamsEnum SF4 { get; set; }
        public CupTeamsEnum Winner { get; set; }
        public CupTeamsEnum RunnerUp { get; set; }
    }
}