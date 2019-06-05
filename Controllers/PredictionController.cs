using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using UFPCore.Models;
using UFPCore.Models.Predictions;
using UFPCore.Data;
using System.Threading.Tasks;
using System.Security.Claims;

namespace UFPCore.Controllers
{
    [Authorize(Roles ="User,PaidUser,Admin")]
    public class PredictionController : Controller
    {
        private ApplicationDbContext _context;
        public PredictionController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[AllowAnonymous]
        //public ActionResult Test()
        //{
        //    var scores = new Scores();
        //    scores.User = "TestUser";
        //    _context.Scores.Add(scores);
        //    _context.SaveChanges();
        //    return RedirectToAction("About", "Home");
        //}
        //GET: Prediction
        public ActionResult Index()
        {

            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var scores = _context.Scores.SingleOrDefault(s => s.User == userID);
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (scores == null || scores.Id == 0)
            {
                scores = new Scores
                {
                    User = userID
                };
            }
            if (completions == null)
            {
                completions = new Completions
                {
                    User = userID,
                    ScoresCom = false,
                    FirstsCom = false,
                    FinalCom = false,
                    EoSCom = false,
                    ChampionsLgeCom = false,
                    FACupCom = false,
                    ChampionshipCom = false,
                    LeagueOneCom = false,
                    LeagueTwoCom = false,
                    NationalLeagueCom = false
                };
            }

            var viewModel = new ScoresViewModel
            {
                scores = scores,
                Completions = completions,
                ScoresCompleted = completions.ScoresCom
            };
            return View(viewModel);
        }

        //public ActionResult Index()
        //{
        //    var userID = User.Identity.GetUserName();
        //    if (scores.Id == 0)
        //    {
        //        scores.User = userID;
        //    }
        //    return View(scores);
        //}

