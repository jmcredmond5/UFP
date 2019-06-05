using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UFPCore.Areas.Identity.Pages.Account;
using UFPCore.Data;
using UFPCore.Models;
using UFPCore.Models.Predictions;

namespace UFPCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDataController : ControllerBase
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        
        public TestDataController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("/addusers")]
        public async Task<IActionResult> AddUsers()
        {
            ApplicationUser[] dummyusers = new ApplicationUser[]
            {
                new ApplicationUser ()
                {
                    FirstName = "Dummy",
                    LastName = "English",
                    Email = "d1@ufpcore.com",
                    Id = "d1",
                    UserName = "Dummy English",
                    EmailConfirmed = true
                },
                new ApplicationUser()
                {
                    FirstName = "Dummy",
                    LastName = "Spain",
                    Email = "d2@ufpcore.com",
                    Id = "d2",
                    UserName = "Dummy Spain",
                    EmailConfirmed = true
                },
                new ApplicationUser()
                {
                    FirstName = "Dummy",
                    LastName = "Italy",
                    Email = "d3@ufpcore.com",
                    Id = "d3",
                    UserName = "Dummy Italy",
                    EmailConfirmed = true
                },
                new ApplicationUser()
                {
                    FirstName = "Dummy",
                    LastName = "Germany",
                    Email = "d4@ufpcore.com",
                    Id = "d4",
                    UserName = "Dummy Germany",
                    EmailConfirmed = true
                },
            };
            foreach (var user in dummyusers) {
                await _userManager.CreateAsync(user);
            };
            return RedirectToAction("AddPredictions");
        }

        public IActionResult AddPredictions()
        {
            var d1Champ = new Championship()
            {
                //Id = 5001,
                User = "d1",
                Playoff1 = ChampionshipTeamsEnum.AstonVilla,
                Playoff2 = ChampionshipTeamsEnum.Birmingham,
                Playoff3 = ChampionshipTeamsEnum.Blackburn,
                Playoff4 = ChampionshipTeamsEnum.Bolton,
                PlayoffWinner = ChampionshipTeamsEnum.AstonVilla,
                Relegation1 = ChampionshipTeamsEnum.Brentford,
                Relegation2 = ChampionshipTeamsEnum.BristolCity,
                Relegation3 = ChampionshipTeamsEnum.Derby,
                RunnerUp = ChampionshipTeamsEnum.Hull,
                Title = ChampionshipTeamsEnum.Ipswich
            };
            var d1CLge = new ChampionsLge()
            {
                //Id = 5001,
                User = "d1",
                QF1 = ChampionsTeamsEnum.Arsenal,
                QF2 = ChampionsTeamsEnum.Chelsea,
                QF3 = ChampionsTeamsEnum.Liverpool,
                QF4 = ChampionsTeamsEnum.ManchesterCity,
                QF5 = ChampionsTeamsEnum.ManchesterUnited,
                QF6 = ChampionsTeamsEnum.Tottenham,
                QF7 = ChampionsTeamsEnum.Celtic,
                QF8 = ChampionsTeamsEnum.Rosenborg,
                SF1 = ChampionsTeamsEnum.Arsenal,
                SF2 = ChampionsTeamsEnum.Chelsea,
                SF3 = ChampionsTeamsEnum.Liverpool,
                SF4 = ChampionsTeamsEnum.ManchesterCity,
                Winner = ChampionsTeamsEnum.Liverpool,
                RunnerUp = ChampionsTeamsEnum.ManchesterCity,
                TopScorePlayer = "Kane",
                TopScoreTeam = ChampionsTeamsEnum.Liverpool
            };
            var d1Christmas = new ChristmasPredictions()
            {
                //Id = 5001,
                User = "d1",
                Bottom = TeamsEnum.Brighton,
                Top = TeamsEnum.Liverpool,
                ManagersOut = 3,
                PointsClear = 3,
                PointsDifference = 30
            };
            var d1FAC = new FACup()
            {
                //Id = 5001,
                User = "d1",
                QF1 = CupTeamsEnum.Arsenal,
                QF2 = CupTeamsEnum.Chelsea,
                QF3 = CupTeamsEnum.Liverpool,
                QF4 = CupTeamsEnum.ManchesterCity,
                QF5 = CupTeamsEnum.ManchesterUnited,
                QF6 = CupTeamsEnum.Tottenham,
                QF7 = CupTeamsEnum.Wolves,
                QF8 = CupTeamsEnum.Leicester,
                SF1 = CupTeamsEnum.Arsenal,
                SF2 = CupTeamsEnum.Chelsea,
                SF3 = CupTeamsEnum.Liverpool,
                SF4 = CupTeamsEnum.ManchesterCity,
                Winner = CupTeamsEnum.Liverpool,
                RunnerUp = CupTeamsEnum.ManchesterCity
            };
            var d1Firsts = new FirstPredictions()
            {
                //Id = 5001,
                User = "d1",
                Con100 = TeamsEnum.Huddersfield,
                Con25 = TeamsEnum.Huddersfield,
                Con50 = TeamsEnum.Huddersfield,
                Con75 = TeamsEnum.Huddersfield,
                Con5in1 = TeamsEnum.Huddersfield,
                Lose5inRow = TeamsEnum.Huddersfield,
                Score100 = TeamsEnum.Liverpool,
                Score25 = TeamsEnum.Liverpool,
                Score50 = TeamsEnum.Liverpool,
                Score5in1 = TeamsEnum.Liverpool,
                Score75 = TeamsEnum.Liverpool,
                TeamHattrick = TeamsEnum.Liverpool,
                TeamLoseManager = TeamsEnum.Huddersfield,
                TwoReds = TeamsEnum.Huddersfield,
                Win20 = TeamsEnum.Liverpool,
                Win5inRow = TeamsEnum.Liverpool
            };
            var d1Lge1 = new LeagueOne()
            {
                //Id = 5001,
                User = "d1",
                Playoff1 = LeagueOneTeamsEnum.AccringtonStanley,
                Playoff2 = LeagueOneTeamsEnum.AFCWimbledon,
                Playoff3 = LeagueOneTeamsEnum.Barnsley,
                Playoff4 = LeagueOneTeamsEnum.Blackpool,
                PlayoffWinner = LeagueOneTeamsEnum.AccringtonStanley,
                Title = LeagueOneTeamsEnum.Bradford,
                RunnerUp = LeagueOneTeamsEnum.BristolRovers,
                Relegation1 = LeagueOneTeamsEnum.BurtonAlbion,
                Relegation2 = LeagueOneTeamsEnum.CharltonAthletic,
                Relegation3 = LeagueOneTeamsEnum.Coventry
            };
            var d1Lge2 = new LeagueTwo()
            {
                //Id = 5001,
                User = "d1",
                Playoff1 = LeagueTwoTeamsEnum.Bury,
                Playoff2 = LeagueTwoTeamsEnum.Cambridge,
                Playoff3 = LeagueTwoTeamsEnum.Carlisle,
                Playoff4 = LeagueTwoTeamsEnum.Cheltenham,
                PlayoffWinner = LeagueTwoTeamsEnum.Bury,
                Title = LeagueTwoTeamsEnum.Colchester,
                RunnerUp = LeagueTwoTeamsEnum.Crawley,
                Relegation1 = LeagueTwoTeamsEnum.CreweAlexandra,
                Relegation2 = LeagueTwoTeamsEnum.Exeter,
                Relegation3 = LeagueTwoTeamsEnum.ForestGreenRovers
            };
            var d1NLge = new NationalLeague()
            {
                //Id = 5001,
                User = "d1",
                Title = NationalLeagueTeamsEnum.AFCFylde,
                PlayoffWinner = NationalLeagueTeamsEnum.AldershotTown
            };
            var d1Scores = new Scores()
            {
                //Id = 5001,
                User = "d1",
                Score1 = 1,
                Score2 = 0,
                Score3 = 1,
                Score4 = 0,
                Score5 = 1,
                Score6 = 0,
                Score7 = 1,
                Score8 = 0,
                Score9 = 1,
                Score10 = 0,
                Score11 = 1,
                Score12 = 0,
                Score13 = 1,
                Score14 = 0,
                Score15 = 1,
                Score16 = 0,
                Score17 = 1,
                Score18 = 0,
                Score19 = 1,
                Score20 = 0,
                Score21 = 1,
                Score22 = 0,
                Score23 = 1,
                Score24 = 0,
                Score25 = 1,
                Score26 = 0,
                Score27 = 1,
                Score28 = 0,
                Score29 = 1,
                Score30 = 0,
                Score31 = 1,
                Score32 = 0,
                Score33 = 1,
                Score34 = 0,
                Score35 = 1,
                Score36 = 0,
                Score37 = 1,
                Score38 = 0,
                Score39 = 1,
                Score40 = 0,
                Score41 = 1,
                Score42 = 0,
                Score43 = 1,
                Score44 = 0,
                Score45 = 1,
                Score46 = 0,
                Score47 = 1,
                Score48 = 0,
                Score49 = 1,
                Score50 = 0,
                Score51 = 1,
                Score52 = 0,
                Score53 = 1,
                Score54 = 0,
                Score55 = 1,
                Score56 = 0,
                Score57 = 1,
                Score58 = 0,
                Score59 = 1,
                Score60 = 0,
                Score61 = 1,
                Score62 = 0,
                Score63 = 1,
                Score64 = 0,
                Score65 = 1,
                Score66 = 0,
                Score67 = 1,
                Score68 = 0,
                Score69 = 1,
                Score70 = 0,
                Score71 = 1,
                Score72 = 0,
                Score73 = 1,
                Score74 = 0,
                Score75 = 1,
                Score76 = 0,
                Score77 = 1,
                Score78 = 0
            };
            var d1Table = new Table()
            {
                //Id = 5001,
                User = "d1",
                Place1 = TeamsEnum.Arsenal,
                Place2 = TeamsEnum.Bournemouth,
                Place3 = TeamsEnum.Brighton,
                Place4 = TeamsEnum.Burnley,
                Place5 = TeamsEnum.Cardiff,
                Place6 = TeamsEnum.Chelsea,
                Place7 = TeamsEnum.CrystalPalace,
                Place8 = TeamsEnum.Everton,
                Place9 = TeamsEnum.Fulham,
                Place10 = TeamsEnum.Huddersfield,
                Place11 = TeamsEnum.Leicester,
                Place12 = TeamsEnum.Liverpool,
                Place13 = TeamsEnum.ManchesterCity,
                Place14 = TeamsEnum.ManchesterUnited,
                Place15 = TeamsEnum.Newcastle,
                Place16 = TeamsEnum.Southampton,
                Place17 = TeamsEnum.Tottenham,
                Place18 = TeamsEnum.Watford,
                Place19 = TeamsEnum.WestHam,
                Place20 = TeamsEnum.Wolves
            };

            _context.Championship.Add(d1Champ);
            _context.ChampionsLge.Add(d1CLge);
            _context.ChristmasPredictions.Add(d1Christmas);
            _context.FACup.Add(d1FAC);
            _context.Firsts.Add(d1Firsts);
            _context.LeagueOne.Add(d1Lge1);
            _context.LeagueTwo.Add(d1Lge2);
            _context.NationalLeague.Add(d1NLge);
            _context.Scores.Add(d1Scores);
            _context.Tables.Add(d1Table);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            var d2Champ = new Championship()
            {
                //Id = 5002,
                User = "d2",
                Playoff1 = ChampionshipTeamsEnum.AstonVilla,
                Playoff2 = ChampionshipTeamsEnum.Birmingham,
                Playoff3 = ChampionshipTeamsEnum.Blackburn,
                Playoff4 = ChampionshipTeamsEnum.Bolton,
                PlayoffWinner = ChampionshipTeamsEnum.AstonVilla,
                Relegation1 = ChampionshipTeamsEnum.Brentford,
                Relegation2 = ChampionshipTeamsEnum.BristolCity,
                Relegation3 = ChampionshipTeamsEnum.Derby,
                RunnerUp = ChampionshipTeamsEnum.Hull,
                Title = ChampionshipTeamsEnum.Ipswich
            };
            var d2CLge = new ChampionsLge()
            {
                //Id = 5002,
                User = "d2",
                QF1 = ChampionsTeamsEnum.AtleticoMadrid,
                QF2 = ChampionsTeamsEnum.Barcelona,
                QF3 = ChampionsTeamsEnum.DeportivoAlaves,
                QF4 = ChampionsTeamsEnum.Getafe,
                QF5 = ChampionsTeamsEnum.RealMadrid,
                QF6 = ChampionsTeamsEnum.Sevilla,
                QF7 = ChampionsTeamsEnum.Valencia,
                QF8 = ChampionsTeamsEnum.SCBraga,
                SF1 = ChampionsTeamsEnum.Barcelona,
                SF2 = ChampionsTeamsEnum.RealMadrid,
                SF3 = ChampionsTeamsEnum.AtleticoMadrid,
                SF4 = ChampionsTeamsEnum.Sevilla,
                Winner = ChampionsTeamsEnum.Barcelona,
                RunnerUp = ChampionsTeamsEnum.RealMadrid,
                TopScorePlayer = "Messi",
                TopScoreTeam = ChampionsTeamsEnum.Barcelona
            };
            var d2Christmas = new ChristmasPredictions()
            {
                //Id = 5002,
                User = "d2",
                Bottom = TeamsEnum.Brighton,
                Top = TeamsEnum.Liverpool,
                ManagersOut = 3,
                PointsClear = 3,
                PointsDifference = 30
            };
            var d2FAC = new FACup()
            {
                //Id = 5002,
                User = "d2",
                QF1 = CupTeamsEnum.Arsenal,
                QF2 = CupTeamsEnum.Chelsea,
                QF3 = CupTeamsEnum.Liverpool,
                QF4 = CupTeamsEnum.ManchesterCity,
                QF5 = CupTeamsEnum.ManchesterUnited,
                QF6 = CupTeamsEnum.Tottenham,
                QF7 = CupTeamsEnum.Wolves,
                QF8 = CupTeamsEnum.Leicester,
                SF1 = CupTeamsEnum.Arsenal,
                SF2 = CupTeamsEnum.Chelsea,
                SF3 = CupTeamsEnum.Liverpool,
                SF4 = CupTeamsEnum.ManchesterCity,
                Winner = CupTeamsEnum.Liverpool,
                RunnerUp = CupTeamsEnum.ManchesterCity
            };
            var d2Firsts = new FirstPredictions()
            {
                //Id = 5002,
                User = "d2",
                Con100 = TeamsEnum.Huddersfield,
                Con25 = TeamsEnum.Huddersfield,
                Con50 = TeamsEnum.Huddersfield,
                Con75 = TeamsEnum.Huddersfield,
                Con5in1 = TeamsEnum.Huddersfield,
                Lose5inRow = TeamsEnum.Huddersfield,
                Score100 = TeamsEnum.Liverpool,
                Score25 = TeamsEnum.Liverpool,
                Score50 = TeamsEnum.Liverpool,
                Score5in1 = TeamsEnum.Liverpool,
                Score75 = TeamsEnum.Liverpool,
                TeamHattrick = TeamsEnum.Liverpool,
                TeamLoseManager = TeamsEnum.Huddersfield,
                TwoReds = TeamsEnum.Huddersfield,
                Win20 = TeamsEnum.Liverpool,
                Win5inRow = TeamsEnum.Liverpool
            };
            var d2Lge1 = new LeagueOne()
            {
                //Id = 5002,
                User = "d2",
                Playoff1 = LeagueOneTeamsEnum.AccringtonStanley,
                Playoff2 = LeagueOneTeamsEnum.AFCWimbledon,
                Playoff3 = LeagueOneTeamsEnum.Barnsley,
                Playoff4 = LeagueOneTeamsEnum.Blackpool,
                PlayoffWinner = LeagueOneTeamsEnum.AccringtonStanley,
                Title = LeagueOneTeamsEnum.Bradford,
                RunnerUp = LeagueOneTeamsEnum.BristolRovers,
                Relegation1 = LeagueOneTeamsEnum.BurtonAlbion,
                Relegation2 = LeagueOneTeamsEnum.CharltonAthletic,
                Relegation3 = LeagueOneTeamsEnum.Coventry
            };
            var d2Lge2 = new LeagueTwo()
            {
                //Id = 5002,
                User = "d2",
                Playoff1 = LeagueTwoTeamsEnum.Bury,
                Playoff2 = LeagueTwoTeamsEnum.Cambridge,
                Playoff3 = LeagueTwoTeamsEnum.Carlisle,
                Playoff4 = LeagueTwoTeamsEnum.Cheltenham,
                PlayoffWinner = LeagueTwoTeamsEnum.Bury,
                Title = LeagueTwoTeamsEnum.Colchester,
                RunnerUp = LeagueTwoTeamsEnum.Crawley,
                Relegation1 = LeagueTwoTeamsEnum.CreweAlexandra,
                Relegation2 = LeagueTwoTeamsEnum.Exeter,
                Relegation3 = LeagueTwoTeamsEnum.ForestGreenRovers
            };
            var d2NLge = new NationalLeague()
            {
                //Id = 5002,
                User = "d2",
                Title = NationalLeagueTeamsEnum.AFCFylde,
                PlayoffWinner = NationalLeagueTeamsEnum.AldershotTown
            };
            var d2Scores = new Scores()
            {
                //Id = 5002,
                User = "d2",
                Score1 = 2,
                Score2 = 0,
                Score3 = 2,
                Score4 = 0,
                Score5 = 2,
                Score6 = 0,
                Score7 = 2,
                Score8 = 0,
                Score9 = 2,
                Score10 = 0,
                Score11 = 2,
                Score12 = 0,
                Score13 = 2,
                Score14 = 0,
                Score15 = 2,
                Score16 = 0,
                Score17 = 2,
                Score18 = 0,
                Score19 = 2,
                Score20 = 0,
                Score21 = 2,
                Score22 = 0,
                Score23 = 2,
                Score24 = 0,
                Score25 = 2,
                Score26 = 0,
                Score27 = 2,
                Score28 = 0,
                Score29 = 2,
                Score30 = 0,
                Score31 = 2,
                Score32 = 0,
                Score33 = 2,
                Score34 = 0,
                Score35 = 2,
                Score36 = 0,
                Score37 = 2,
                Score38 = 0,
                Score39 = 2,
                Score40 = 0,
                Score41 = 2,
                Score42 = 0,
                Score43 = 2,
                Score44 = 0,
                Score45 = 2,
                Score46 = 0,
                Score47 = 2,
                Score48 = 0,
                Score49 = 2,
                Score50 = 0,
                Score51 = 2,
                Score52 = 0,
                Score53 = 2,
                Score54 = 0,
                Score55 = 2,
                Score56 = 0,
                Score57 = 2,
                Score58 = 0,
                Score59 = 2,
                Score60 = 0,
                Score61 = 2,
                Score62 = 0,
                Score63 = 2,
                Score64 = 0,
                Score65 = 2,
                Score66 = 0,
                Score67 = 2,
                Score68 = 0,
                Score69 = 2,
                Score70 = 0,
                Score71 = 2,
                Score72 = 0,
                Score73 = 2,
                Score74 = 0,
                Score75 = 2,
                Score76 = 0,
                Score77 = 2,
                Score78 = 0
            };
            var d2Table = new Table()
            {
                //Id = 5002,
                User = "d2",
                Place1 = TeamsEnum.Arsenal,
                Place2 = TeamsEnum.Bournemouth,
                Place3 = TeamsEnum.Brighton,
                Place4 = TeamsEnum.Burnley,
                Place5 = TeamsEnum.Cardiff,
                Place6 = TeamsEnum.Chelsea,
                Place7 = TeamsEnum.CrystalPalace,
                Place8 = TeamsEnum.Everton,
                Place9 = TeamsEnum.Fulham,
                Place10 = TeamsEnum.Huddersfield,
                Place11 = TeamsEnum.Leicester,
                Place12 = TeamsEnum.Liverpool,
                Place13 = TeamsEnum.ManchesterCity,
                Place14 = TeamsEnum.ManchesterUnited,
                Place15 = TeamsEnum.Newcastle,
                Place16 = TeamsEnum.Southampton,
                Place17 = TeamsEnum.Tottenham,
                Place18 = TeamsEnum.Watford,
                Place19 = TeamsEnum.WestHam,
                Place20 = TeamsEnum.Wolves
            };

            _context.Championship.Add(d2Champ);
            _context.ChampionsLge.Add(d2CLge);
            _context.ChristmasPredictions.Add(d2Christmas);
            _context.FACup.Add(d2FAC);
            _context.Firsts.Add(d2Firsts);
            _context.LeagueOne.Add(d2Lge1);
            _context.LeagueTwo.Add(d2Lge2);
            _context.NationalLeague.Add(d2NLge);
            _context.Scores.Add(d2Scores);
            _context.Tables.Add(d2Table);
            /////////////////////////////////////////////////////////////////

            var d3Champ = new Championship()
            {
                //Id = 5003,
                User = "d3",
                Playoff1 = ChampionshipTeamsEnum.AstonVilla,
                Playoff2 = ChampionshipTeamsEnum.Birmingham,
                Playoff3 = ChampionshipTeamsEnum.Blackburn,
                Playoff4 = ChampionshipTeamsEnum.Bolton,
                PlayoffWinner = ChampionshipTeamsEnum.AstonVilla,
                Relegation1 = ChampionshipTeamsEnum.Brentford,
                Relegation2 = ChampionshipTeamsEnum.BristolCity,
                Relegation3 = ChampionshipTeamsEnum.Derby,
                RunnerUp = ChampionshipTeamsEnum.Hull,
                Title = ChampionshipTeamsEnum.Ipswich
            };
            var d3CLge = new ChampionsLge()
            {
                //Id = 5003,
                User = "d3",
                QF1 = ChampionsTeamsEnum.Atalanta,
                QF2 = ChampionsTeamsEnum.InterMilan,
                QF3 = ChampionsTeamsEnum.Juventus,
                QF4 = ChampionsTeamsEnum.Napoli,
                QF5 = ChampionsTeamsEnum.Roma,
                QF6 = ChampionsTeamsEnum.Torino,
                QF7 = ChampionsTeamsEnum.Monaco,
                QF8 = ChampionsTeamsEnum.ACMilan,
                SF1 = ChampionsTeamsEnum.ACMilan,
                SF2 = ChampionsTeamsEnum.Juventus,
                SF3 = ChampionsTeamsEnum.Roma,
                SF4 = ChampionsTeamsEnum.InterMilan,
                Winner = ChampionsTeamsEnum.Juventus,
                RunnerUp = ChampionsTeamsEnum.Roma,
                TopScorePlayer = "Ronaldo",
                TopScoreTeam = ChampionsTeamsEnum.Juventus
            };
            var d3Christmas = new ChristmasPredictions()
            {
                //Id = 5003,
                User = "d3",
                Bottom = TeamsEnum.Brighton,
                Top = TeamsEnum.Liverpool,
                ManagersOut = 3,
                PointsClear = 3,
                PointsDifference = 30
            };
            var d3FAC = new FACup()
            {
                //Id = 5003,
                User = "d3",
                QF1 = CupTeamsEnum.Arsenal,
                QF2 = CupTeamsEnum.Chelsea,
                QF3 = CupTeamsEnum.Liverpool,
                QF4 = CupTeamsEnum.ManchesterCity,
                QF5 = CupTeamsEnum.ManchesterUnited,
                QF6 = CupTeamsEnum.Tottenham,
                QF7 = CupTeamsEnum.Wolves,
                QF8 = CupTeamsEnum.Leicester,
                SF1 = CupTeamsEnum.Arsenal,
                SF2 = CupTeamsEnum.Chelsea,
                SF3 = CupTeamsEnum.Liverpool,
                SF4 = CupTeamsEnum.ManchesterCity,
                Winner = CupTeamsEnum.Liverpool,
                RunnerUp = CupTeamsEnum.ManchesterCity
            };
            var d3Firsts = new FirstPredictions()
            {
                //Id = 5003,
                User = "d3",
                Con100 = TeamsEnum.Huddersfield,
                Con25 = TeamsEnum.Huddersfield,
                Con50 = TeamsEnum.Huddersfield,
                Con75 = TeamsEnum.Huddersfield,
                Con5in1 = TeamsEnum.Huddersfield,
                Lose5inRow = TeamsEnum.Huddersfield,
                Score100 = TeamsEnum.Liverpool,
                Score25 = TeamsEnum.Liverpool,
                Score50 = TeamsEnum.Liverpool,
                Score5in1 = TeamsEnum.Liverpool,
                Score75 = TeamsEnum.Liverpool,
                TeamHattrick = TeamsEnum.Liverpool,
                TeamLoseManager = TeamsEnum.Huddersfield,
                TwoReds = TeamsEnum.Huddersfield,
                Win20 = TeamsEnum.Liverpool,
                Win5inRow = TeamsEnum.Liverpool
            };
            var d3Lge1 = new LeagueOne()
            {
                //Id = 5003,
                User = "d3",
                Playoff1 = LeagueOneTeamsEnum.AccringtonStanley,
                Playoff2 = LeagueOneTeamsEnum.AFCWimbledon,
                Playoff3 = LeagueOneTeamsEnum.Barnsley,
                Playoff4 = LeagueOneTeamsEnum.Blackpool,
                PlayoffWinner = LeagueOneTeamsEnum.AccringtonStanley,
                Title = LeagueOneTeamsEnum.Bradford,
                RunnerUp = LeagueOneTeamsEnum.BristolRovers,
                Relegation1 = LeagueOneTeamsEnum.BurtonAlbion,
                Relegation2 = LeagueOneTeamsEnum.CharltonAthletic,
                Relegation3 = LeagueOneTeamsEnum.Coventry
            };
            var d3Lge2 = new LeagueTwo()
            {
                //Id = 5003,
                User = "d3",
                Playoff1 = LeagueTwoTeamsEnum.Bury,
                Playoff2 = LeagueTwoTeamsEnum.Cambridge,
                Playoff3 = LeagueTwoTeamsEnum.Carlisle,
                Playoff4 = LeagueTwoTeamsEnum.Cheltenham,
                PlayoffWinner = LeagueTwoTeamsEnum.Bury,
                Title = LeagueTwoTeamsEnum.Colchester,
                RunnerUp = LeagueTwoTeamsEnum.Crawley,
                Relegation1 = LeagueTwoTeamsEnum.CreweAlexandra,
                Relegation2 = LeagueTwoTeamsEnum.Exeter,
                Relegation3 = LeagueTwoTeamsEnum.ForestGreenRovers
            };
            var d3NLge = new NationalLeague()
            {
                //Id = 5003,
                User = "d3",
                Title = NationalLeagueTeamsEnum.AFCFylde,
                PlayoffWinner = NationalLeagueTeamsEnum.AldershotTown
            };
            var d3Scores = new Scores()
            {
                //Id = 5003,
                User = "d3",
                Score1 = 3,
                Score2 = 0,
                Score3 = 3,
                Score4 = 0,
                Score5 = 3,
                Score6 = 0,
                Score7 = 3,
                Score8 = 0,
                Score9 = 3,
                Score10 = 0,
                Score11 = 3,
                Score12 = 0,
                Score13 = 3,
                Score14 = 0,
                Score15 = 3,
                Score16 = 0,
                Score17 = 3,
                Score18 = 0,
                Score19 = 3,
                Score20 = 0,
                Score21 = 3,
                Score22 = 0,
                Score23 = 3,
                Score24 = 0,
                Score25 = 3,
                Score26 = 0,
                Score27 = 3,
                Score28 = 0,
                Score29 = 3,
                Score30 = 0,
                Score31 = 3,
                Score32 = 0,
                Score33 = 3,
                Score34 = 0,
                Score35 = 3,
                Score36 = 0,
                Score37 = 3,
                Score38 = 0,
                Score39 = 3,
                Score40 = 0,
                Score41 = 3,
                Score42 = 0,
                Score43 = 3,
                Score44 = 0,
                Score45 = 3,
                Score46 = 0,
                Score47 = 3,
                Score48 = 0,
                Score49 = 3,
                Score50 = 0,
                Score51 = 3,
                Score52 = 0,
                Score53 = 3,
                Score54 = 0,
                Score55 = 3,
                Score56 = 0,
                Score57 = 3,
                Score58 = 0,
                Score59 = 3,
                Score60 = 0,
                Score61 = 3,
                Score62 = 0,
                Score63 = 3,
                Score64 = 0,
                Score65 = 3,
                Score66 = 0,
                Score67 = 3,
                Score68 = 0,
                Score69 = 3,
                Score70 = 0,
                Score71 = 3,
                Score72 = 0,
                Score73 = 3,
                Score74 = 0,
                Score75 = 3,
                Score76 = 0,
                Score77 = 3,
                Score78 = 0
            };
            var d3Table = new Table()
            {
                //Id = 5003,
                User = "d3",
                Place1 = TeamsEnum.Arsenal,
                Place2 = TeamsEnum.Bournemouth,
                Place3 = TeamsEnum.Brighton,
                Place4 = TeamsEnum.Burnley,
                Place5 = TeamsEnum.Cardiff,
                Place6 = TeamsEnum.Chelsea,
                Place7 = TeamsEnum.CrystalPalace,
                Place8 = TeamsEnum.Everton,
                Place9 = TeamsEnum.Fulham,
                Place10 = TeamsEnum.Huddersfield,
                Place11 = TeamsEnum.Leicester,
                Place12 = TeamsEnum.Liverpool,
                Place13 = TeamsEnum.ManchesterCity,
                Place14 = TeamsEnum.ManchesterUnited,
                Place15 = TeamsEnum.Newcastle,
                Place16 = TeamsEnum.Southampton,
                Place17 = TeamsEnum.Tottenham,
                Place18 = TeamsEnum.Watford,
                Place19 = TeamsEnum.WestHam,
                Place20 = TeamsEnum.Wolves
            };

            _context.Championship.Add(d3Champ);
            _context.ChampionsLge.Add(d3CLge);
            _context.ChristmasPredictions.Add(d3Christmas);
            _context.FACup.Add(d3FAC);
            _context.Firsts.Add(d3Firsts);
            _context.LeagueOne.Add(d3Lge1);
            _context.LeagueTwo.Add(d3Lge2);
            _context.NationalLeague.Add(d3NLge);
            _context.Scores.Add(d3Scores);
            _context.Tables.Add(d3Table);

            /////////////////////////////////////////////////////////////////////

            var d4Champ = new Championship()
            {
                //Id = 5004,
                User = "d4",
                Playoff1 = ChampionshipTeamsEnum.AstonVilla,
                Playoff2 = ChampionshipTeamsEnum.Birmingham,
                Playoff3 = ChampionshipTeamsEnum.Blackburn,
                Playoff4 = ChampionshipTeamsEnum.Bolton,
                PlayoffWinner = ChampionshipTeamsEnum.AstonVilla,
                Relegation1 = ChampionshipTeamsEnum.Brentford,
                Relegation2 = ChampionshipTeamsEnum.BristolCity,
                Relegation3 = ChampionshipTeamsEnum.Derby,
                RunnerUp = ChampionshipTeamsEnum.Hull,
                Title = ChampionshipTeamsEnum.Ipswich
            };
            var d4CLge = new ChampionsLge()
            {
                //Id = 5004,
                User = "d4",
                QF1 = ChampionsTeamsEnum.BayerLeverkusen,
                QF2 = ChampionsTeamsEnum.BayernMunich,
                QF3 = ChampionsTeamsEnum.BorussiaDortmund,
                QF4 = ChampionsTeamsEnum.BorussiaMonchengladbach,
                QF5 = ChampionsTeamsEnum.Frankfurt,
                QF6 = ChampionsTeamsEnum.Hoffenheim,
                QF7 = ChampionsTeamsEnum.RBLeipzig,
                QF8 = ChampionsTeamsEnum.Schalke,
                SF1 = ChampionsTeamsEnum.BayernMunich,
                SF2 = ChampionsTeamsEnum.BorussiaDortmund,
                SF3 = ChampionsTeamsEnum.Schalke,
                SF4 = ChampionsTeamsEnum.BayerLeverkusen,
                Winner = ChampionsTeamsEnum.BorussiaDortmund,
                RunnerUp = ChampionsTeamsEnum.BayernMunich,
                TopScorePlayer = "Lewandowski",
                TopScoreTeam = ChampionsTeamsEnum.BorussiaDortmund
            };
            var d4Christmas = new ChristmasPredictions()
            {
                //Id = 5004,
                User = "d4",
                Bottom = TeamsEnum.Brighton,
                Top = TeamsEnum.Liverpool,
                ManagersOut = 3,
                PointsClear = 3,
                PointsDifference = 30
            };
            var d4FAC = new FACup()
            {
                //Id = 5004,
                User = "d4",
                QF1 = CupTeamsEnum.Arsenal,
                QF2 = CupTeamsEnum.Chelsea,
                QF3 = CupTeamsEnum.Liverpool,
                QF4 = CupTeamsEnum.ManchesterCity,
                QF5 = CupTeamsEnum.ManchesterUnited,
                QF6 = CupTeamsEnum.Tottenham,
                QF7 = CupTeamsEnum.Wolves,
                QF8 = CupTeamsEnum.Leicester,
                SF1 = CupTeamsEnum.Arsenal,
                SF2 = CupTeamsEnum.Chelsea,
                SF3 = CupTeamsEnum.Liverpool,
                SF4 = CupTeamsEnum.ManchesterCity,
                Winner = CupTeamsEnum.Liverpool,
                RunnerUp = CupTeamsEnum.ManchesterCity
            };
            var d4Firsts = new FirstPredictions()
            {
                //Id = 5004,
                User = "d4",
                Con100 = TeamsEnum.Huddersfield,
                Con25 = TeamsEnum.Huddersfield,
                Con50 = TeamsEnum.Huddersfield,
                Con75 = TeamsEnum.Huddersfield,
                Con5in1 = TeamsEnum.Huddersfield,
                Lose5inRow = TeamsEnum.Huddersfield,
                Score100 = TeamsEnum.Liverpool,
                Score25 = TeamsEnum.Liverpool,
                Score50 = TeamsEnum.Liverpool,
                Score5in1 = TeamsEnum.Liverpool,
                Score75 = TeamsEnum.Liverpool,
                TeamHattrick = TeamsEnum.Liverpool,
                TeamLoseManager = TeamsEnum.Huddersfield,
                TwoReds = TeamsEnum.Huddersfield,
                Win20 = TeamsEnum.Liverpool,
                Win5inRow = TeamsEnum.Liverpool
            };
            var d4Lge1 = new LeagueOne()
            {
                //Id = 5004,
                User = "d4",
                Playoff1 = LeagueOneTeamsEnum.AccringtonStanley,
                Playoff2 = LeagueOneTeamsEnum.AFCWimbledon,
                Playoff3 = LeagueOneTeamsEnum.Barnsley,
                Playoff4 = LeagueOneTeamsEnum.Blackpool,
                PlayoffWinner = LeagueOneTeamsEnum.AccringtonStanley,
                Title = LeagueOneTeamsEnum.Bradford,
                RunnerUp = LeagueOneTeamsEnum.BristolRovers,
                Relegation1 = LeagueOneTeamsEnum.BurtonAlbion,
                Relegation2 = LeagueOneTeamsEnum.CharltonAthletic,
                Relegation3 = LeagueOneTeamsEnum.Coventry
            };
            var d4Lge2 = new LeagueTwo()
            {
                //Id = 5004,
                User = "d4",
                Playoff1 = LeagueTwoTeamsEnum.Bury,
                Playoff2 = LeagueTwoTeamsEnum.Cambridge,
                Playoff3 = LeagueTwoTeamsEnum.Carlisle,
                Playoff4 = LeagueTwoTeamsEnum.Cheltenham,
                PlayoffWinner = LeagueTwoTeamsEnum.Bury,
                Title = LeagueTwoTeamsEnum.Colchester,
                RunnerUp = LeagueTwoTeamsEnum.Crawley,
                Relegation1 = LeagueTwoTeamsEnum.CreweAlexandra,
                Relegation2 = LeagueTwoTeamsEnum.Exeter,
                Relegation3 = LeagueTwoTeamsEnum.ForestGreenRovers
            };
            var d4NLge = new NationalLeague()
            {
                //Id = 5004,
                User = "d4",
                Title = NationalLeagueTeamsEnum.AFCFylde,
                PlayoffWinner = NationalLeagueTeamsEnum.AldershotTown
            };
            var d4Scores = new Scores()
            {
                //Id = 5004,
                User = "d4",
                Score1 = 4,
                Score2 = 0,
                Score3 = 4,
                Score4 = 0,
                Score5 = 4,
                Score6 = 0,
                Score7 = 4,
                Score8 = 0,
                Score9 = 4,
                Score10 = 0,
                Score11 = 4,
                Score12 = 0,
                Score13 = 4,
                Score14 = 0,
                Score15 = 4,
                Score16 = 0,
                Score17 = 4,
                Score18 = 0,
                Score19 = 4,
                Score20 = 0,
                Score21 = 4,
                Score22 = 0,
                Score23 = 4,
                Score24 = 0,
                Score25 = 4,
                Score26 = 0,
                Score27 = 4,
                Score28 = 0,
                Score29 = 4,
                Score30 = 0,
                Score31 = 4,
                Score32 = 0,
                Score33 = 4,
                Score34 = 0,
                Score35 = 4,
                Score36 = 0,
                Score37 = 4,
                Score38 = 0,
                Score39 = 4,
                Score40 = 0,
                Score41 = 4,
                Score42 = 0,
                Score43 = 4,
                Score44 = 0,
                Score45 = 4,
                Score46 = 0,
                Score47 = 4,
                Score48 = 0,
                Score49 = 4,
                Score50 = 0,
                Score51 = 4,
                Score52 = 0,
                Score53 = 4,
                Score54 = 0,
                Score55 = 4,
                Score56 = 0,
                Score57 = 4,
                Score58 = 0,
                Score59 = 4,
                Score60 = 0,
                Score61 = 4,
                Score62 = 0,
                Score63 = 4,
                Score64 = 0,
                Score65 = 4,
                Score66 = 0,
                Score67 = 4,
                Score68 = 0,
                Score69 = 4,
                Score70 = 0,
                Score71 = 4,
                Score72 = 0,
                Score73 = 4,
                Score74 = 0,
                Score75 = 4,
                Score76 = 0,
                Score77 = 4,
                Score78 = 0
            };
            var d4Table = new Table()
            {
                //Id = 5004,
                User = "d4",
                Place1 = TeamsEnum.Arsenal,
                Place2 = TeamsEnum.Bournemouth,
                Place3 = TeamsEnum.Brighton,
                Place4 = TeamsEnum.Burnley,
                Place5 = TeamsEnum.Cardiff,
                Place6 = TeamsEnum.Chelsea,
                Place7 = TeamsEnum.CrystalPalace,
                Place8 = TeamsEnum.Everton,
                Place9 = TeamsEnum.Fulham,
                Place10 = TeamsEnum.Huddersfield,
                Place11 = TeamsEnum.Leicester,
                Place12 = TeamsEnum.Liverpool,
                Place13 = TeamsEnum.ManchesterCity,
                Place14 = TeamsEnum.ManchesterUnited,
                Place15 = TeamsEnum.Newcastle,
                Place16 = TeamsEnum.Southampton,
                Place17 = TeamsEnum.Tottenham,
                Place18 = TeamsEnum.Watford,
                Place19 = TeamsEnum.WestHam,
                Place20 = TeamsEnum.Wolves
            };

            _context.Championship.Add(d4Champ);
            _context.ChampionsLge.Add(d4CLge);
            _context.ChristmasPredictions.Add(d4Christmas);
            _context.FACup.Add(d4FAC);
            _context.Firsts.Add(d4Firsts);
            _context.LeagueOne.Add(d4Lge1);
            _context.LeagueTwo.Add(d4Lge2);
            _context.NationalLeague.Add(d4NLge);
            _context.Scores.Add(d4Scores);
            _context.Tables.Add(d4Table);

            _context.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}