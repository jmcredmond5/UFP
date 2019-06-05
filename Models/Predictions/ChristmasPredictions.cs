using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UFPCore.Models.Predictions
{
    public class ChristmasPredictions
    {
        public int Id { get; set; }
        public string User { get; set; }
        public TeamsEnum Top { get; set; }
        public TeamsEnum Bottom { get; set; }
        public int ManagersOut { get; set; }
        public int PointsDifference { get; set; }
        public int PointsClear { get; set; }
    }
}