        // POST: Predictions
        [HttpPost]
        public ActionResult Matches(ScoresViewModel viewModel)
        {
            var scoresIDb = _context.Scores.SingleOrDefault(s => s.Id == viewModel.scores.Id);
            var completionsIDb = _context.Completions.SingleOrDefault(c => c.Id == viewModel.Completions.Id);

            if (scoresIDb == null)
            {
                _context.Scores.Add(viewModel.scores);
            }
            else
            {
                scoresIDb.Score1 = viewModel.scores.Score1;
                scoresIDb.Score2 = viewModel.scores.Score2;
                scoresIDb.Score3 = viewModel.scores.Score3;
                scoresIDb.Score4 = viewModel.scores.Score4;
                scoresIDb.Score5 = viewModel.scores.Score5;
                scoresIDb.Score6 = viewModel.scores.Score6;
                scoresIDb.Score7 = viewModel.scores.Score7;
                scoresIDb.Score8 = viewModel.scores.Score8;
                scoresIDb.Score9 = viewModel.scores.Score9;
                scoresIDb.Score10 = viewModel.scores.Score10;
                scoresIDb.Score11 = viewModel.scores.Score11;
                scoresIDb.Score12 = viewModel.scores.Score12;
                scoresIDb.Score13 = viewModel.scores.Score13;
                scoresIDb.Score14 = viewModel.scores.Score14;
                scoresIDb.Score15 = viewModel.scores.Score15;
                scoresIDb.Score16 = viewModel.scores.Score16;
                scoresIDb.Score17 = viewModel.scores.Score17;
                scoresIDb.Score18 = viewModel.scores.Score18;
                scoresIDb.Score19 = viewModel.scores.Score19;
                scoresIDb.Score20 = viewModel.scores.Score20;
                scoresIDb.Score21 = viewModel.scores.Score21;
                scoresIDb.Score22 = viewModel.scores.Score22;
                scoresIDb.Score23 = viewModel.scores.Score23;
                scoresIDb.Score24 = viewModel.scores.Score24;
                scoresIDb.Score25 = viewModel.scores.Score25;
                scoresIDb.Score26 = viewModel.scores.Score26;
                scoresIDb.Score27 = viewModel.scores.Score27;
                scoresIDb.Score28 = viewModel.scores.Score28;
                scoresIDb.Score29 = viewModel.scores.Score29;
                scoresIDb.Score30 = viewModel.scores.Score30;
                scoresIDb.Score31 = viewModel.scores.Score31;
                scoresIDb.Score32 = viewModel.scores.Score32;
                scoresIDb.Score33 = viewModel.scores.Score33;
                scoresIDb.Score34 = viewModel.scores.Score34;
                scoresIDb.Score35 = viewModel.scores.Score35;
                scoresIDb.Score36 = viewModel.scores.Score36;
                scoresIDb.Score37 = viewModel.scores.Score37;
                scoresIDb.Score38 = viewModel.scores.Score38;
                scoresIDb.Score39 = viewModel.scores.Score39;
                scoresIDb.Score40 = viewModel.scores.Score40;
                scoresIDb.Score41 = viewModel.scores.Score41;
                scoresIDb.Score42 = viewModel.scores.Score42;
                scoresIDb.Score43 = viewModel.scores.Score43;
                scoresIDb.Score44 = viewModel.scores.Score44;
                scoresIDb.Score45 = viewModel.scores.Score45;
                scoresIDb.Score46 = viewModel.scores.Score46;
                scoresIDb.Score47 = viewModel.scores.Score47;
                scoresIDb.Score48 = viewModel.scores.Score48;
                scoresIDb.Score49 = viewModel.scores.Score49;
                scoresIDb.Score50 = viewModel.scores.Score50;
                scoresIDb.Score51 = viewModel.scores.Score51;
                scoresIDb.Score52 = viewModel.scores.Score52;
                scoresIDb.Score53 = viewModel.scores.Score53;
                scoresIDb.Score54 = viewModel.scores.Score54;
                scoresIDb.Score55 = viewModel.scores.Score55;
                scoresIDb.Score56 = viewModel.scores.Score56;
                scoresIDb.Score57 = viewModel.scores.Score57;
                scoresIDb.Score58 = viewModel.scores.Score58;
                scoresIDb.Score59 = viewModel.scores.Score59;
                scoresIDb.Score60 = viewModel.scores.Score60;
                scoresIDb.Score61 = viewModel.scores.Score61;
                scoresIDb.Score62 = viewModel.scores.Score62;
                scoresIDb.Score63 = viewModel.scores.Score63;
                scoresIDb.Score64 = viewModel.scores.Score64;
                scoresIDb.Score65 = viewModel.scores.Score65;
                scoresIDb.Score66 = viewModel.scores.Score66;
                scoresIDb.Score67 = viewModel.scores.Score67;
                scoresIDb.Score68 = viewModel.scores.Score68;
                scoresIDb.Score69 = viewModel.scores.Score69;
                scoresIDb.Score70 = viewModel.scores.Score70;
                scoresIDb.Score71 = viewModel.scores.Score71;
                scoresIDb.Score72 = viewModel.scores.Score72;
                scoresIDb.Score73 = viewModel.scores.Score73;
                scoresIDb.Score74 = viewModel.scores.Score74;
                scoresIDb.Score75 = viewModel.scores.Score75;
                scoresIDb.Score76 = viewModel.scores.Score76;
                scoresIDb.Score77 = viewModel.scores.Score77;
                scoresIDb.Score78 = viewModel.scores.Score78;
            }

            if (completionsIDb == null)
            {
                if(viewModel.ScoresCompleted == true)
                {
                    viewModel.Completions.ScoresCom = true;
                } else
                {
                    viewModel.Completions.ScoresCom = false;
                }
                viewModel.Completions.FirstsCom = false;
                viewModel.Completions.FinalCom = false;
                viewModel.Completions.EoSCom = false;
                viewModel.Completions.ChampionsLgeCom = false;
                viewModel.Completions.FACupCom = false;
                viewModel.Completions.ChampionshipCom = false;
                viewModel.Completions.LeagueOneCom = false;
                viewModel.Completions.LeagueTwoCom = false;
                viewModel.Completions.NationalLeagueCom = false;

                _context.Completions.Add(viewModel.Completions);
            }
            else
            {
                if (viewModel.ScoresCompleted == true)
                {
                    completionsIDb.ScoresCom = true;
                }
                else
                {
                    completionsIDb.ScoresCom = false;
                }
                if (User.IsInRole("User") 
                    && completionsIDb.ScoresCom == true
                    && completionsIDb.FirstsCom == true 
                    && completionsIDb.FinalCom == true 
                    && completionsIDb.EoSCom == true 
                    && completionsIDb.ChampionsLgeCom == true 
                    && completionsIDb.FACupCom == true 
                    && completionsIDb.ChampionshipCom == true
                    && completionsIDb.LeagueOneCom == true
                    && completionsIDb.LeagueTwoCom == true
                    && completionsIDb.NationalLeagueCom == true)
                {
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                }
            }
            
            _context.SaveChanges();
            return RedirectToAction("Firsts");
        }

        //GET: Firsts
        public ActionResult Firsts()
        {
            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var firsts = _context.Firsts.SingleOrDefault(s => s.User == userID);
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (firsts == null || firsts.Id == 0)
            {
                firsts = new FirstPredictions
                {
                    User = userID
                };
            }
            if (completions == null)
            {
                completions = new Completions
                {
                    User = userID,
                    ScoresCom = false,
                    FirstsCom = false,
                    FinalCom = false,
                    EoSCom = false,
                    ChampionsLgeCom = false,
                    FACupCom = false,
                    ChampionshipCom = false,
                    LeagueOneCom = false,
                    LeagueTwoCom = false,
                    NationalLeagueCom = false
                };
            }

            var viewModel = new FirstsViewModel
            {
                FirstPredictions = firsts,
                Completions = completions,
                FirstsCompleted = completions.FirstsCom
            };
            return View(viewModel);
        }

