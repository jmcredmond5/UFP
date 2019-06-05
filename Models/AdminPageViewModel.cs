using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UFPCore.Models
{
    public class AdminPageViewModel
    {
        public Answers Answers { get; set; }
        public UpdateInfo UpdateInfo { get; set; }

        public int updateBreakPoint { get; set; }
    }
}
