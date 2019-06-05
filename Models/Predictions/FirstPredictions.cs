using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class FirstPredictions
    {
        public int Id { get; set; }
        public string User { get; set; }
        public TeamsEnum Score25 { get; set; }
        public TeamsEnum Score50 { get; set; }
        public TeamsEnum Score75 { get; set; }
        public TeamsEnum Score100 { get; set; }
        public TeamsEnum Con25 { get; set; }
        public TeamsEnum Con50 { get; set; }
        public TeamsEnum Con75 { get; set; }
        public TeamsEnum Con100 { get; set; }
        public TeamsEnum TeamHattrick { get; set; }
        public TeamsEnum TeamLoseManager { get; set; }
        public TeamsEnum Score5in1 { get; set; }
        public TeamsEnum Con5in1 { get; set; }
        public TeamsEnum Win5inRow { get; set; }
        public TeamsEnum Lose5inRow { get; set; }
        public TeamsEnum TwoReds { get; set; }
        public TeamsEnum Win20 { get; set; }
    }
}