        // POST: Firsts
        [HttpPost]
        public ActionResult Firsts(FirstsViewModel viewModel)
        {
            var firstsIDb = _context.Firsts.SingleOrDefault(s => s.Id == viewModel.FirstPredictions.Id);
            var completionsIDb = _context.Completions.SingleOrDefault(c => c.Id == viewModel.Completions.Id);

            if (firstsIDb == null)
            {
                _context.Firsts.Add(viewModel.FirstPredictions);
            }
            else
            {
                firstsIDb.Score25 = viewModel.FirstPredictions.Score25;
                firstsIDb.Score50 = viewModel.FirstPredictions.Score50;
                firstsIDb.Score75 = viewModel.FirstPredictions.Score75;
                firstsIDb.Score100 = viewModel.FirstPredictions.Score100;
                firstsIDb.Con25 = viewModel.FirstPredictions.Con25;
                firstsIDb.Con50 = viewModel.FirstPredictions.Con50;
                firstsIDb.Con75 = viewModel.FirstPredictions.Con75;
                firstsIDb.Con100 = viewModel.FirstPredictions.Con100;
                firstsIDb.TeamHattrick = viewModel.FirstPredictions.TeamHattrick;
                firstsIDb.TeamLoseManager = viewModel.FirstPredictions.TeamLoseManager;
                firstsIDb.Score5in1 = viewModel.FirstPredictions.Score5in1;
                firstsIDb.Con5in1 = viewModel.FirstPredictions.Con5in1;
                firstsIDb.Win5inRow = viewModel.FirstPredictions.Win5inRow;
                firstsIDb.Lose5inRow = viewModel.FirstPredictions.Lose5inRow;
                firstsIDb.TwoReds = viewModel.FirstPredictions.TwoReds;
                firstsIDb.Win20 = viewModel.FirstPredictions.Win20;
            }

            if (completionsIDb == null)
            {
                if(viewModel.FirstsCompleted == true)
                {
                    viewModel.Completions.FirstsCom = true;
                } else
                {
                    viewModel.Completions.FirstsCom = false;
                }
                _context.Completions.Add(viewModel.Completions);
            }
            else
            {
                if(viewModel.FirstsCompleted == true)
                {
                    completionsIDb.FirstsCom = true;
                } else
                {
                    completionsIDb.FirstsCom = false;
                }
                if (User.IsInRole("User") 
                    && completionsIDb.ScoresCom == true 
                    && completionsIDb.FirstsCom == true
                    && completionsIDb.FinalCom == true 
                    && completionsIDb.EoSCom == true 
                    && completionsIDb.ChampionsLgeCom == true
                    && completionsIDb.FACupCom == true
                    && completionsIDb.ChampionshipCom == true
                    && completionsIDb.LeagueOneCom == true
                    && completionsIDb.LeagueTwoCom == true
                    && completionsIDb.NationalLeagueCom == true)
                {
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                }
            }

            
            _context.SaveChanges();
            return RedirectToAction("Final");
        }

        //GET: Final
        public ActionResult Final()
        {
            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var table = _context.Tables.SingleOrDefault(t => t.User == userID);
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (table == null || table.Id == 0)
            {
                table = new Table
                {
                    User = userID
                };
            }
            if (completions == null)
            {
                completions = new Completions
                {
                    User = userID,
                    ScoresCom = false,
                    FirstsCom = false,
                    FinalCom = false,
                    EoSCom = false,
                    ChampionsLgeCom = false,
                    FACupCom = false,
                    ChampionshipCom = false,
                    LeagueOneCom = false,
                    LeagueTwoCom = false,
                    NationalLeagueCom = false
                };
            }

            var viewModel = new FinalViewModel
            {
                table = table,
                Completions = completions,
                TableCompleted = completions.FinalCom
            };
            return View(viewModel);
        }

        // POST: Final
        [HttpPost]
        public ActionResult Final(FinalViewModel viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);
            
            var tableIDb = _context.Tables.SingleOrDefault(t => t.Id == viewModel.table.Id);
            var completionsIDb = _context.Completions.SingleOrDefault(c => c.Id == viewModel.Completions.Id);

            if (tableIDb == null)
            {
                _context.Tables.Add(viewModel.table);
            }
            else
            {
                tableIDb.Place1 = viewModel.table.Place1;
                tableIDb.Place2 = viewModel.table.Place2;
                tableIDb.Place3 = viewModel.table.Place3;
                tableIDb.Place4 = viewModel.table.Place4;
                tableIDb.Place5 = viewModel.table.Place5;
                tableIDb.Place6 = viewModel.table.Place6;
                tableIDb.Place7 = viewModel.table.Place7;
                tableIDb.Place8 = viewModel.table.Place8;
                tableIDb.Place9 = viewModel.table.Place9;
                tableIDb.Place10 = viewModel.table.Place10;
                tableIDb.Place11 = viewModel.table.Place11;
                tableIDb.Place12 = viewModel.table.Place12;
                tableIDb.Place13 = viewModel.table.Place13;
                tableIDb.Place14 = viewModel.table.Place14;
                tableIDb.Place15 = viewModel.table.Place15;
                tableIDb.Place16 = viewModel.table.Place16;
                tableIDb.Place17 = viewModel.table.Place17;
                tableIDb.Place18 = viewModel.table.Place18;
                tableIDb.Place19 = viewModel.table.Place19;
                tableIDb.Place20 = viewModel.table.Place20;
            }

