using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UFPCore.Models
{
    public enum ChampionshipTeamsEnum
    {
        [Display(Name = "Aston Villa")]
        AstonVilla = 1,
        Birmingham,
        Blackburn,
        Bolton,
        Brentford,
        [Display(Name = "Bristol City")]
        BristolCity,
        Derby,
        Hull,
        Ipswich,
        Leeds,
        Middlesborough,
        Millwall,
        Norwich,
        [Display(Name = "Nottingham Forest")]
        NottinghamForest,
        [Display(Name = "Preston North End")]
        PNE,
        QPR,
        Reading,
        Rotherham,
        [Display(Name = "Sheffield United")]
        SheffieldUnited,
        [Display(Name = "Sheffield Wednesday")]
        SheffieldWednesday,
        Stoke,
        Swansea,
        [Display(Name = "West Bromwich Albion")]
        WestBrom,
        Wigan
    }
}