using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UFPCore.Models
{
    public enum ChampionsTeamsEnum
    {
        [Display(Name = "AC Milan")]
        ACMilan = 1,
        [Display(Name = "AEK Athens")]
        AEKAthens,
        Ajax,
        Arsenal,
        Atalanta,
        [Display(Name = "Atletico Madrid")]
        AtleticoMadrid,
        Barcelona,
        Basel,
        [Display (Name = "Bayer Leverkusen")]
        BayerLeverkusen,
        [Display(Name = "Bayern Munich")]
        BayernMunich,
        Benfica,
        Besiktas,
        [Display(Name = "Borussia Dortmund")]
        BorussiaDortmund,
        [Display(Name = "Borussia Monchengladbach")]
        BorussiaMonchengladbach,
        Celtic,
        Chelsea,
        [Display(Name = "CSKA Moscow")]
        CSKAMoscow,
        [Display(Name = "Club Brugge")]
        ClubBrugge,
        [Display (Name = "Deportivo Alaves")]
        DeportivoAlaves,
        [Display(Name = "Dynamo Kyiv")]
        DynamoKyiv,
        [Display(Name = "Eintracht Frankfurt")]
        Frankfurt,
        Fenerbahce,
        Galatasaray,
        Genk,
        Getafe,
        [Display(Name = "1899 Hoffenheim")]
        Hoffenheim,
        [Display(Name = "Inter Milan")]
        InterMilan,
        [Display (Name = "Istanbul Basaksehir")]
        IstanbulBasaksehir,
        Juventus,
        Lille,
        Liverpool,
        [Display(Name = "Lokomotiv Moscow")]
        LokomotivMoscow,
        Lyon,
        [Display(Name = "Manchester City")]
        ManchesterCity,
        [Display(Name = "Manchester United")]
        ManchesterUnited,
        Marseille,
        Monaco,
        Napoli,
        PAOK,
        Porto,
        PSG,
        [Display(Name = "PSV Eindhoven")]
        PSVEindhoven,
        [Display(Name = "Red Bull Leipzig")]
        RBLeipzig,
        [Display(Name = "Red Bull Salzburg")]
        RBSalzburg,
        [Display(Name = "Real Madrid")]
        RealMadrid,
        [Display(Name = "Red Star Belgrade")]
        RedStarBelgrade,
        Roma,
        Rosenborg,
        [Display (Name = "SC Braga")]
        SCBraga,
        [Display(Name = "Schalke 04")]
        Schalke,
        [Display(Name = "Shaktar Donetsk")]
        ShaktarDonetsk,
        Sevilla,
        [Display(Name = "Slavia Prague")]
        SlaviaPrague,
        [Display(Name = "Spartak Moscow")]
        SpartakMoscow,
        [Display (Name = "Sporting CP")]
        SportingCP,
        [Display(Name = "Standard Liege")]
        StandardLiege,
        Torino,
        Tottenham,
        Trabzonspor,
        Valencia,
        [Display(Name = "Viktoria Plzen")]
        ViktoriaPlzen,
        Wolfsburg,
        [Display(Name = "Young Boys")]
        YoungBoys
    }
}