            if (completionsIDb == null)
            {
                if(viewModel.TableCompleted == true)
                {
                    viewModel.Completions.FinalCom = true;
                } else
                {
                    viewModel.Completions.FinalCom = false;
                }
                _context.Completions.Add(viewModel.Completions);
            }
            else
            {
                if(viewModel.TableCompleted == true)
                {
                    completionsIDb.FinalCom = true;
                } else
                {
                    completionsIDb.FinalCom = false;
                }
                if (User.IsInRole("User") 
                    && completionsIDb.ScoresCom == true 
                    && completionsIDb.FirstsCom == true 
                    && completionsIDb.FinalCom == true
                    && completionsIDb.EoSCom == true 
                    && completionsIDb.ChampionsLgeCom == true
                    && completionsIDb.FACupCom == true
                    && completionsIDb.ChampionshipCom == true
                    && completionsIDb.LeagueOneCom == true
                    && completionsIDb.LeagueTwoCom == true
                    && completionsIDb.NationalLeagueCom == true)
                {
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                }

            }

            _context.SaveChanges();
            return RedirectToAction("Christmas");
        }

        //GET: Christmas
        public ActionResult Christmas()
        {
            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var christmas = _context.ChristmasPredictions.SingleOrDefault(s => s.User == userID);
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (christmas == null || christmas.Id == 0)
            {
                christmas = new ChristmasPredictions
                {
                    User = userID
                };
            }
            if (completions == null)
            {
                completions = new Completions
                {
                    User = userID,
                    ScoresCom = false,
                    FirstsCom = false,
                    FinalCom = false,
                    EoSCom = false,
                    ChampionsLgeCom = false,
                    FACupCom = false,
                    ChampionshipCom = false,
                    LeagueOneCom = false,
                    LeagueTwoCom = false,
                    NationalLeagueCom = false
                };
            }

            var viewModel = new ChristmasViewModel
            {
                ChristmasPredictions = christmas,
                Completions = completions,
                ChristmasCompleted = completions.EoSCom
            };
            return View(viewModel);
        }

        // POST: Christmas
        [HttpPost]
        public ActionResult Christmas(ChristmasViewModel viewModel)
        {
            var christmasIDb = _context.ChristmasPredictions.SingleOrDefault(s => s.Id == viewModel.ChristmasPredictions.Id);
            var completionsIDb = _context.Completions.SingleOrDefault(c => c.Id == viewModel.Completions.Id);

            if (christmasIDb == null)
            {
                _context.ChristmasPredictions.Add(viewModel.ChristmasPredictions);
            }
            else
            {
                christmasIDb.Top = viewModel.ChristmasPredictions.Top;
                christmasIDb.Bottom = viewModel.ChristmasPredictions.Bottom;
                christmasIDb.ManagersOut = viewModel.ChristmasPredictions.ManagersOut;
                christmasIDb.PointsDifference = viewModel.ChristmasPredictions.PointsDifference;
                christmasIDb.PointsClear = viewModel.ChristmasPredictions.PointsClear;
            }

            if (completionsIDb == null)
            {
                if(viewModel.ChristmasCompleted == true)
                {
                    viewModel.Completions.EoSCom = true;
                } else
                {
                    viewModel.Completions.EoSCom = false;
                }
                _context.Completions.Add(viewModel.Completions);
            }
            else
            {
                if(viewModel.ChristmasCompleted == true)
                {
                    completionsIDb.EoSCom = true;
                } else
                {
                    completionsIDb.EoSCom = false;
                }
                if (User.IsInRole("User") 
                    && completionsIDb.ScoresCom == true 
                    && completionsIDb.FirstsCom == true 
                    && completionsIDb.FinalCom == true 
                    && completionsIDb.EoSCom == true 
                    && completionsIDb.ChampionsLgeCom == true
                    && completionsIDb.FACupCom == true
                    && completionsIDb.ChampionshipCom == true
                    && completionsIDb.LeagueOneCom == true
                    && completionsIDb.LeagueTwoCom == true
                    && completionsIDb.NationalLeagueCom == true)
                {
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                }

            }
            _context.SaveChanges();
            return RedirectToAction("ChampionsLge");
        }

        //GET: ChampionsLge
        public ActionResult ChampionsLge()
        {
            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var championsLge = _context.ChampionsLge.SingleOrDefault(s => s.User == userID);
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (championsLge == null || championsLge.Id == 0)
            {
                championsLge = new ChampionsLge
                {
                    User = userID
                };
            }
            if (completions == null)
            {
                completions = new Completions
                {
                    User = userID,
                    ScoresCom = false,
                    FirstsCom = false,
                    FinalCom = false,
                    EoSCom = false,
                    ChampionsLgeCom = false,
                    FACupCom = false,
                    ChampionshipCom = false,
                    LeagueOneCom = false,
                    LeagueTwoCom = false,
                    NationalLeagueCom = false
                };
            }

            var viewModel = new ChampionsLgeViewModel
            {
                ChampionsLge = championsLge,
                Completions = completions,
                ChampLgeCompleted = completions.ChampionsLgeCom
            };
            return View(viewModel);
        }

