using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UFPCore.Models
{
    public enum LeagueOneTeamsEnum
    {
        [Display(Name = "Accrington Stanley")]
        AccringtonStanley = 1,
        [Display(Name = "AFC Wimbledon")]
        AFCWimbledon,
        Barnsley,
        Blackpool,
        Bradford,
        [Display(Name = "Bristol Rovers")]
        BristolRovers,
        [Display(Name = "Burton Albion")]
        BurtonAlbion,
        [Display(Name = "Charlton Athletic")]
        CharltonAthletic,
        Coventry,
        Doncaster,
        Fleetwood,
        Gillingham,
        Luton,
        [Display(Name = "Oxford United")]
        OxfordUnited,
        Peterborough,
        Plymouth,
        Portsmouth,
        Rochdale,
        Scunthorpe,
        Shrewsbury,
        Southend,
        Sunderland,
        Walsall,
        [Display(Name = "Wycombe Wanderers")]
        WycombeWanderers
    }
}