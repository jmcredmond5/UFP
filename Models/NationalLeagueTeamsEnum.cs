using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UFPCore.Models
{
    public enum NationalLeagueTeamsEnum
    {
        [Display (Name = "AFC Fylde")]
        AFCFylde = 1,
        [Display(Name = "Aldershot Town")]
        AldershotTown,
        Barnet,
        Barrow,
        [Display(Name = "Boreham Wood")]
        BorehamWood,
        [Display(Name ="Braintree Town")]
        BraintreeTown,
        Bromley,
        Chesterfield,
        [Display(Name ="Dagenham and Redbridge")]
        DagenhamRedbridge,
        Dover,
        Eastleigh,
        Ebbsfleet,
        Halifax,
        Gateshead,
        Harrogate,
        Hartlepool,
        [Display(Name ="Havant and Waterlooville")]
        HavantWaterlooville,
        [Display(Name ="Leyton Orient")]
        LeytonOrient,
        Maidenhead,
        Maidstone,
        Salford,
        [Display(Name ="Solihull Moors")]
        SolihullMoors,
        Sutton,
        Wrexham
    }
}