        // POST: ChampionsLge
        [HttpPost]
        public ActionResult ChampionsLge(ChampionsLgeViewModel viewModel)
        {
            var championsLgeIDb = _context.ChampionsLge.SingleOrDefault(s => s.Id == viewModel.ChampionsLge.Id);
            var completionsIDb = _context.Completions.SingleOrDefault(c => c.Id == viewModel.Completions.Id);

            if (championsLgeIDb == null)
            {
                _context.ChampionsLge.Add(viewModel.ChampionsLge);
            }
            else
            {
                championsLgeIDb.QF1 = viewModel.ChampionsLge.QF1;
                championsLgeIDb.QF2 = viewModel.ChampionsLge.QF2;
                championsLgeIDb.QF3 = viewModel.ChampionsLge.QF3;
                championsLgeIDb.QF4 = viewModel.ChampionsLge.QF4;
                championsLgeIDb.QF5 = viewModel.ChampionsLge.QF5;
                championsLgeIDb.QF6 = viewModel.ChampionsLge.QF6;
                championsLgeIDb.QF7 = viewModel.ChampionsLge.QF7;
                championsLgeIDb.QF8 = viewModel.ChampionsLge.QF8;
                championsLgeIDb.SF1 = viewModel.ChampionsLge.SF1;
                championsLgeIDb.SF2 = viewModel.ChampionsLge.SF2;
                championsLgeIDb.SF3 = viewModel.ChampionsLge.SF3;
                championsLgeIDb.SF4 = viewModel.ChampionsLge.SF4;
                championsLgeIDb.Winner = viewModel.ChampionsLge.Winner;
                championsLgeIDb.RunnerUp = viewModel.ChampionsLge.RunnerUp;
                championsLgeIDb.TopScoreTeam = viewModel.ChampionsLge.TopScoreTeam;
                championsLgeIDb.TopScorePlayer = viewModel.ChampionsLge.TopScorePlayer;
            }

            if (completionsIDb == null)
            {
                if(viewModel.ChampLgeCompleted == true)
                {
                    viewModel.Completions.ChampionsLgeCom = true;
                } else
                {
                    viewModel.Completions.ChampionsLgeCom = false;
                }
                _context.Completions.Add(viewModel.Completions);
            }
            else
            {
                if(viewModel.ChampLgeCompleted == true)
                {
                    completionsIDb.ChampionsLgeCom = true;
                } else
                {
                    completionsIDb.ChampionsLgeCom = false;
                }
                if (User.IsInRole("User") 
                    && completionsIDb.ScoresCom == true 
                    && completionsIDb.FirstsCom == true 
                    && completionsIDb.FinalCom == true 
                    && completionsIDb.EoSCom == true 
                    && completionsIDb.ChampionsLgeCom == true
                    && completionsIDb.FACupCom == true
                    && completionsIDb.ChampionshipCom == true
                    && completionsIDb.LeagueOneCom == true
                    && completionsIDb.LeagueTwoCom == true
                    && completionsIDb.NationalLeagueCom == true)
                {
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                }

            }
            _context.SaveChanges();
            return RedirectToAction("FACup");
        }

        //GET: FACup
        public ActionResult FACup()
        {
            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var facup = _context.FACup.SingleOrDefault(s => s.User == userID);
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (facup == null || facup.Id == 0)
            {
                facup = new FACup
                {
                    User = userID
                };
            }
            if (completions == null)
            {
                completions = new Completions
                {
                    User = userID,
                    ScoresCom = false,
                    FirstsCom = false,
                    FinalCom = false,
                    EoSCom = false,
                    ChampionsLgeCom = false,
                    FACupCom = false,
                    ChampionshipCom = false,
                    LeagueOneCom = false,
                    LeagueTwoCom = false,
                    NationalLeagueCom = false
                };
            }

            var viewModel = new FACupViewModel
            {
                FACup = facup,
                Completions = completions,
                FACupCompleted = completions.FACupCom
            };
            return View(viewModel);
        }

