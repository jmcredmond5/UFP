using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UFPCore.Models
{
    public class UserWithScore
    {
        public string UFPId { get; set; }
        public float CurrentScore { get; set; }
        public float LastUpdatePoints { get; set; }
    }

    public class LeagueTableViewModel
    {
        public List<UserWithScore> TableData { get; set; }
    }
}
