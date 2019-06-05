using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UFPCore.Models
{
    public enum TeamsEnum
    {
        Arsenal = 1,
        Bournemouth,
        Brighton,
        Burnley,
        Cardiff,
        Chelsea,
        [Display(Name = "Crystal Palace")]
        CrystalPalace,
        Everton,
        Fulham,
        Huddersfield,
        Leicester,
        Liverpool,
        [Display(Name = "Manchester City")]
        ManchesterCity,
        [Display(Name = "Manchester United")]
        ManchesterUnited,
        Newcastle,
        Southampton,
        Tottenham,
        Watford,
        [Display(Name = "West Ham")]
        WestHam,
        Wolves
    }
}