        // POST: FACup
        [HttpPost]
        public ActionResult FACup(FACupViewModel viewModel)
        {
            var facupIDb = _context.FACup.SingleOrDefault(s => s.Id == viewModel.FACup.Id);
            var completionsIDb = _context.Completions.SingleOrDefault(c => c.Id == viewModel.Completions.Id);

            if (facupIDb == null)
            {
                _context.FACup.Add(viewModel.FACup);
            }
            else
            {
                facupIDb.QF1 = viewModel.FACup.QF1;
                facupIDb.QF2 = viewModel.FACup.QF2;
                facupIDb.QF3 = viewModel.FACup.QF3;
                facupIDb.QF4 = viewModel.FACup.QF4;
                facupIDb.QF5 = viewModel.FACup.QF5;
                facupIDb.QF6 = viewModel.FACup.QF6;
                facupIDb.QF7 = viewModel.FACup.QF7;
                facupIDb.QF8 = viewModel.FACup.QF8;
                facupIDb.SF1 = viewModel.FACup.SF1;
                facupIDb.SF2 = viewModel.FACup.SF2;
                facupIDb.SF3 = viewModel.FACup.SF3;
                facupIDb.SF4 = viewModel.FACup.SF4;
                facupIDb.Winner = viewModel.FACup.Winner;
                facupIDb.RunnerUp = viewModel.FACup.RunnerUp;
            }

            if (completionsIDb == null)
            {
                if(viewModel.FACupCompleted == true)
                {
                    viewModel.Completions.FACupCom = true;
                } else
                {
                    viewModel.Completions.FACupCom = false;
                }
                _context.Completions.Add(viewModel.Completions);
            }
            else
            {
                if(viewModel.FACupCompleted == true)
                {
                    completionsIDb.FACupCom = true;
                } else
                {
                    completionsIDb.FACupCom = false;
                }
                if (User.IsInRole("User")
                    && completionsIDb.ScoresCom == true
                    && completionsIDb.FirstsCom == true
                    && completionsIDb.FinalCom == true
                    && completionsIDb.EoSCom == true
                    && completionsIDb.ChampionsLgeCom == true
                    && completionsIDb.FACupCom == true
                    && completionsIDb.ChampionshipCom == true
                    && completionsIDb.LeagueOneCom == true
                    && completionsIDb.LeagueTwoCom == true
                    && completionsIDb.NationalLeagueCom == true)
                {
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                }

            }
            _context.SaveChanges();
            return RedirectToAction("Championship");
        }

        
        //GET: Championship
        public ActionResult Championship()
        {
            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var championship = _context.Championship.SingleOrDefault(s => s.User == userID);
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (championship == null || championship.Id == 0)
            {
                championship = new Championship
                {
                    User = userID
                };
            }
            if (completions == null)
            {
                completions = new Completions
                {
                    User = userID,
                    ScoresCom = false,
                    FirstsCom = false,
                    FinalCom = false,
                    EoSCom = false,
                    ChampionsLgeCom = false,
                    FACupCom = false,
                    ChampionshipCom = false,
                    LeagueOneCom = false,
                    LeagueTwoCom = false,
                    NationalLeagueCom = false
                };
            }

            var viewModel = new ChampionshipViewModel
            {
                Championship = championship,
                Completions = completions,
                ChampCompleted = completions.ChampionshipCom
            };
            return View(viewModel);
        }

        // POST: Championship
        [HttpPost]
        public ActionResult Championship(ChampionshipViewModel viewModel)
        {
            var championshipIDb = _context.Championship.SingleOrDefault(s => s.Id == viewModel.Championship.Id);
            var completionsIDb = _context.Completions.SingleOrDefault(c => c.Id == viewModel.Completions.Id);

            if (championshipIDb == null)
            {
                _context.Championship.Add(viewModel.Championship);
            }
            else
            {
                championshipIDb.Title = viewModel.Championship.Title;
                championshipIDb.RunnerUp = viewModel.Championship.RunnerUp;
                championshipIDb.Playoff1 = viewModel.Championship.Playoff1;
                championshipIDb.Playoff2 = viewModel.Championship.Playoff2;
                championshipIDb.Playoff3 = viewModel.Championship.Playoff3;
                championshipIDb.Playoff4 = viewModel.Championship.Playoff4;
                championshipIDb.PlayoffWinner = viewModel.Championship.PlayoffWinner;
                championshipIDb.Relegation1 = viewModel.Championship.Relegation1;
                championshipIDb.Relegation2 = viewModel.Championship.Relegation2;
                championshipIDb.Relegation3 = viewModel.Championship.Relegation3;
            }

            if (completionsIDb == null)
            {
                if(viewModel.ChampCompleted == true)
                {
                    viewModel.Completions.ChampionshipCom = true;
                } else
                {
                    viewModel.Completions.ChampionshipCom = false;
                }
                _context.Completions.Add(viewModel.Completions);
            }
            else
            {
                if(viewModel.ChampCompleted == true)
                {
                    completionsIDb.ChampionshipCom = true;
                } else
                {
                    completionsIDb.ChampionshipCom = false;
                }
                if (User.IsInRole("User")
                    && completionsIDb.ScoresCom == true
                    && completionsIDb.FirstsCom == true
                    && completionsIDb.FinalCom == true
                    && completionsIDb.EoSCom == true
                    && completionsIDb.ChampionsLgeCom == true
                    && completionsIDb.FACupCom == true
                    && completionsIDb.ChampionshipCom == true
                    && completionsIDb.LeagueOneCom == true
                    && completionsIDb.LeagueTwoCom == true
                    && completionsIDb.NationalLeagueCom == true)
                {
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                }

            }
            _context.SaveChanges();
            return RedirectToAction("LeagueOne");
        }

