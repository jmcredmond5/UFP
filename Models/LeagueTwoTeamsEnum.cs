using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UFPCore.Models
{
    public enum LeagueTwoTeamsEnum
    {
        Bury = 1,
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
        Yeovil
    }
}