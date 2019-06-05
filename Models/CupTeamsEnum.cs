using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UFPCore.Models
{
    public enum CupTeamsEnum
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
        Wolves,
        [Display(Name = "Aston Villa")]
        AstonVilla,
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
        Wigan,
        [Display(Name = "Accrington Stanley")]
        AccringtonStanley,
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
        WycombeWanderers,
        Bury,
        Cambridge,
        Carlisle,
        Cheltenham,
        Colchester,
        Crawley,
        [Display(Name = "Crewe Alexandra")]
        CreweAlexandra,
        Exeter,
        [Display(Name = "Forest Green Rovers")]
        ForestGreenRovers,
        Grimsby,
        Lincoln,
        Macclesfield,
        Mansfield,
        [Display(Name = "Milton Keynes Dons")]
        MKDons,
        Morecombe,
        Newport,
        Northampton,
        [Display(Name ="Notts County")]
        NottsCounty,
        Oldham,
        [Display(Name = "Port Vale")]
        PortVale,
        Stevenage,
        Swindon,
        [Display(Name = "Tranmere Rovers")]
        TranmereRovers,
        Yeovil,
        [Display (Name = "AFC Fylde")]
        AFCFylde,
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