        //GET: League One
        public ActionResult LeagueOne()
        {
            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var leagueone = _context.LeagueOne.SingleOrDefault(s => s.User == userID);
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (leagueone == null || leagueone.Id == 0)
            {
                leagueone = new LeagueOne
                {
                    User = userID
                };
            }
            if (completions == null)
            {
                completions = new Completions
                {
                    User = userID,
                    ScoresCom = false,
                    FirstsCom = false,
                    FinalCom = false,
                    EoSCom = false,
                    ChampionsLgeCom = false,
                    FACupCom = false,
                    ChampionshipCom = false,
                    LeagueOneCom = false,
                    LeagueTwoCom = false,
                    NationalLeagueCom = false
                };
            }

            var viewModel = new LeagueOneViewModel
            {
                LeagueOne = leagueone,
                Completions = completions,
                LeagueOneCompleted = completions.LeagueOneCom
            };
            return View(viewModel);
        }

        // POST: League One
        [HttpPost]
        public ActionResult LeagueOne(LeagueOneViewModel viewModel)
        {
            var leagueoneIDb = _context.LeagueOne.SingleOrDefault(s => s.Id == viewModel.LeagueOne.Id);
            var completionsIDb = _context.Completions.SingleOrDefault(c => c.Id == viewModel.Completions.Id);

            if (leagueoneIDb == null)
            {
                _context.LeagueOne.Add(viewModel.LeagueOne);
            }
            else
            {
                leagueoneIDb.Title = viewModel.LeagueOne.Title;
                leagueoneIDb.RunnerUp = viewModel.LeagueOne.RunnerUp;
                leagueoneIDb.Playoff1 = viewModel.LeagueOne.Playoff1;
                leagueoneIDb.Playoff2 = viewModel.LeagueOne.Playoff2;
                leagueoneIDb.Playoff3 = viewModel.LeagueOne.Playoff3;
                leagueoneIDb.Playoff4 = viewModel.LeagueOne.Playoff4;
                leagueoneIDb.PlayoffWinner = viewModel.LeagueOne.PlayoffWinner;
                leagueoneIDb.Relegation1 = viewModel.LeagueOne.Relegation1;
                leagueoneIDb.Relegation2 = viewModel.LeagueOne.Relegation2;
                leagueoneIDb.Relegation3 = viewModel.LeagueOne.Relegation3;
            }

            if (completionsIDb == null)
            {
                if(viewModel.LeagueOneCompleted == true)
                {
                    viewModel.Completions.LeagueOneCom = true;
                } else
                {
                    viewModel.Completions.LeagueOneCom = false;
                }
                _context.Completions.Add(viewModel.Completions);
            }
            else
            {
                if(viewModel.LeagueOneCompleted == true)
                {
                    completionsIDb.LeagueOneCom = true;
                } else
                {
                    completionsIDb.LeagueOneCom = false;
                }
                if (User.IsInRole("User")
                    && completionsIDb.ScoresCom == true
                    && completionsIDb.FirstsCom == true
                    && completionsIDb.FinalCom == true
                    && completionsIDb.EoSCom == true
                    && completionsIDb.ChampionsLgeCom == true
                    && completionsIDb.FACupCom == true
                    && completionsIDb.ChampionshipCom == true
                    && completionsIDb.LeagueOneCom == true
                    && completionsIDb.LeagueTwoCom == true
                    && completionsIDb.NationalLeagueCom == true)
                {
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                }

            }
            _context.SaveChanges();
            return RedirectToAction("LeagueTwo");
        }

        //GET: League Two
        public ActionResult LeagueTwo()
        {
            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var leaguetwo = _context.LeagueTwo.SingleOrDefault(s => s.User == userID);
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (leaguetwo == null || leaguetwo.Id == 0)
            {
                leaguetwo = new LeagueTwo
                {
                    User = userID
                };
            }
            if (completions == null)
            {
                completions = new Completions
                {
                    User = userID,
                    ScoresCom = false,
                    FirstsCom = false,
                    FinalCom = false,
                    EoSCom = false,
                    ChampionsLgeCom = false,
                    FACupCom = false,
                    ChampionshipCom = false,
                    LeagueOneCom = false,
                    LeagueTwoCom = false,
                    NationalLeagueCom = false
                };
            }

            var viewModel = new LeagueTwoViewModel
            {
                LeagueTwo = leaguetwo,
                Completions = completions,
                LeagueTwoCompleted = completions.LeagueTwoCom
            };
            return View(viewModel);
        }

        // POST: League Two
        [HttpPost]
        public ActionResult LeagueTwo(LeagueTwoViewModel viewModel)
        {
            var leaguetwoIDb = _context.LeagueTwo.SingleOrDefault(s => s.Id == viewModel.LeagueTwo.Id);
            var completionsIDb = _context.Completions.SingleOrDefault(c => c.Id == viewModel.Completions.Id);

            if (leaguetwoIDb == null)
            {
                _context.LeagueTwo.Add(viewModel.LeagueTwo);
            }
            else
            {
                leaguetwoIDb.Title = viewModel.LeagueTwo.Title;
                leaguetwoIDb.RunnerUp = viewModel.LeagueTwo.RunnerUp;
                leaguetwoIDb.Playoff1 = viewModel.LeagueTwo.Playoff1;
                leaguetwoIDb.Playoff2 = viewModel.LeagueTwo.Playoff2;
                leaguetwoIDb.Playoff3 = viewModel.LeagueTwo.Playoff3;
                leaguetwoIDb.Playoff4 = viewModel.LeagueTwo.Playoff4;
                leaguetwoIDb.PlayoffWinner = viewModel.LeagueTwo.PlayoffWinner;
                leaguetwoIDb.Relegation1 = viewModel.LeagueTwo.Relegation1;
                leaguetwoIDb.Relegation2 = viewModel.LeagueTwo.Relegation2;
                leaguetwoIDb.Relegation3 = viewModel.LeagueTwo.Relegation3;
            }

            if (completionsIDb == null)
            {
                if(viewModel.LeagueTwoCompleted == true)
                {
                    viewModel.Completions.LeagueTwoCom = true;
                } else
                {
                    viewModel.Completions.LeagueTwoCom = false;
                }
                _context.Completions.Add(viewModel.Completions);
            }
            else
            {
                if(viewModel.LeagueTwoCompleted == true)
                {
                    completionsIDb.LeagueTwoCom = true;
                } else
                {
                    completionsIDb.LeagueTwoCom = false;
                }
                if (User.IsInRole("User")
                    && completionsIDb.ScoresCom == true
                    && completionsIDb.FirstsCom == true
                    && completionsIDb.FinalCom == true
                    && completionsIDb.EoSCom == true
                    && completionsIDb.ChampionsLgeCom == true
                    && completionsIDb.FACupCom == true
                    && completionsIDb.ChampionshipCom == true
                    && completionsIDb.LeagueOneCom == true
                    && completionsIDb.LeagueTwoCom == true
                    && completionsIDb.NationalLeagueCom == true)
                {
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                }

            }
            _context.SaveChanges();
            return RedirectToAction("NationalLeague");
        }

        //GET: National League
        public ActionResult NationalLeague()
        {
            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var nationalleague = _context.NationalLeague.SingleOrDefault(s => s.User == userID);
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (nationalleague == null || nationalleague.Id == 0)
            {
                nationalleague = new NationalLeague
                {
                    User = userID
                };
            }
            if (completions == null)
            {
                completions = new Completions
                {
                    User = userID,
                    ScoresCom = false,
                    FirstsCom = false,
                    FinalCom = false,
                    EoSCom = false,
                    ChampionsLgeCom = false,
                    FACupCom = false,
                    ChampionshipCom = false,
                    LeagueOneCom = false,
                    LeagueTwoCom = false,
                    NationalLeagueCom = false
                };
            }

            var viewModel = new NationalLeagueViewModel
            {
                NationalLeague = nationalleague,
                Completions = completions,
                NationalLgeCompleted = completions.NationalLeagueCom
            };
            return View(viewModel);
        }

        // POST: National League
        [HttpPost]
        public ActionResult NationalLeague(NationalLeagueViewModel viewModel)
        {
            var nationalleagueIDb = _context.NationalLeague.SingleOrDefault(s => s.Id == viewModel.NationalLeague.Id);
            var completionsIDb = _context.Completions.SingleOrDefault(c => c.Id == viewModel.Completions.Id);

            if (nationalleagueIDb == null)
            {
                _context.NationalLeague.Add(viewModel.NationalLeague);
            }
            else
            {
                nationalleagueIDb.Title = viewModel.NationalLeague.Title;
                nationalleagueIDb.PlayoffWinner = viewModel.NationalLeague.PlayoffWinner;
            }

            if (completionsIDb == null)
            {
                if(viewModel.NationalLgeCompleted == true)
                {
                    viewModel.Completions.NationalLeagueCom = true;
                } else
                {
                    viewModel.Completions.NationalLeagueCom = false;
                }
                _context.Completions.Add(viewModel.Completions);
            }
            else
            {
                if(viewModel.NationalLgeCompleted == true)
                {
                    completionsIDb.NationalLeagueCom = true;
                } else
                {
                    completionsIDb.NationalLeagueCom = false;
                }
                if (User.IsInRole("User")
                    && completionsIDb.ScoresCom == true
                    && completionsIDb.FirstsCom == true
                    && completionsIDb.FinalCom == true
                    && completionsIDb.EoSCom == true
                    && completionsIDb.ChampionsLgeCom == true
                    && completionsIDb.FACupCom == true
                    && completionsIDb.ChampionshipCom == true
                    && completionsIDb.LeagueOneCom == true
                    && completionsIDb.LeagueTwoCom == true
                    && completionsIDb.NationalLeagueCom == true)
                {
                    _context.SaveChanges();
                    return RedirectToAction("Index", "Payment");
                }

            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}