using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using UFPCore.Models;
using Microsoft.AspNetCore.Identity;
using UFPCore.Areas.Identity.Pages.Account;
using UFPCore.Data;

namespace UFPCore.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private ApplicationDbContext _context;

        public AdminController(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Admin
        public ActionResult Index()
        {
            var answers = _context.Answers.SingleOrDefault(a => a.Year == 2019);
            var updateInfo = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019);

            if (answers == null)
            {
                answers = new Answers
                {
                    Year = 2019
                };

                _context.Answers.Add(answers);
                _context.SaveChanges();
            }

            if (updateInfo == null)
            {
                updateInfo = new UpdateInfo
                {
                    Year = 2019
                };

                _context.UpdateInfos.Add(updateInfo);
                _context.SaveChanges();
            }

            var viewModel = new AdminPageViewModel
            {
                Answers = answers,
                UpdateInfo = updateInfo
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult ChangeUpdates(UpdateInfo updateInfo)
        {
            var updateInfoInDb = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019);
            updateInfoInDb.ChFinalTable = (updateInfo.ChFinalTable==0)?60:updateInfo.ChFinalTable;
            updateInfoInDb.ChPlayoffs = (updateInfo.ChPlayoffs == 0) ? 60 : updateInfo.ChPlayoffs;
            updateInfoInDb.Christmas = (updateInfo.Christmas == 0) ? 60 : updateInfo.Christmas;
            updateInfoInDb.CLFinalResults = (updateInfo.CLFinalResults == 0) ? 60 : updateInfo.CLFinalResults;
            updateInfoInDb.CLQFs = (updateInfo.CLQFs == 0) ? 60 : updateInfo.CLQFs;
            updateInfoInDb.CLSFs = (updateInfo.CLSFs == 0) ? 60 : updateInfo.CLSFs;
            updateInfoInDb.Con100 = (updateInfo.Con100 == 0) ? 60 : updateInfo.Con100;
            updateInfoInDb.Con25 = (updateInfo.Con25 == 0) ? 60 : updateInfo.Con25;
            updateInfoInDb.Con50 = (updateInfo.Con50 == 0) ? 60 : updateInfo.Con50;
            updateInfoInDb.Con5in1 = (updateInfo.Con5in1 == 0) ? 60 : updateInfo.Con5in1;
            updateInfoInDb.Con75 = (updateInfo.Con75 == 0) ? 60 : updateInfo.Con75;
            updateInfoInDb.CurrentUpdate = updateInfo.CurrentUpdate;
            updateInfoInDb.FACFinalResults = (updateInfo.FACFinalResults == 0) ? 60 : updateInfo.FACFinalResults;
            updateInfoInDb.FACQFs = (updateInfo.FACQFs == 0) ? 60 : updateInfo.FACQFs;
            updateInfoInDb.FACSFs = (updateInfo.FACSFs == 0) ? 60 : updateInfo.FACSFs;
            updateInfoInDb.LOFinalTable = (updateInfo.LOFinalTable == 0) ? 60 : updateInfo.LOFinalTable;
            updateInfoInDb.LOPlayoffs = (updateInfo.LOPlayoffs == 0) ? 60 : updateInfo.LOPlayoffs;
            updateInfoInDb.Lose5inRow = (updateInfo.Lose5inRow == 0) ? 60 : updateInfo.Lose5inRow;
            updateInfoInDb.LTFinalTable = (updateInfo.LTFinalTable == 0) ? 60 : updateInfo.LTFinalTable;
            updateInfoInDb.LTPlayoffs = (updateInfo.LTPlayoffs == 0) ? 60 : updateInfo.LTPlayoffs;
            updateInfoInDb.Match1 = (updateInfo.Match1 == 0) ? 60 : updateInfo.Match1;
            updateInfoInDb.Match2 = (updateInfo.Match2 == 0) ? 60 : updateInfo.Match2;
            updateInfoInDb.Match3 = (updateInfo.Match3 == 0) ? 60 : updateInfo.Match3;
            updateInfoInDb.Match4 = (updateInfo.Match4 == 0) ? 60 : updateInfo.Match4;
            updateInfoInDb.Match5 = (updateInfo.Match5 == 0) ? 60 : updateInfo.Match5;
            updateInfoInDb.Match6 = (updateInfo.Match6 == 0) ? 60 : updateInfo.Match6;
            updateInfoInDb.Match7 = (updateInfo.Match7 == 0) ? 60 : updateInfo.Match7;
            updateInfoInDb.Match8 = (updateInfo.Match8 == 0) ? 60 : updateInfo.Match8;
            updateInfoInDb.Match9 = (updateInfo.Match9 == 0) ? 60 : updateInfo.Match9;
            updateInfoInDb.Match10 =(updateInfo.Match10 == 0) ? 60 :  updateInfo.Match10;
            updateInfoInDb.Match11 =(updateInfo.Match11 == 0) ? 60 :  updateInfo.Match11;
            updateInfoInDb.Match12 =(updateInfo.Match12 == 0) ? 60 :  updateInfo.Match12;
            updateInfoInDb.Match13 =(updateInfo.Match13 == 0) ? 60 :  updateInfo.Match13;
            updateInfoInDb.Match14 =(updateInfo.Match14 == 0) ? 60 :  updateInfo.Match14;
            updateInfoInDb.Match15 =(updateInfo.Match15 == 0) ? 60 :  updateInfo.Match15;
            updateInfoInDb.Match16 =(updateInfo.Match16 == 0) ? 60 :  updateInfo.Match16;
            updateInfoInDb.Match17 =(updateInfo.Match17 == 0) ? 60 :  updateInfo.Match17;
            updateInfoInDb.Match18 =(updateInfo.Match18 == 0) ? 60 :  updateInfo.Match18;
            updateInfoInDb.Match19 =(updateInfo.Match19 == 0) ? 60 :  updateInfo.Match19;
            updateInfoInDb.Match20 =(updateInfo.Match20 == 0) ? 60 :  updateInfo.Match20;
            updateInfoInDb.Match21 =(updateInfo.Match21 == 0) ? 60 :  updateInfo.Match21;
            updateInfoInDb.Match22 =(updateInfo.Match22 == 0) ? 60 :  updateInfo.Match22;
            updateInfoInDb.Match23 =(updateInfo.Match23 == 0) ? 60 :  updateInfo.Match23;
            updateInfoInDb.Match24 =(updateInfo.Match24 == 0) ? 60 :  updateInfo.Match24;
            updateInfoInDb.Match25 =(updateInfo.Match25 == 0) ? 60 :  updateInfo.Match25;
            updateInfoInDb.Match26 =(updateInfo.Match26 == 0) ? 60 :  updateInfo.Match26;
            updateInfoInDb.Match27 =(updateInfo.Match27 == 0) ? 60 :  updateInfo.Match27;
            updateInfoInDb.Match28 =(updateInfo.Match28 == 0) ? 60 :  updateInfo.Match28;
            updateInfoInDb.Match29 =(updateInfo.Match29 == 0) ? 60 :  updateInfo.Match29;
            updateInfoInDb.Match30 =(updateInfo.Match30 == 0) ? 60 :  updateInfo.Match30;
            updateInfoInDb.Match31 =(updateInfo.Match31 == 0) ? 60 :  updateInfo.Match31;
            updateInfoInDb.Match32 =(updateInfo.Match32 == 0) ? 60 :  updateInfo.Match32;
            updateInfoInDb.Match33 =(updateInfo.Match33 == 0) ? 60 :  updateInfo.Match33;
            updateInfoInDb.Match34 =(updateInfo.Match34 == 0) ? 60 :  updateInfo.Match34;
            updateInfoInDb.Match35 =(updateInfo.Match35 == 0) ? 60 :  updateInfo.Match35;
            updateInfoInDb.Match36 =(updateInfo.Match36 == 0) ? 60 :  updateInfo.Match36;
            updateInfoInDb.Match37 =(updateInfo.Match37 == 0) ? 60 :  updateInfo.Match37;
            updateInfoInDb.Match38 =(updateInfo.Match38 == 0) ? 60 :  updateInfo.Match38;
            updateInfoInDb.Match39 = (updateInfo.Match39 == 0) ? 60 : updateInfo.Match39;
            updateInfoInDb.NLFinalTable = (updateInfo.NLFinalTable == 0) ? 60 : updateInfo.NLFinalTable;
            updateInfoInDb.NLPlayoffs = (updateInfo.NLPlayoffs == 0) ? 60 : updateInfo.NLPlayoffs;
            updateInfoInDb.PLFinalResults = (updateInfo.PLFinalResults == 0) ? 60 : updateInfo.PLFinalResults;
            updateInfoInDb.Score100 = (updateInfo.Score100 == 0) ? 60 : updateInfo.Score100;
            updateInfoInDb.Score25 = (updateInfo.Score25 == 0) ? 60 : updateInfo.Score25;
            updateInfoInDb.Score50 = (updateInfo.Score50 == 0) ? 60 : updateInfo.Score50;
            updateInfoInDb.Score5in1 = (updateInfo.Score5in1 == 0) ? 60 : updateInfo.Score5in1;
            updateInfoInDb.Score75 = (updateInfo.Score75 == 0) ? 60 : updateInfo.Score75;
            updateInfoInDb.TeamHattrick = (updateInfo.TeamHattrick == 0) ? 60 : updateInfo.TeamHattrick;
            updateInfoInDb.TeamLoseManager = (updateInfo.TeamLoseManager == 0) ? 60 : updateInfo.TeamLoseManager;
            updateInfoInDb.TwoReds = (updateInfo.TwoReds == 0) ? 60 : updateInfo.TwoReds;
            updateInfoInDb.Win20 = (updateInfo.Win20 == 0) ? 60 : updateInfo.Win20;
            updateInfoInDb.Win5inRow = (updateInfo.Win5inRow == 0) ? 60 : updateInfo.Win5inRow;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AddOneToUpdateNumbers(AdminPageViewModel viewmodel)
        {
            var updateInfoInDb = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019);
            updateInfoInDb.ChFinalTable = (updateInfoInDb.ChFinalTable < viewmodel.updateBreakPoint) ? updateInfoInDb.ChFinalTable : updateInfoInDb.ChFinalTable + 1;
            updateInfoInDb.ChPlayoffs = (updateInfoInDb.ChPlayoffs < viewmodel.updateBreakPoint) ? updateInfoInDb.ChPlayoffs : updateInfoInDb.ChPlayoffs + 1;
            updateInfoInDb.Christmas = (updateInfoInDb.Christmas < viewmodel.updateBreakPoint) ? updateInfoInDb.Christmas : updateInfoInDb.Christmas + 1;
            updateInfoInDb.CLFinalResults = (updateInfoInDb.CLFinalResults < viewmodel.updateBreakPoint) ? updateInfoInDb.CLFinalResults : updateInfoInDb.CLFinalResults + 1;
            updateInfoInDb.CLQFs = (updateInfoInDb.CLQFs < viewmodel.updateBreakPoint) ? updateInfoInDb.CLQFs : updateInfoInDb.CLQFs + 1;
            updateInfoInDb.CLSFs = (updateInfoInDb.CLSFs < viewmodel.updateBreakPoint) ? updateInfoInDb.CLSFs : updateInfoInDb.CLSFs + 1;
            updateInfoInDb.Con100 = (updateInfoInDb.Con100 < viewmodel.updateBreakPoint) ? updateInfoInDb.Con100 : updateInfoInDb.Con100 + 1;
            updateInfoInDb.Con25 = (updateInfoInDb.Con25 < viewmodel.updateBreakPoint) ? updateInfoInDb.Con25 : updateInfoInDb.Con25 + 1;
            updateInfoInDb.Con50 = (updateInfoInDb.Con50 < viewmodel.updateBreakPoint) ? updateInfoInDb.Con50 : updateInfoInDb.Con50 + 1;
            updateInfoInDb.Con5in1 = (updateInfoInDb.Con5in1 < viewmodel.updateBreakPoint) ? updateInfoInDb.Con5in1 : updateInfoInDb.Con5in1 + 1;
            updateInfoInDb.Con75 = (updateInfoInDb.Con75 < viewmodel.updateBreakPoint) ? updateInfoInDb.Con75 : updateInfoInDb.Con75 + 1;
            updateInfoInDb.FACFinalResults = (updateInfoInDb.FACFinalResults < viewmodel.updateBreakPoint) ? updateInfoInDb.FACFinalResults : updateInfoInDb.FACFinalResults + 1;
            updateInfoInDb.FACQFs = (updateInfoInDb.FACQFs < viewmodel.updateBreakPoint) ? updateInfoInDb.FACQFs : updateInfoInDb.FACQFs + 1;
            updateInfoInDb.FACSFs = (updateInfoInDb.FACSFs < viewmodel.updateBreakPoint) ? updateInfoInDb.FACSFs : updateInfoInDb.FACSFs + 1;
            updateInfoInDb.LOFinalTable = (updateInfoInDb.LOFinalTable < viewmodel.updateBreakPoint) ? updateInfoInDb.LOFinalTable : updateInfoInDb.LOFinalTable + 1;
            updateInfoInDb.LOPlayoffs = (updateInfoInDb.LOPlayoffs < viewmodel.updateBreakPoint) ? updateInfoInDb.LOPlayoffs : updateInfoInDb.LOPlayoffs + 1;
            updateInfoInDb.Lose5inRow = (updateInfoInDb.Lose5inRow < viewmodel.updateBreakPoint) ? updateInfoInDb.Lose5inRow : updateInfoInDb.Lose5inRow + 1;
            updateInfoInDb.LTFinalTable = (updateInfoInDb.LTFinalTable < viewmodel.updateBreakPoint) ? updateInfoInDb.LTFinalTable : updateInfoInDb.LTFinalTable + 1;
            updateInfoInDb.LTPlayoffs = (updateInfoInDb.LTPlayoffs < viewmodel.updateBreakPoint) ? updateInfoInDb.LTPlayoffs : updateInfoInDb.LTPlayoffs + 1;
            updateInfoInDb.Match1 = (updateInfoInDb.Match1 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match1 : updateInfoInDb.Match1 + 1;
            updateInfoInDb.Match2 = (updateInfoInDb.Match2 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match2 : updateInfoInDb.Match2 + 1;
            updateInfoInDb.Match3 = (updateInfoInDb.Match3 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match3 : updateInfoInDb.Match3 + 1;
            updateInfoInDb.Match4 = (updateInfoInDb.Match4 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match4 : updateInfoInDb.Match4 + 1;
            updateInfoInDb.Match5 = (updateInfoInDb.Match5 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match5 : updateInfoInDb.Match5 + 1;
            updateInfoInDb.Match6 = (updateInfoInDb.Match6 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match6 : updateInfoInDb.Match6 + 1;
            updateInfoInDb.Match7 = (updateInfoInDb.Match7 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match7 : updateInfoInDb.Match7 + 1;
            updateInfoInDb.Match8 = (updateInfoInDb.Match8 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match8 : updateInfoInDb.Match8 + 1;
            updateInfoInDb.Match9 = (updateInfoInDb.Match9 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match9 : updateInfoInDb.Match9 + 1;
            updateInfoInDb.Match10 = (updateInfoInDb.Match10 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match10 : updateInfoInDb.Match10 + 1;
            updateInfoInDb.Match11 = (updateInfoInDb.Match11 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match11 : updateInfoInDb.Match11 + 1;
            updateInfoInDb.Match12 = (updateInfoInDb.Match12 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match12 : updateInfoInDb.Match12 + 1;
            updateInfoInDb.Match13 = (updateInfoInDb.Match13 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match13 : updateInfoInDb.Match13 + 1;
            updateInfoInDb.Match14 = (updateInfoInDb.Match14 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match14 : updateInfoInDb.Match14 + 1;
            updateInfoInDb.Match15 = (updateInfoInDb.Match15 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match15 : updateInfoInDb.Match15 + 1;
            updateInfoInDb.Match16 = (updateInfoInDb.Match16 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match16 : updateInfoInDb.Match16 + 1;
            updateInfoInDb.Match17 = (updateInfoInDb.Match17 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match17 : updateInfoInDb.Match17 + 1;
            updateInfoInDb.Match18 = (updateInfoInDb.Match18 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match18 : updateInfoInDb.Match18 + 1;
            updateInfoInDb.Match19 = (updateInfoInDb.Match19 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match19 : updateInfoInDb.Match19 + 1;
            updateInfoInDb.Match20 = (updateInfoInDb.Match20 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match20 : updateInfoInDb.Match20 + 1;
            updateInfoInDb.Match21 = (updateInfoInDb.Match21 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match21 : updateInfoInDb.Match21 + 1;
            updateInfoInDb.Match22 = (updateInfoInDb.Match22 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match22 : updateInfoInDb.Match22 + 1;
            updateInfoInDb.Match23 = (updateInfoInDb.Match23 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match23 : updateInfoInDb.Match23 + 1;
            updateInfoInDb.Match24 = (updateInfoInDb.Match24 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match24 : updateInfoInDb.Match24 + 1;
            updateInfoInDb.Match25 = (updateInfoInDb.Match25 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match25 : updateInfoInDb.Match25 + 1;
            updateInfoInDb.Match26 = (updateInfoInDb.Match26 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match26 : updateInfoInDb.Match26 + 1;
            updateInfoInDb.Match27 = (updateInfoInDb.Match27 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match27 : updateInfoInDb.Match27 + 1;
            updateInfoInDb.Match28 = (updateInfoInDb.Match28 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match28 : updateInfoInDb.Match28 + 1;
            updateInfoInDb.Match29 = (updateInfoInDb.Match29 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match29 : updateInfoInDb.Match29 + 1;
            updateInfoInDb.Match30 = (updateInfoInDb.Match30 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match30 : updateInfoInDb.Match30 + 1;
            updateInfoInDb.Match31 = (updateInfoInDb.Match31 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match31 : updateInfoInDb.Match31 + 1;
            updateInfoInDb.Match32 = (updateInfoInDb.Match32 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match32 : updateInfoInDb.Match32 + 1;
            updateInfoInDb.Match33 = (updateInfoInDb.Match33 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match33 : updateInfoInDb.Match33 + 1;
            updateInfoInDb.Match34 = (updateInfoInDb.Match34 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match34 : updateInfoInDb.Match34 + 1;
            updateInfoInDb.Match35 = (updateInfoInDb.Match35 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match35 : updateInfoInDb.Match35 + 1;
            updateInfoInDb.Match36 = (updateInfoInDb.Match36 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match36 : updateInfoInDb.Match36 + 1;
            updateInfoInDb.Match37 = (updateInfoInDb.Match37 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match37 : updateInfoInDb.Match37 + 1;
            updateInfoInDb.Match38 = (updateInfoInDb.Match38 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match38 : updateInfoInDb.Match38 + 1;
            updateInfoInDb.Match39 = (updateInfoInDb.Match39 < viewmodel.updateBreakPoint) ? updateInfoInDb.Match39 : updateInfoInDb.Match39 + 1;
            updateInfoInDb.NLFinalTable = (updateInfoInDb.NLFinalTable < viewmodel.updateBreakPoint) ? updateInfoInDb.NLFinalTable : updateInfoInDb.NLFinalTable + 1;
            updateInfoInDb.NLPlayoffs = (updateInfoInDb.NLPlayoffs < viewmodel.updateBreakPoint) ? updateInfoInDb.NLPlayoffs : updateInfoInDb.NLPlayoffs + 1;
            updateInfoInDb.PLFinalResults = (updateInfoInDb.PLFinalResults < viewmodel.updateBreakPoint) ? updateInfoInDb.PLFinalResults : updateInfoInDb.PLFinalResults + 1;
            updateInfoInDb.Score100 = (updateInfoInDb.Score100 < viewmodel.updateBreakPoint) ? updateInfoInDb.Score100 : updateInfoInDb.Score100 + 1;
            updateInfoInDb.Score25 = (updateInfoInDb.Score25 < viewmodel.updateBreakPoint) ? updateInfoInDb.Score25 : updateInfoInDb.Score25 + 1;
            updateInfoInDb.Score50 = (updateInfoInDb.Score50 < viewmodel.updateBreakPoint) ? updateInfoInDb.Score50 : updateInfoInDb.Score50 + 1;
            updateInfoInDb.Score5in1 = (updateInfoInDb.Score5in1 < viewmodel.updateBreakPoint) ? updateInfoInDb.Score5in1 : updateInfoInDb.Score5in1 + 1;
            updateInfoInDb.Score75 = (updateInfoInDb.Score75 < viewmodel.updateBreakPoint) ? updateInfoInDb.Score75 : updateInfoInDb.Score75 + 1;
            updateInfoInDb.TeamHattrick = (updateInfoInDb.TeamHattrick < viewmodel.updateBreakPoint) ? updateInfoInDb.TeamHattrick : updateInfoInDb.TeamHattrick + 1;
            updateInfoInDb.TeamLoseManager = (updateInfoInDb.TeamLoseManager < viewmodel.updateBreakPoint) ? updateInfoInDb.TeamLoseManager : updateInfoInDb.TeamLoseManager + 1;
            updateInfoInDb.TwoReds = (updateInfoInDb.TwoReds < viewmodel.updateBreakPoint) ? updateInfoInDb.TwoReds : updateInfoInDb.TwoReds + 1;
            updateInfoInDb.Win20 = (updateInfoInDb.Win20 < viewmodel.updateBreakPoint) ? updateInfoInDb.Win20 : updateInfoInDb.Win20 + 1;
            updateInfoInDb.Win5inRow = (updateInfoInDb.Win5inRow < viewmodel.updateBreakPoint) ? updateInfoInDb.Win5inRow : updateInfoInDb.Win5inRow + 1;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UpdateAnswers(AdminPageViewModel updatedAnswers)
        {
            var answersInDb = _context.Answers.SingleOrDefault(a => a.Year == 2019);
            answersInDb.CLQF1 = updatedAnswers.Answers.CLQF1;
            answersInDb.CLQF2 = updatedAnswers.Answers.CLQF2;
            answersInDb.CLQF3 = updatedAnswers.Answers.CLQF3;
            answersInDb.CLQF4 = updatedAnswers.Answers.CLQF4;
            answersInDb.CLQF5 = updatedAnswers.Answers.CLQF5;
            answersInDb.CLQF6 = updatedAnswers.Answers.CLQF6;
            answersInDb.CLQF7 = updatedAnswers.Answers.CLQF7;
            answersInDb.CLQF8 = updatedAnswers.Answers.CLQF8;
            answersInDb.CLRunnerUp = updatedAnswers.Answers.CLRunnerUp;
            answersInDb.CLSF1 = updatedAnswers.Answers.CLSF1;
            answersInDb.CLSF2 = updatedAnswers.Answers.CLSF2;
            answersInDb.CLSF3 = updatedAnswers.Answers.CLSF3;
            answersInDb.CLSF4 = updatedAnswers.Answers.CLSF4;
            answersInDb.CLWinner = updatedAnswers.Answers.CLWinner;
            answersInDb.Con100 = updatedAnswers.Answers.Con100;
            answersInDb.Con25 = updatedAnswers.Answers.Con25;
            answersInDb.Con50 = updatedAnswers.Answers.Con50;
            answersInDb.Con5in1 = updatedAnswers.Answers.Con5in1;
            answersInDb.Con75 = updatedAnswers.Answers.Con75;
            answersInDb.CPlayoff1 = updatedAnswers.Answers.CPlayoff1;
            answersInDb.CPlayoff2 = updatedAnswers.Answers.CPlayoff2;
            answersInDb.CPlayoff3 = updatedAnswers.Answers.CPlayoff3;
            answersInDb.CPlayoff4 = updatedAnswers.Answers.CPlayoff4;
            answersInDb.CPlayoffWinner = updatedAnswers.Answers.CPlayoffWinner;
            answersInDb.CRelegation1 = updatedAnswers.Answers.CRelegation1;
            answersInDb.CRelegation2 = updatedAnswers.Answers.CRelegation2;
            answersInDb.CRelegation3 = updatedAnswers.Answers.CRelegation3;
            answersInDb.CRunnerUp = updatedAnswers.Answers.CRunnerUp;
            answersInDb.CTitle = updatedAnswers.Answers.CTitle;
            answersInDb.FACQF1 = updatedAnswers.Answers.FACQF1;
            answersInDb.FACQF2 = updatedAnswers.Answers.FACQF2;
            answersInDb.FACQF3 = updatedAnswers.Answers.FACQF3;
            answersInDb.FACQF4 = updatedAnswers.Answers.FACQF4;
            answersInDb.FACQF5 = updatedAnswers.Answers.FACQF5;
            answersInDb.FACQF6 = updatedAnswers.Answers.FACQF6;
            answersInDb.FACQF7 = updatedAnswers.Answers.FACQF7;
            answersInDb.FACQF8 = updatedAnswers.Answers.FACQF8;
            answersInDb.FACRunnerUp = updatedAnswers.Answers.FACRunnerUp;
            answersInDb.FACSF1 = updatedAnswers.Answers.FACSF1;
            answersInDb.FACSF2 = updatedAnswers.Answers.FACSF2;
            answersInDb.FACSF3 = updatedAnswers.Answers.FACSF3;
            answersInDb.FACSF4 = updatedAnswers.Answers.FACSF4;
            answersInDb.FACWinner = updatedAnswers.Answers.FACWinner;
            answersInDb.FirstScore100 = updatedAnswers.Answers.FirstScore100;
            answersInDb.FirstScore25 = updatedAnswers.Answers.FirstScore25;
            answersInDb.FirstScore50 = updatedAnswers.Answers.FirstScore50;
            answersInDb.FirstScore75 = updatedAnswers.Answers.FirstScore75;
            answersInDb.LOPlayoff1 = updatedAnswers.Answers.LOPlayoff1;
            answersInDb.LOPlayoff2 = updatedAnswers.Answers.LOPlayoff2;
            answersInDb.LOPlayoff3 = updatedAnswers.Answers.LOPlayoff3;
            answersInDb.LOPlayoff4 = updatedAnswers.Answers.LOPlayoff4;
            answersInDb.LOPlayoffWinner = updatedAnswers.Answers.LOPlayoffWinner;
            answersInDb.LORelegation1 = updatedAnswers.Answers.LORelegation1;
            answersInDb.LORelegation2 = updatedAnswers.Answers.LORelegation2;
            answersInDb.LORelegation3 = updatedAnswers.Answers.LORelegation3;
            answersInDb.LORunnerUp = updatedAnswers.Answers.LORunnerUp;
            answersInDb.Lose5inRow = updatedAnswers.Answers.Lose5inRow;
            answersInDb.LOTitle = updatedAnswers.Answers.LOTitle;
            answersInDb.LTPlayoff1 = updatedAnswers.Answers.LTPlayoff1;
            answersInDb.LTPlayoff2 = updatedAnswers.Answers.LTPlayoff2;
            answersInDb.LTPlayoff3 = updatedAnswers.Answers.LTPlayoff3;
            answersInDb.LTPlayoff4 = updatedAnswers.Answers.LTPlayoff4;
            answersInDb.LTPlayoffWinner = updatedAnswers.Answers.LTPlayoffWinner;
            answersInDb.LTRelegation1 = updatedAnswers.Answers.LTRelegation1;
            answersInDb.LTRelegation2 = updatedAnswers.Answers.LTRelegation2;
            answersInDb.LTRelegation3 = updatedAnswers.Answers.LTRelegation3;
            answersInDb.LTRunnerUp = updatedAnswers.Answers.LTRunnerUp;
            answersInDb.LTTitle = updatedAnswers.Answers.LTTitle;
            answersInDb.ManagersOut = updatedAnswers.Answers.ManagersOut;
            answersInDb.NLPlayoffWinner = updatedAnswers.Answers.NLPlayoffWinner;
            answersInDb.NLTitle = updatedAnswers.Answers.NLTitle;
            answersInDb.Place1 = updatedAnswers.Answers.Place1;
            answersInDb.Place2 = updatedAnswers.Answers.Place2;
            answersInDb.Place3 = updatedAnswers.Answers.Place3;
            answersInDb.Place4 = updatedAnswers.Answers.Place4;
            answersInDb.Place5 = updatedAnswers.Answers.Place5;
            answersInDb.Place6 = updatedAnswers.Answers.Place6;
            answersInDb.Place7 = updatedAnswers.Answers.Place7;
            answersInDb.Place8 = updatedAnswers.Answers.Place8;
            answersInDb.Place9 = updatedAnswers.Answers.Place9;
            answersInDb.Place10 = updatedAnswers.Answers.Place10;
            answersInDb.Place11 = updatedAnswers.Answers.Place11;
            answersInDb.Place12 = updatedAnswers.Answers.Place12;
            answersInDb.Place13 = updatedAnswers.Answers.Place13;
            answersInDb.Place14 = updatedAnswers.Answers.Place14;
            answersInDb.Place15 = updatedAnswers.Answers.Place15;
            answersInDb.Place16 = updatedAnswers.Answers.Place16;
            answersInDb.Place17 = updatedAnswers.Answers.Place17;
            answersInDb.Place18 = updatedAnswers.Answers.Place18;
            answersInDb.Place19 = updatedAnswers.Answers.Place19;
            answersInDb.Place20 = updatedAnswers.Answers.Place20;
            answersInDb.PointsClear = updatedAnswers.Answers.PointsClear;
            answersInDb.PointsDifference = updatedAnswers.Answers.PointsDifference;
            answersInDb.Score1 = updatedAnswers.Answers.Score1;
            answersInDb.Score2 = updatedAnswers.Answers.Score2;
            answersInDb.Score3 = updatedAnswers.Answers.Score3;
            answersInDb.Score4 = updatedAnswers.Answers.Score4;
            answersInDb.Score5 = updatedAnswers.Answers.Score5;
            answersInDb.Score6 = updatedAnswers.Answers.Score6;
            answersInDb.Score7 = updatedAnswers.Answers.Score7;
            answersInDb.Score8 = updatedAnswers.Answers.Score8;
            answersInDb.Score9 = updatedAnswers.Answers.Score9;
            answersInDb.Score10 = updatedAnswers.Answers.Score10;
            answersInDb.Score11 = updatedAnswers.Answers.Score11;
            answersInDb.Score12 = updatedAnswers.Answers.Score12;
            answersInDb.Score13 = updatedAnswers.Answers.Score13;
            answersInDb.Score14 = updatedAnswers.Answers.Score14;
            answersInDb.Score15 = updatedAnswers.Answers.Score15;
            answersInDb.Score16 = updatedAnswers.Answers.Score16;
            answersInDb.Score17 = updatedAnswers.Answers.Score17;
            answersInDb.Score18 = updatedAnswers.Answers.Score18;
            answersInDb.Score19 = updatedAnswers.Answers.Score19;
            answersInDb.Score20 = updatedAnswers.Answers.Score20;
            answersInDb.Score21 = updatedAnswers.Answers.Score21;
            answersInDb.Score22 = updatedAnswers.Answers.Score22;
            answersInDb.Score23 = updatedAnswers.Answers.Score23;
            answersInDb.Score24 = updatedAnswers.Answers.Score24;
            answersInDb.Score25 = updatedAnswers.Answers.Score25;
            answersInDb.Score26 = updatedAnswers.Answers.Score26;
            answersInDb.Score27 = updatedAnswers.Answers.Score27;
            answersInDb.Score28 = updatedAnswers.Answers.Score28;
            answersInDb.Score29 = updatedAnswers.Answers.Score29;
            answersInDb.Score30 = updatedAnswers.Answers.Score30;
            answersInDb.Score31 = updatedAnswers.Answers.Score31;
            answersInDb.Score32 = updatedAnswers.Answers.Score32;
            answersInDb.Score33 = updatedAnswers.Answers.Score33;
            answersInDb.Score34 = updatedAnswers.Answers.Score34;
            answersInDb.Score35 = updatedAnswers.Answers.Score35;
            answersInDb.Score36 = updatedAnswers.Answers.Score36;
            answersInDb.Score37 = updatedAnswers.Answers.Score37;
            answersInDb.Score38 = updatedAnswers.Answers.Score38;
            answersInDb.Score39 = updatedAnswers.Answers.Score39;
            answersInDb.Score40 = updatedAnswers.Answers.Score40;
            answersInDb.Score41 = updatedAnswers.Answers.Score41;
            answersInDb.Score42 = updatedAnswers.Answers.Score42;
            answersInDb.Score43 = updatedAnswers.Answers.Score43;
            answersInDb.Score44 = updatedAnswers.Answers.Score44;
            answersInDb.Score45 = updatedAnswers.Answers.Score45;
            answersInDb.Score46 = updatedAnswers.Answers.Score46;
            answersInDb.Score47 = updatedAnswers.Answers.Score47;
            answersInDb.Score48 = updatedAnswers.Answers.Score48;
            answersInDb.Score49 = updatedAnswers.Answers.Score49;
            answersInDb.Score50 = updatedAnswers.Answers.Score50;
            answersInDb.Score51 = updatedAnswers.Answers.Score51;
            answersInDb.Score52 = updatedAnswers.Answers.Score52;
            answersInDb.Score53 = updatedAnswers.Answers.Score53;
            answersInDb.Score54 = updatedAnswers.Answers.Score54;
            answersInDb.Score55 = updatedAnswers.Answers.Score55;
            answersInDb.Score56 = updatedAnswers.Answers.Score56;
            answersInDb.Score57 = updatedAnswers.Answers.Score57;
            answersInDb.Score58 = updatedAnswers.Answers.Score58;
            answersInDb.Score59 = updatedAnswers.Answers.Score59;
            answersInDb.Score60 = updatedAnswers.Answers.Score60;
            answersInDb.Score61 = updatedAnswers.Answers.Score61;
            answersInDb.Score62 = updatedAnswers.Answers.Score62;
            answersInDb.Score63 = updatedAnswers.Answers.Score63;
            answersInDb.Score64 = updatedAnswers.Answers.Score64;
            answersInDb.Score65 = updatedAnswers.Answers.Score65;
            answersInDb.Score66 = updatedAnswers.Answers.Score66;
            answersInDb.Score67 = updatedAnswers.Answers.Score67;
            answersInDb.Score68 = updatedAnswers.Answers.Score68;
            answersInDb.Score69 = updatedAnswers.Answers.Score69;
            answersInDb.Score70 = updatedAnswers.Answers.Score70;
            answersInDb.Score71 = updatedAnswers.Answers.Score71;
            answersInDb.Score72 = updatedAnswers.Answers.Score72;
            answersInDb.Score73 = updatedAnswers.Answers.Score73;
            answersInDb.Score74 = updatedAnswers.Answers.Score74;
            answersInDb.Score75 = updatedAnswers.Answers.Score75;
            answersInDb.Score76 = updatedAnswers.Answers.Score76;
            answersInDb.Score77 = updatedAnswers.Answers.Score77;
            answersInDb.Score78 = updatedAnswers.Answers.Score78;
            answersInDb.Score5in1 = updatedAnswers.Answers.Score5in1;
            answersInDb.TeamHattrick = updatedAnswers.Answers.TeamHattrick;
            answersInDb.TeamLoseManager = updatedAnswers.Answers.TeamLoseManager;
            answersInDb.Top = updatedAnswers.Answers.Top;
            answersInDb.TopScorePlayer = updatedAnswers.Answers.TopScorePlayer;
            answersInDb.TopScoreTeam = updatedAnswers.Answers.TopScoreTeam;
            answersInDb.TwoReds = updatedAnswers.Answers.TwoReds;
            answersInDb.Win20 = updatedAnswers.Answers.Win20;
            answersInDb.Win5inRow = updatedAnswers.Answers.Win5inRow;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult UpdateUserScores()
        {
            var userList = _context.UserPoints.Select(u => u.UFPId).ToList<string>();
            foreach (var user in userList)
            {
                //Retrieve user's points, info on which q's in each update and all the answers
                var userId = _userManager.FindByNameAsync(user).Result.Id;

                var userPoints = _context.UserPoints.Single(u => u.UFPId == user);
                var tempPoints = 0;
                var updateInfo = new UpdateInfo
                {
                    CurrentUpdate = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).CurrentUpdate,
                    ChFinalTable = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).ChFinalTable,
                    ChPlayoffs = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).ChPlayoffs,
                    Christmas = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Christmas,
                    CLFinalResults = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).CLFinalResults,
                    CLQFs = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).CLQFs,
                    CLSFs = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).CLSFs,
                    Con100 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Con100,
                    Con25 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Con25,
                    Con50 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Con50,
                    Con5in1 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Con5in1,
                    Con75 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Con75,
                    FACFinalResults = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).FACFinalResults,
                    FACQFs = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).FACQFs,
                    FACSFs = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).FACSFs,
                    LOFinalTable = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).LOFinalTable,
                    LOPlayoffs = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).LOPlayoffs,
                    Lose5inRow = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Lose5inRow,
                    LTFinalTable = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).LTFinalTable,
                    LTPlayoffs = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).LTPlayoffs,
                    NLFinalTable = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).NLFinalTable,
                    NLPlayoffs = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).NLPlayoffs,
                    PLFinalResults = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).PLFinalResults,
                    Score100 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Score100,
                    Score25 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Score25,
                    Score50 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Score50,
                    Score5in1 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Score5in1,
                    Score75 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Score75,
                    TeamHattrick = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).TeamHattrick,
                    TeamLoseManager = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).TeamLoseManager,
                    TwoReds = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).TwoReds,
                    Win20 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Win20,
                    Win5inRow = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Win5inRow,
                    Match1 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match1,
                    Match2 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match2,
                    Match3 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match3,
                    Match4 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match4,
                    Match5 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match5,
                    Match6 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match6,
                    Match7 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match7,
                    Match8 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match8,
                    Match9 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match9,
                    Match10 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match10,
                    Match11 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match11,
                    Match12 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match12,
                    Match13 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match13,
                    Match14 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match14,
                    Match15 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match15,
                    Match16 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match16,
                    Match17 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match17,
                    Match18 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match18,
                    Match19 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match19,
                    Match20 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match20,
                    Match21 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match21,
                    Match22 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match22,
                    Match23 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match23,
                    Match24 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match24,
                    Match25 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match25,
                    Match26 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match26,
                    Match27 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match27,
                    Match28 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match28,
                    Match29 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match29,
                    Match30 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match30,
                    Match31 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match31,
                    Match32 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match32,
                    Match33 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match33,
                    Match34 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match34,
                    Match35 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match35,
                    Match36 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match36,
                    Match37 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match37,
                    Match38 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match38,
                    Match39 = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019).Match39
                };
                var answers = _context.Answers.SingleOrDefault(a => a.Year == 2019);
                for (var i = 1; i < 39; i++)
                {
                    //Calculate how many points the chosen user gains in this update
                    var updatePoints = 0;

                    if (updateInfo.ChFinalTable == i || updateInfo.ChPlayoffs == i)
                    {
                        var userAnswers = _context.Championship.SingleOrDefault(u => u.User == userId);
                        if (updateInfo.ChFinalTable == i)
                        {
                            if (answers.CPlayoff1 == userAnswers.Playoff1
                                || answers.CPlayoff2 == userAnswers.Playoff1
                                || answers.CPlayoff3 == userAnswers.Playoff1
                                || answers.CPlayoff4 == userAnswers.Playoff1)
                            { updatePoints += 5; }
                            if (answers.CPlayoff1 == userAnswers.Playoff2
                                || answers.CPlayoff2 == userAnswers.Playoff2
                                || answers.CPlayoff3 == userAnswers.Playoff2
                                || answers.CPlayoff4 == userAnswers.Playoff2)
                            { updatePoints += 5; }
                            if (answers.CPlayoff1 == userAnswers.Playoff3
                                || answers.CPlayoff2 == userAnswers.Playoff3
                                || answers.CPlayoff3 == userAnswers.Playoff3
                                || answers.CPlayoff4 == userAnswers.Playoff3)
                            { updatePoints += 5; }
                            if (answers.CPlayoff1 == userAnswers.Playoff4
                                || answers.CPlayoff2 == userAnswers.Playoff4
                                || answers.CPlayoff3 == userAnswers.Playoff4
                                || answers.CPlayoff4 == userAnswers.Playoff4)
                            { updatePoints += 5; }
                            if (answers.CRelegation1 == userAnswers.Relegation1
                                || answers.CRelegation2 == userAnswers.Relegation1
                                || answers.CRelegation3 == userAnswers.Relegation1)
                            {
                                updatePoints += 5;
                            }
                            if (answers.CRelegation1 == userAnswers.Relegation2
                                || answers.CRelegation2 == userAnswers.Relegation2
                                || answers.CRelegation3 == userAnswers.Relegation2)
                            {
                                updatePoints += 5;
                            }
                            if (answers.CRelegation1 == userAnswers.Relegation3
                                || answers.CRelegation2 == userAnswers.Relegation3
                                || answers.CRelegation3 == userAnswers.Relegation3)
                            {
                                updatePoints += 5;
                            }
                            if (userAnswers.Title == userAnswers.RunnerUp)
                            {
                                if (answers.CTitle == userAnswers.Title) { updatePoints += 7; }
                                if (answers.CRunnerUp == userAnswers.RunnerUp) { updatePoints += 7; }
                            }
                            else
                            {
                                if (answers.CTitle == userAnswers.Title) { updatePoints += 10; }
                                if (answers.CRunnerUp == userAnswers.RunnerUp) { updatePoints += 10; }
                                if (answers.CRunnerUp == userAnswers.Title) { updatePoints += 7; }
                                if (answers.CTitle == userAnswers.RunnerUp) { updatePoints += 7; }
                            }
                        }
                        if (updateInfo.ChPlayoffs == i)
                        {
                            if (answers.CPlayoffWinner == userAnswers.PlayoffWinner)
                            {
                                updatePoints += 7;
                            }
                        }
                    }

                    if (updateInfo.Christmas == i)
                    {
                        var userAnswers = _context.ChristmasPredictions.SingleOrDefault(u => u.User == userId);
                        if (answers.Bottom == userAnswers.Bottom) { updatePoints += 5; }
                        if (answers.Top == userAnswers.Top) { updatePoints += 5; }

                        int managersOut = answers.ManagersOut;
                        List<int> userManagersOut = _context.ChristmasPredictions.Select(a => a.ManagersOut).ToList<int>();
                        if (userManagersOut.Contains(managersOut))
                        {
                            if (answers.ManagersOut == userAnswers.ManagersOut) { updatePoints += 5; }
                        }
                        else
                        {
                            var answerDifference = 1;
                            var quitLoop = false;
                            while (quitLoop == false)
                            {
                                if (userManagersOut.Contains((managersOut + answerDifference)) || userManagersOut.Contains(managersOut - answerDifference))
                                {
                                    quitLoop = true;
                                    if (userAnswers.ManagersOut == (managersOut + answerDifference)
                                        || userAnswers.ManagersOut == (managersOut - answerDifference))
                                    {
                                        updatePoints += 2;
                                    }
                                }
                                answerDifference++;
                            }
                        }

                        int pointsClear = answers.PointsClear;
                        List<int> userPointsClear = _context.ChristmasPredictions.Select(a => a.PointsClear).ToList<int>();
                        if (userPointsClear.Contains(pointsClear))
                        {
                            if (answers.PointsClear == userAnswers.PointsClear) { updatePoints += 5; }
                        }
                        else
                        {
                            var answerDifference = 1;
                            var quitLoop = false;
                            while (quitLoop == false)
                            {
                                if (userPointsClear.Contains((pointsClear + answerDifference)) || userPointsClear.Contains(pointsClear - answerDifference))
                                {
                                    quitLoop = true;
                                    if (userAnswers.PointsClear == (pointsClear + answerDifference)
                                        || userAnswers.PointsClear == (pointsClear - answerDifference))
                                    {
                                        updatePoints += 2;
                                    }
                                }
                                answerDifference++;
                            }
                        }

                        int pointsDiff = answers.PointsDifference;
                        List<int> userPointsDiff = _context.ChristmasPredictions.Select(a => a.PointsDifference).ToList<int>();
                        if (userPointsDiff.Contains(pointsDiff))
                        {
                            if (answers.PointsDifference == userAnswers.PointsDifference) { updatePoints += 5; }
                        }
                        else
                        {
                            var answerDifference = 1;
                            var quitLoop = false;
                            while (quitLoop == false)
                            {
                                if (userPointsDiff.Contains((pointsDiff + answerDifference)) || userPointsDiff.Contains(pointsDiff - answerDifference))
                                {
                                    quitLoop = true;
                                    if (userAnswers.PointsDifference == (pointsDiff + answerDifference)
                                        || userAnswers.PointsDifference == (pointsDiff - answerDifference))
                                    {
                                        updatePoints += 2;
                                    }
                                }
                                answerDifference++;
                            }
                        }
                    }

                    if (updateInfo.CLFinalResults == i || updateInfo.CLQFs == i || updateInfo.CLSFs == i)
                    {
                        var userAnswers = _context.ChampionsLge.SingleOrDefault(u => u.User == userId);
                        if (updateInfo.CLFinalResults == i)
                        {
                            if (answers.TopScorePlayer == userAnswers.TopScorePlayer) { updatePoints += 10; }
                            if (answers.TopScoreTeam == userAnswers.TopScoreTeam) { updatePoints += 10; }
                            if (userAnswers.Winner == userAnswers.RunnerUp)
                            {
                                if (answers.CLWinner == userAnswers.Winner) { updatePoints += 7; }
                                if (answers.CLRunnerUp == userAnswers.RunnerUp) { updatePoints += 7; }
                            }
                            else
                            {
                                if (answers.CLWinner == userAnswers.Winner) { updatePoints += 10; }
                                if (answers.CLRunnerUp == userAnswers.RunnerUp) { updatePoints += 10; }
                                if (answers.CLRunnerUp == userAnswers.Winner) { updatePoints += 7; }
                                if (answers.CLWinner == userAnswers.RunnerUp) { updatePoints += 7; }

                            }
                        }
                        if (updateInfo.CLQFs == i)
                        {
                            if (answers.CLQF1 == userAnswers.QF1
                                || answers.CLQF2 == userAnswers.QF1
                                || answers.CLQF3 == userAnswers.QF1
                                || answers.CLQF4 == userAnswers.QF1
                                || answers.CLQF5 == userAnswers.QF1
                                || answers.CLQF6 == userAnswers.QF1
                                || answers.CLQF7 == userAnswers.QF1
                                || answers.CLQF8 == userAnswers.QF1)
                            { updatePoints += 5; }
                            if (answers.CLQF1 == userAnswers.QF2
                                || answers.CLQF2 == userAnswers.QF2
                                || answers.CLQF3 == userAnswers.QF2
                                || answers.CLQF4 == userAnswers.QF2
                                || answers.CLQF5 == userAnswers.QF2
                                || answers.CLQF6 == userAnswers.QF2
                                || answers.CLQF7 == userAnswers.QF2
                                || answers.CLQF8 == userAnswers.QF2)
                            { updatePoints += 5; }
                            if (answers.CLQF1 == userAnswers.QF3
                                || answers.CLQF2 == userAnswers.QF3
                                || answers.CLQF3 == userAnswers.QF3
                                || answers.CLQF4 == userAnswers.QF3
                                || answers.CLQF5 == userAnswers.QF3
                                || answers.CLQF6 == userAnswers.QF3
                                || answers.CLQF7 == userAnswers.QF3
                                || answers.CLQF8 == userAnswers.QF3)
                            { updatePoints += 5; }
                            if (answers.CLQF1 == userAnswers.QF4
                                || answers.CLQF2 == userAnswers.QF4
                                || answers.CLQF3 == userAnswers.QF4
                                || answers.CLQF4 == userAnswers.QF4
                                || answers.CLQF5 == userAnswers.QF4
                                || answers.CLQF6 == userAnswers.QF4
                                || answers.CLQF7 == userAnswers.QF4
                                || answers.CLQF8 == userAnswers.QF4)
                            { updatePoints += 5; }
                            if (answers.CLQF1 == userAnswers.QF5
                                || answers.CLQF2 == userAnswers.QF5
                                || answers.CLQF3 == userAnswers.QF5
                                || answers.CLQF4 == userAnswers.QF5
                                || answers.CLQF5 == userAnswers.QF5
                                || answers.CLQF6 == userAnswers.QF5
                                || answers.CLQF7 == userAnswers.QF5
                                || answers.CLQF8 == userAnswers.QF5)
                            { updatePoints += 5; }
                            if (answers.CLQF1 == userAnswers.QF6
                                || answers.CLQF2 == userAnswers.QF6
                                || answers.CLQF3 == userAnswers.QF6
                                || answers.CLQF4 == userAnswers.QF6
                                || answers.CLQF5 == userAnswers.QF6
                                || answers.CLQF6 == userAnswers.QF6
                                || answers.CLQF7 == userAnswers.QF6
                                || answers.CLQF8 == userAnswers.QF6)
                            { updatePoints += 5; }
                            if (answers.CLQF1 == userAnswers.QF7
                                || answers.CLQF2 == userAnswers.QF7
                                || answers.CLQF3 == userAnswers.QF7
                                || answers.CLQF4 == userAnswers.QF7
                                || answers.CLQF5 == userAnswers.QF7
                                || answers.CLQF6 == userAnswers.QF7
                                || answers.CLQF7 == userAnswers.QF7
                                || answers.CLQF8 == userAnswers.QF7)
                            { updatePoints += 5; }
                            if (answers.CLQF1 == userAnswers.QF8
                                || answers.CLQF2 == userAnswers.QF8
                                || answers.CLQF3 == userAnswers.QF8
                                || answers.CLQF4 == userAnswers.QF8
                                || answers.CLQF5 == userAnswers.QF8
                                || answers.CLQF6 == userAnswers.QF8
                                || answers.CLQF7 == userAnswers.QF8
                                || answers.CLQF8 == userAnswers.QF8)
                            { updatePoints += 5; }
                        }
                        if (updateInfo.CLSFs == i)
                        {
                            if (answers.CLSF1 == userAnswers.SF1
                                                            || answers.CLSF2 == userAnswers.SF1
                                                            || answers.CLSF3 == userAnswers.SF1
                                                            || answers.CLSF4 == userAnswers.SF1)
                            { updatePoints += 7; }
                            if (answers.CLSF1 == userAnswers.SF2
                                                            || answers.CLSF2 == userAnswers.SF2
                                                            || answers.CLSF3 == userAnswers.SF2
                                                            || answers.CLSF4 == userAnswers.SF2)
                            { updatePoints += 7; }
                            if (answers.CLSF1 == userAnswers.SF3
                                                            || answers.CLSF2 == userAnswers.SF3
                                                            || answers.CLSF3 == userAnswers.SF3
                                                            || answers.CLSF4 == userAnswers.SF3)
                            { updatePoints += 7; }
                            if (answers.CLSF1 == userAnswers.SF4
                                                            || answers.CLSF2 == userAnswers.SF4
                                                            || answers.CLSF3 == userAnswers.SF4
                                                            || answers.CLSF4 == userAnswers.SF4)
                            { updatePoints += 7; }
                        }
                    }

                    if (updateInfo.Con100 == i || updateInfo.Con25 == i || updateInfo.Con50 == i
                        || updateInfo.Con5in1 == i || updateInfo.Con75 == i || updateInfo.Lose5inRow == i
                        || updateInfo.Score100 == i || updateInfo.Score25 == i || updateInfo.Score50 == i
                        || updateInfo.Score5in1 == i || updateInfo.Score75 == i || updateInfo.TeamHattrick == i
                        || updateInfo.TeamLoseManager == i || updateInfo.TwoReds == i || updateInfo.Win20 == i
                        || updateInfo.Win5inRow == i)
                    {
                        var userAnswers = _context.Firsts.SingleOrDefault(u => u.User == userId);
                        if (updateInfo.Con100 == i)
                        {
                            if (answers.Con100 == userAnswers.Con100) { updatePoints += 5; }
                        }
                        if (updateInfo.Con25 == i)
                        {
                            if (answers.Con25 == userAnswers.Con25) { updatePoints += 5; }
                        }
                        if (updateInfo.Con50 == i)
                        {
                            if (answers.Con50 == userAnswers.Con50) { updatePoints += 5; }
                        }
                        if (updateInfo.Con5in1 == i)
                        {
                            if (answers.Con5in1 == userAnswers.Con5in1) { updatePoints += 5; }
                        }
                        if (updateInfo.Con75 == i)
                        {
                            if (answers.Con75 == userAnswers.Con75) { updatePoints += 5; }
                        }
                        if (updateInfo.Lose5inRow == i)
                        {
                            if (answers.Lose5inRow == userAnswers.Lose5inRow) { updatePoints += 5; }
                        }
                        if (updateInfo.Score100 == i)
                        {
                            if (answers.FirstScore100 == userAnswers.Score100) { updatePoints += 5; }
                        }
                        if (updateInfo.Score25 == i)
                        {
                            if (answers.FirstScore25 == userAnswers.Score25) { updatePoints += 5; }
                        }
                        if (updateInfo.Score50 == i)
                        {
                            if (answers.FirstScore50 == userAnswers.Score50) { updatePoints += 5; }
                        }
                        if (updateInfo.Score5in1 == i)
                        {
                            if (answers.Score5in1 == userAnswers.Score5in1) { updatePoints += 5; }
                        }
                        if (updateInfo.Score75 == i)
                        {
                            if (answers.FirstScore75 == userAnswers.Score75) { updatePoints += 5; }
                        }
                        if (updateInfo.TeamHattrick == i)
                        {
                            if (answers.TeamHattrick == userAnswers.TeamHattrick) { updatePoints += 5; }
                        }
                        if (updateInfo.TeamLoseManager == i)
                        {
                            if (answers.TeamLoseManager == userAnswers.TeamLoseManager) { updatePoints += 5; }
                        }
                        if (updateInfo.TwoReds == i)
                        {
                            if (answers.TwoReds == userAnswers.TwoReds) { updatePoints += 5; }
                        }
                        if (updateInfo.Win20 == i)
                        {
                            if (answers.Win20 == userAnswers.Win20) { updatePoints += 5; }
                        }
                        if (updateInfo.Win5inRow == i)
                        {
                            if (answers.Win5inRow == userAnswers.Win5inRow) { updatePoints += 5; }
                        }
                    }

                    if (updateInfo.FACFinalResults == i || updateInfo.FACQFs == i || updateInfo.FACSFs == i)
                    {
                        var userAnswers = _context.FACup.SingleOrDefault(u => u.User == userId);
                        if (updateInfo.FACFinalResults == i)
                        {
                            if (userAnswers.Winner == userAnswers.RunnerUp)
                            {
                                if (answers.FACWinner == userAnswers.Winner) { updatePoints += 7; }
                                if (answers.FACRunnerUp == userAnswers.RunnerUp) { updatePoints += 7; }
                            }
                            else
                            {
                                if (answers.FACWinner == userAnswers.Winner) { updatePoints += 10; }
                                if (answers.FACRunnerUp == userAnswers.RunnerUp) { updatePoints += 10; }
                                if (answers.FACRunnerUp == userAnswers.Winner) { updatePoints += 7; }
                                if (answers.FACWinner == userAnswers.RunnerUp) { updatePoints += 7; }
                            }
                        }
                        if (updateInfo.FACQFs == i)
                        {
                            if (answers.FACQF1 == userAnswers.QF1
                                || answers.FACQF2 == userAnswers.QF1
                                || answers.FACQF3 == userAnswers.QF1
                                || answers.FACQF4 == userAnswers.QF1
                                || answers.FACQF5 == userAnswers.QF1
                                || answers.FACQF6 == userAnswers.QF1
                                || answers.FACQF7 == userAnswers.QF1
                                || answers.FACQF8 == userAnswers.QF1)
                            { updatePoints += 5; }
                            if (answers.FACQF1 == userAnswers.QF2
                                || answers.FACQF2 == userAnswers.QF2
                                || answers.FACQF3 == userAnswers.QF2
                                || answers.FACQF4 == userAnswers.QF2
                                || answers.FACQF5 == userAnswers.QF2
                                || answers.FACQF6 == userAnswers.QF2
                                || answers.FACQF7 == userAnswers.QF2
                                || answers.FACQF8 == userAnswers.QF2)
                            { updatePoints += 5; }
                            if (answers.FACQF1 == userAnswers.QF3
                                || answers.FACQF2 == userAnswers.QF3
                                || answers.FACQF3 == userAnswers.QF3
                                || answers.FACQF4 == userAnswers.QF3
                                || answers.FACQF5 == userAnswers.QF3
                                || answers.FACQF6 == userAnswers.QF3
                                || answers.FACQF7 == userAnswers.QF3
                                || answers.FACQF8 == userAnswers.QF3)
                            { updatePoints += 5; }
                            if (answers.FACQF1 == userAnswers.QF4
                                || answers.FACQF2 == userAnswers.QF4
                                || answers.FACQF3 == userAnswers.QF4
                                || answers.FACQF4 == userAnswers.QF4
                                || answers.FACQF5 == userAnswers.QF4
                                || answers.FACQF6 == userAnswers.QF4
                                || answers.FACQF7 == userAnswers.QF4
                                || answers.FACQF8 == userAnswers.QF4)
                            { updatePoints += 5; }
                            if (answers.FACQF1 == userAnswers.QF5
                                || answers.FACQF2 == userAnswers.QF5
                                || answers.FACQF3 == userAnswers.QF5
                                || answers.FACQF4 == userAnswers.QF5
                                || answers.FACQF5 == userAnswers.QF5
                                || answers.FACQF6 == userAnswers.QF5
                                || answers.FACQF7 == userAnswers.QF5
                                || answers.FACQF8 == userAnswers.QF5)
                            { updatePoints += 5; }
                            if (answers.FACQF1 == userAnswers.QF6
                                || answers.FACQF2 == userAnswers.QF6
                                || answers.FACQF3 == userAnswers.QF6
                                || answers.FACQF4 == userAnswers.QF6
                                || answers.FACQF5 == userAnswers.QF6
                                || answers.FACQF6 == userAnswers.QF6
                                || answers.FACQF7 == userAnswers.QF6
                                || answers.FACQF8 == userAnswers.QF6)
                            { updatePoints += 5; }
                            if (answers.FACQF1 == userAnswers.QF7
                                || answers.FACQF2 == userAnswers.QF7
                                || answers.FACQF3 == userAnswers.QF7
                                || answers.FACQF4 == userAnswers.QF7
                                || answers.FACQF5 == userAnswers.QF7
                                || answers.FACQF6 == userAnswers.QF7
                                || answers.FACQF7 == userAnswers.QF7
                                || answers.FACQF8 == userAnswers.QF7)
                            { updatePoints += 5; }
                            if (answers.FACQF1 == userAnswers.QF8
                                || answers.FACQF2 == userAnswers.QF8
                                || answers.FACQF3 == userAnswers.QF8
                                || answers.FACQF4 == userAnswers.QF8
                                || answers.FACQF5 == userAnswers.QF8
                                || answers.FACQF6 == userAnswers.QF8
                                || answers.FACQF7 == userAnswers.QF8
                                || answers.FACQF8 == userAnswers.QF8)
                            { updatePoints += 5; }
                        }
                        if (updateInfo.FACSFs == i)
                        {
                            if (answers.FACSF1 == userAnswers.SF1
                                                            || answers.FACSF2 == userAnswers.SF1
                                                            || answers.FACSF3 == userAnswers.SF1
                                                            || answers.FACSF4 == userAnswers.SF1)
                            { updatePoints += 7; }
                            if (answers.FACSF1 == userAnswers.SF2
                                                            || answers.FACSF2 == userAnswers.SF2
                                                            || answers.FACSF3 == userAnswers.SF2
                                                            || answers.FACSF4 == userAnswers.SF2)
                            { updatePoints += 7; }
                            if (answers.FACSF1 == userAnswers.SF3
                                                            || answers.FACSF2 == userAnswers.SF3
                                                            || answers.FACSF3 == userAnswers.SF3
                                                            || answers.FACSF4 == userAnswers.SF3)
                            { updatePoints += 7; }
                            if (answers.FACSF1 == userAnswers.SF4
                                                            || answers.FACSF2 == userAnswers.SF4
                                                            || answers.FACSF3 == userAnswers.SF4
                                                            || answers.FACSF4 == userAnswers.SF4)
                            { updatePoints += 7; }
                        }
                    }


                    if (updateInfo.LOFinalTable == i || updateInfo.LOPlayoffs == i)
                    {
                        var userAnswers = _context.LeagueOne.SingleOrDefault(u => u.User == userId);
                        if (updateInfo.LOFinalTable == i)
                        {
                            if (answers.LOPlayoff1 == userAnswers.Playoff1
                                || answers.LOPlayoff2 == userAnswers.Playoff1
                                || answers.LOPlayoff3 == userAnswers.Playoff1
                                || answers.LOPlayoff4 == userAnswers.Playoff1)
                            { updatePoints += 5; }
                            if (answers.LOPlayoff1 == userAnswers.Playoff2
                                || answers.LOPlayoff2 == userAnswers.Playoff2
                                || answers.LOPlayoff3 == userAnswers.Playoff2
                                || answers.LOPlayoff4 == userAnswers.Playoff2)
                            { updatePoints += 5; }
                            if (answers.LOPlayoff1 == userAnswers.Playoff3
                                || answers.LOPlayoff2 == userAnswers.Playoff3
                                || answers.LOPlayoff3 == userAnswers.Playoff3
                                || answers.LOPlayoff4 == userAnswers.Playoff3)
                            { updatePoints += 5; }
                            if (answers.LOPlayoff1 == userAnswers.Playoff4
                                || answers.LOPlayoff2 == userAnswers.Playoff4
                                || answers.LOPlayoff3 == userAnswers.Playoff4
                                || answers.LOPlayoff4 == userAnswers.Playoff4)
                            { updatePoints += 5; }
                            if (answers.LORelegation1 == userAnswers.Relegation1
                                || answers.LORelegation2 == userAnswers.Relegation1
                                || answers.LORelegation3 == userAnswers.Relegation1)
                            {
                                updatePoints += 5;
                            }
                            if (answers.LORelegation1 == userAnswers.Relegation2
                                || answers.LORelegation2 == userAnswers.Relegation2
                                || answers.LORelegation3 == userAnswers.Relegation2)
                            {
                                updatePoints += 5;
                            }
                            if (answers.LORelegation1 == userAnswers.Relegation3
                                || answers.LORelegation2 == userAnswers.Relegation3
                                || answers.LORelegation3 == userAnswers.Relegation3)
                            {
                                updatePoints += 5;
                            }
                            if (userAnswers.Title == userAnswers.RunnerUp)
                            {
                                if (answers.LOTitle == userAnswers.Title) { updatePoints += 7; }
                                if (answers.LORunnerUp == userAnswers.RunnerUp) { updatePoints += 7; }
                            }
                            else
                            {
                                if (answers.LOTitle == userAnswers.Title) { updatePoints += 10; }
                                if (answers.LORunnerUp == userAnswers.RunnerUp) { updatePoints += 10; }
                                if (answers.LORunnerUp == userAnswers.Title) { updatePoints += 7; }
                                if (answers.LOTitle == userAnswers.RunnerUp) { updatePoints += 7; }
                            }
                        }
                        if (updateInfo.LOPlayoffs == i)
                        {
                            if (answers.LOPlayoffWinner == userAnswers.PlayoffWinner)
                            {
                                updatePoints += 7;
                            }
                        }
                    }

                    if (updateInfo.LTFinalTable == i || updateInfo.LTPlayoffs == i)
                    {
                        var userAnswers = _context.LeagueTwo.SingleOrDefault(u => u.User == userId);
                        if (updateInfo.LTFinalTable == i)
                        {
                            if (answers.LTPlayoff1 == userAnswers.Playoff1
                                || answers.LTPlayoff2 == userAnswers.Playoff1
                                || answers.LTPlayoff3 == userAnswers.Playoff1
                                || answers.LTPlayoff4 == userAnswers.Playoff1)
                            { updatePoints += 5; }
                            if (answers.LTPlayoff1 == userAnswers.Playoff2
                                || answers.LTPlayoff2 == userAnswers.Playoff2
                                || answers.LTPlayoff3 == userAnswers.Playoff2
                                || answers.LTPlayoff4 == userAnswers.Playoff2)
                            { updatePoints += 5; }
                            if (answers.LTPlayoff1 == userAnswers.Playoff3
                                || answers.LTPlayoff2 == userAnswers.Playoff3
                                || answers.LTPlayoff3 == userAnswers.Playoff3
                                || answers.LTPlayoff4 == userAnswers.Playoff3)
                            { updatePoints += 5; }
                            if (answers.LTPlayoff1 == userAnswers.Playoff4
                                || answers.LTPlayoff2 == userAnswers.Playoff4
                                || answers.LTPlayoff3 == userAnswers.Playoff4
                                || answers.LTPlayoff4 == userAnswers.Playoff4)
                            { updatePoints += 5; }
                            if (answers.LTRelegation1 == userAnswers.Relegation1
                                || answers.LTRelegation2 == userAnswers.Relegation1
                                || answers.LTRelegation3 == userAnswers.Relegation1)
                            {
                                updatePoints += 5;
                            }
                            if (answers.LTRelegation1 == userAnswers.Relegation2
                                || answers.LTRelegation2 == userAnswers.Relegation2
                                || answers.LTRelegation3 == userAnswers.Relegation2)
                            {
                                updatePoints += 5;
                            }
                            if (answers.LTRelegation1 == userAnswers.Relegation3
                                || answers.LTRelegation2 == userAnswers.Relegation3
                                || answers.LTRelegation3 == userAnswers.Relegation3)
                            {
                                updatePoints += 5;
                            }
                            if (userAnswers.Title == userAnswers.RunnerUp)
                            {
                                if (answers.LTTitle == userAnswers.Title) { updatePoints += 7; }
                                if (answers.LTRunnerUp == userAnswers.RunnerUp) { updatePoints += 7; }
                            }
                            else
                            {
                                if (answers.LTTitle == userAnswers.Title) { updatePoints += 10; }
                                if (answers.LTRunnerUp == userAnswers.RunnerUp) { updatePoints += 10; }
                                if (answers.LTRunnerUp == userAnswers.Title) { updatePoints += 7; }
                                if (answers.LTTitle == userAnswers.RunnerUp) { updatePoints += 7; }
                            }
                        }
                        if (updateInfo.LTPlayoffs == i)
                        {
                            if (answers.LTPlayoffWinner == userAnswers.PlayoffWinner)
                            {
                                updatePoints += 7;
                            }
                        }

                    }

                    if (updateInfo.Match1 == i || updateInfo.Match2 == i || updateInfo.Match3 == i ||
                        updateInfo.Match4 == i || updateInfo.Match5 == i || updateInfo.Match6 == i ||
                        updateInfo.Match7 == i || updateInfo.Match8 == i || updateInfo.Match9 == i ||
                        updateInfo.Match10 == i || updateInfo.Match11 == i || updateInfo.Match12 == i ||
                        updateInfo.Match13 == i || updateInfo.Match14 == i || updateInfo.Match15 == i ||
                        updateInfo.Match16 == i || updateInfo.Match17 == i || updateInfo.Match18 == i ||
                        updateInfo.Match19 == i || updateInfo.Match20 == i || updateInfo.Match21 == i ||
                        updateInfo.Match22 == i || updateInfo.Match23 == i || updateInfo.Match24 == i ||
                        updateInfo.Match25 == i || updateInfo.Match26 == i || updateInfo.Match27 == i ||
                        updateInfo.Match28 == i || updateInfo.Match29 == i || updateInfo.Match30 == i ||
                        updateInfo.Match31 == i || updateInfo.Match32 == i || updateInfo.Match33 == i ||
                        updateInfo.Match34 == i || updateInfo.Match35 == i || updateInfo.Match36 == i ||
                        updateInfo.Match37 == i || updateInfo.Match38 == i || updateInfo.Match39 == i)
                    {
                        var userAnswers = _context.Scores.SingleOrDefault(u => u.User == userId);
                        if (updateInfo.Match1 == i)
                        {
                            if (answers.Score1 == userAnswers.Score1
                                && answers.Score2 == userAnswers.Score2)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score1 > answers.Score2
                                    && userAnswers.Score1 > userAnswers.Score2)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score1 < answers.Score2
                                    && userAnswers.Score1 < userAnswers.Score2)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score1 == answers.Score2
                                    && userAnswers.Score1 == userAnswers.Score2)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match2 == i)
                        {
                            if (answers.Score3 == userAnswers.Score3
                                && answers.Score4 == userAnswers.Score4)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score3 > answers.Score4
                                    && userAnswers.Score3 > userAnswers.Score4)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score3 < answers.Score4
                                    && userAnswers.Score3 < userAnswers.Score4)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score3 == answers.Score4
                                    && userAnswers.Score3 == userAnswers.Score4)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match3 == i)
                        {
                            if (answers.Score5 == userAnswers.Score5
                                && answers.Score6 == userAnswers.Score6)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score5 > answers.Score6
                                    && userAnswers.Score5 > userAnswers.Score6)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score5 < answers.Score6
                                    && userAnswers.Score5 < userAnswers.Score6)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score5 == answers.Score6
                                    && userAnswers.Score5 == userAnswers.Score6)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match4 == i)
                        {
                            if (answers.Score7 == userAnswers.Score7
                                && answers.Score8 == userAnswers.Score8)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score7 > answers.Score8
                                    && userAnswers.Score7 > userAnswers.Score8)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score7 < answers.Score8
                                    && userAnswers.Score7 < userAnswers.Score8)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score7 == answers.Score8
                                    && userAnswers.Score7 == userAnswers.Score8)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match5 == i)
                        {
                            if (answers.Score9 == userAnswers.Score9
                                && answers.Score10 == userAnswers.Score10)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score9 > answers.Score10
                                    && userAnswers.Score9 > userAnswers.Score10)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score9 < answers.Score10
                                    && userAnswers.Score9 < userAnswers.Score10)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score9 == answers.Score10
                                    && userAnswers.Score9 == userAnswers.Score10)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match6 == i)
                        {
                            if (answers.Score11 == userAnswers.Score11
                                && answers.Score12 == userAnswers.Score12)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score11 > answers.Score12
                                    && userAnswers.Score11 > userAnswers.Score12)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score11 < answers.Score12
                                    && userAnswers.Score11 < userAnswers.Score12)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score11 == answers.Score12
                                    && userAnswers.Score11 == userAnswers.Score12)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match7 == i)
                        {
                            if (answers.Score13 == userAnswers.Score13
                                && answers.Score14 == userAnswers.Score14)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score13 > answers.Score14
                                    && userAnswers.Score13 > userAnswers.Score14)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score13 < answers.Score14
                                    && userAnswers.Score13 < userAnswers.Score14)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score13 == answers.Score14
                                    && userAnswers.Score13 == userAnswers.Score14)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match8 == i)
                        {
                            if (answers.Score15 == userAnswers.Score15
                                && answers.Score16 == userAnswers.Score16)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score15 > answers.Score16
                                    && userAnswers.Score15 > userAnswers.Score16)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score15 < answers.Score16
                                    && userAnswers.Score15 < userAnswers.Score16)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score15 == answers.Score16
                                    && userAnswers.Score15 == userAnswers.Score16)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match9 == i)
                        {
                            if (answers.Score17 == userAnswers.Score17
                                && answers.Score18 == userAnswers.Score18)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score17 > answers.Score18
                                    && userAnswers.Score17 > userAnswers.Score18)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score17 < answers.Score18
                                    && userAnswers.Score17 < userAnswers.Score18)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score17 == answers.Score18
                                    && userAnswers.Score17 == userAnswers.Score18)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match10 == i)
                        {
                            if (answers.Score19 == userAnswers.Score19
                                && answers.Score20 == userAnswers.Score20)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score19 > answers.Score20
                                    && userAnswers.Score19 > userAnswers.Score20)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score19 < answers.Score20
                                    && userAnswers.Score19 < userAnswers.Score20)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score19 == answers.Score20
                                    && userAnswers.Score19 == userAnswers.Score20)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match11 == i)
                        {
                            if (answers.Score21 == userAnswers.Score21
                                && answers.Score22 == userAnswers.Score22)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score21 > answers.Score22
                                    && userAnswers.Score21 > userAnswers.Score22)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score21 < answers.Score22
                                    && userAnswers.Score21 < userAnswers.Score22)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score21 == answers.Score22
                                    && userAnswers.Score21 == userAnswers.Score22)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match12 == i)
                        {
                            if (answers.Score23 == userAnswers.Score23
                                && answers.Score24 == userAnswers.Score24)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score23 > answers.Score24
                                    && userAnswers.Score23 > userAnswers.Score24)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score23 < answers.Score24
                                    && userAnswers.Score23 < userAnswers.Score24)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score23 == answers.Score24
                                    && userAnswers.Score23 == userAnswers.Score24)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match13 == i)
                        {
                            if (answers.Score25 == userAnswers.Score25
                                && answers.Score26 == userAnswers.Score26)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score25 > answers.Score26
                                    && userAnswers.Score25 > userAnswers.Score26)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score25 < answers.Score26
                                    && userAnswers.Score25 < userAnswers.Score26)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score25 == answers.Score26
                                    && userAnswers.Score25 == userAnswers.Score26)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match14 == i)
                        {
                            if (answers.Score27 == userAnswers.Score27
                                && answers.Score28 == userAnswers.Score28)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score27 > answers.Score28
                                    && userAnswers.Score27 > userAnswers.Score28)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score27 < answers.Score28
                                    && userAnswers.Score27 < userAnswers.Score28)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score27 == answers.Score28
                                    && userAnswers.Score27 == userAnswers.Score28)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match15 == i)
                        {
                            if (answers.Score29 == userAnswers.Score29
                                && answers.Score30 == userAnswers.Score30)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score29 > answers.Score30
                                    && userAnswers.Score29 > userAnswers.Score30)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score29 < answers.Score30
                                    && userAnswers.Score29 < userAnswers.Score30)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score29 == answers.Score30
                                    && userAnswers.Score29 == userAnswers.Score30)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match16 == i)
                        {
                            if (answers.Score31 == userAnswers.Score31
                                && answers.Score32 == userAnswers.Score32)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score31 > answers.Score32
                                    && userAnswers.Score31 > userAnswers.Score32)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score31 < answers.Score32
                                    && userAnswers.Score31 < userAnswers.Score32)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score31 == answers.Score32
                                    && userAnswers.Score31 == userAnswers.Score32)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match17 == i)
                        {
                            if (answers.Score33 == userAnswers.Score33
                                && answers.Score34 == userAnswers.Score34)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score33 > answers.Score34
                                    && userAnswers.Score33 > userAnswers.Score34)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score33 < answers.Score34
                                    && userAnswers.Score33 < userAnswers.Score34)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score33 == answers.Score34
                                    && userAnswers.Score33 == userAnswers.Score34)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match18 == i)
                        {
                            if (answers.Score35 == userAnswers.Score35
                                && answers.Score36 == userAnswers.Score36)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score35 > answers.Score36
                                    && userAnswers.Score35 > userAnswers.Score36)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score35 < answers.Score36
                                    && userAnswers.Score35 < userAnswers.Score36)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score35 == answers.Score36
                                    && userAnswers.Score35 == userAnswers.Score36)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match19 == i)
                        {
                            if (answers.Score37 == userAnswers.Score37
                                && answers.Score38 == userAnswers.Score38)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score37 > answers.Score38
                                    && userAnswers.Score37 > userAnswers.Score38)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score37 < answers.Score38
                                    && userAnswers.Score37 < userAnswers.Score38)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score37 == answers.Score38
                                    && userAnswers.Score37 == userAnswers.Score38)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match20 == i)
                        {
                            if (answers.Score39 == userAnswers.Score39
                                && answers.Score40 == userAnswers.Score40)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score39 > answers.Score40
                                    && userAnswers.Score39 > userAnswers.Score40)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score39 < answers.Score40
                                    && userAnswers.Score39 < userAnswers.Score40)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score39 == answers.Score40
                                    && userAnswers.Score39 == userAnswers.Score40)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match21 == i)
                        {
                            if (answers.Score41 == userAnswers.Score41
                                && answers.Score42 == userAnswers.Score42)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score41 > answers.Score42
                                    && userAnswers.Score41 > userAnswers.Score42)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score41 < answers.Score42
                                    && userAnswers.Score41 < userAnswers.Score42)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score41 == answers.Score42
                                    && userAnswers.Score41 == userAnswers.Score42)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match22 == i)
                        {
                            if (answers.Score43 == userAnswers.Score43
                                && answers.Score44 == userAnswers.Score44)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score43 > answers.Score44
                                    && userAnswers.Score43 > userAnswers.Score44)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score43 < answers.Score44
                                    && userAnswers.Score43 < userAnswers.Score44)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score43 == answers.Score44
                                    && userAnswers.Score43 == userAnswers.Score44)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match23 == i)
                        {
                            if (answers.Score45 == userAnswers.Score45
                                && answers.Score46 == userAnswers.Score46)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score45 > answers.Score46
                                    && userAnswers.Score45 > userAnswers.Score46)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score45 < answers.Score46
                                    && userAnswers.Score45 < userAnswers.Score46)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score45 == answers.Score46
                                    && userAnswers.Score45 == userAnswers.Score46)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match24 == i)
                        {
                            if (answers.Score47 == userAnswers.Score47
                                && answers.Score48 == userAnswers.Score48)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score47 > answers.Score48
                                    && userAnswers.Score47 > userAnswers.Score48)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score47 < answers.Score48
                                    && userAnswers.Score47 < userAnswers.Score48)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score47 == answers.Score48
                                    && userAnswers.Score47 == userAnswers.Score48)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match25 == i)
                        {
                            if (answers.Score49 == userAnswers.Score49
                                && answers.Score50 == userAnswers.Score50)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score49 > answers.Score50
                                    && userAnswers.Score49 > userAnswers.Score50)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score49 < answers.Score50
                                    && userAnswers.Score49 < userAnswers.Score50)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score49 == answers.Score50
                                    && userAnswers.Score49 == userAnswers.Score50)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match26 == i)
                        {
                            if (answers.Score51 == userAnswers.Score51
                                && answers.Score52 == userAnswers.Score52)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score51 > answers.Score52
                                    && userAnswers.Score51 > userAnswers.Score52)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score51 < answers.Score52
                                    && userAnswers.Score51 < userAnswers.Score52)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score51 == answers.Score52
                                    && userAnswers.Score51 == userAnswers.Score52)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match27 == i)
                        {
                            if (answers.Score53 == userAnswers.Score53
                                && answers.Score54 == userAnswers.Score54)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score53 > answers.Score54
                                    && userAnswers.Score53 > userAnswers.Score54)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score53 < answers.Score54
                                    && userAnswers.Score53 < userAnswers.Score54)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score53 == answers.Score54
                                    && userAnswers.Score53 == userAnswers.Score54)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match28 == i)
                        {
                            if (answers.Score55 == userAnswers.Score55
                                && answers.Score56 == userAnswers.Score56)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score55 > answers.Score56
                                    && userAnswers.Score55 > userAnswers.Score56)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score55 < answers.Score56
                                    && userAnswers.Score55 < userAnswers.Score56)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score55 == answers.Score56
                                    && userAnswers.Score55 == userAnswers.Score56)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match29 == i)
                        {
                            if (answers.Score57 == userAnswers.Score57
                                && answers.Score58 == userAnswers.Score58)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score57 > answers.Score58
                                    && userAnswers.Score57 > userAnswers.Score58)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score57 < answers.Score58
                                    && userAnswers.Score57 < userAnswers.Score58)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score57 == answers.Score58
                                    && userAnswers.Score57 == userAnswers.Score58)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match30 == i)
                        {
                            if (answers.Score59 == userAnswers.Score59
                                && answers.Score60 == userAnswers.Score60)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score59 > answers.Score60
                                    && userAnswers.Score59 > userAnswers.Score60)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score59 < answers.Score60
                                    && userAnswers.Score59 < userAnswers.Score60)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score59 == answers.Score60
                                    && userAnswers.Score59 == userAnswers.Score60)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match31 == i)
                        {
                            if (answers.Score61 == userAnswers.Score61
                                && answers.Score62 == userAnswers.Score62)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score61 > answers.Score62
                                    && userAnswers.Score61 > userAnswers.Score62)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score61 < answers.Score62
                                    && userAnswers.Score61 < userAnswers.Score62)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score61 == answers.Score62
                                    && userAnswers.Score61 == userAnswers.Score62)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match32 == i)
                        {
                            if (answers.Score63 == userAnswers.Score63
                                && answers.Score64 == userAnswers.Score64)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score63 > answers.Score64
                                    && userAnswers.Score63 > userAnswers.Score64)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score63 < answers.Score64
                                    && userAnswers.Score63 < userAnswers.Score64)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score63 == answers.Score64
                                    && userAnswers.Score63 == userAnswers.Score64)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match33 == i)
                        {
                            if (answers.Score65 == userAnswers.Score65
                                && answers.Score66 == userAnswers.Score66)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score65 > answers.Score66
                                    && userAnswers.Score65 > userAnswers.Score66)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score65 < answers.Score66
                                    && userAnswers.Score65 < userAnswers.Score66)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score65 == answers.Score66
                                    && userAnswers.Score65 == userAnswers.Score66)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match34 == i)
                        {
                            if (answers.Score67 == userAnswers.Score67
                                && answers.Score68 == userAnswers.Score68)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score67 > answers.Score68
                                    && userAnswers.Score67 > userAnswers.Score68)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score67 < answers.Score68
                                    && userAnswers.Score67 < userAnswers.Score68)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score67 == answers.Score68
                                    && userAnswers.Score67 == userAnswers.Score68)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match35 == i)
                        {
                            if (answers.Score69 == userAnswers.Score69
                                && answers.Score70 == userAnswers.Score70)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score69 > answers.Score70
                                    && userAnswers.Score69 > userAnswers.Score70)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score69 < answers.Score70
                                    && userAnswers.Score69 < userAnswers.Score70)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score69 == answers.Score70
                                    && userAnswers.Score69 == userAnswers.Score70)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match36 == i)
                        {
                            if (answers.Score71 == userAnswers.Score71
                                && answers.Score72 == userAnswers.Score72)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score71 > answers.Score72
                                    && userAnswers.Score71 > userAnswers.Score72)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score71 < answers.Score72
                                    && userAnswers.Score71 < userAnswers.Score72)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score71 == answers.Score72
                                    && userAnswers.Score71 == userAnswers.Score72)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match37 == i)
                        {
                            if (answers.Score73 == userAnswers.Score73
                                && answers.Score74 == userAnswers.Score74)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score73 > answers.Score74
                                    && userAnswers.Score73 > userAnswers.Score74)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score73 < answers.Score74
                                    && userAnswers.Score73 < userAnswers.Score74)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score73 == answers.Score74
                                    && userAnswers.Score73 == userAnswers.Score74)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match38 == i)
                        {
                            if (answers.Score75 == userAnswers.Score75
                                && answers.Score76 == userAnswers.Score76)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score75 > answers.Score76
                                    && userAnswers.Score75 > userAnswers.Score76)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score75 < answers.Score76
                                    && userAnswers.Score75 < userAnswers.Score76)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score75 == answers.Score76
                                    && userAnswers.Score75 == userAnswers.Score76)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                        if (updateInfo.Match39 == i)
                        {
                            if (answers.Score77 == userAnswers.Score77
                                && answers.Score78 == userAnswers.Score78)
                            {
                                updatePoints += 5;
                            }
                            else
                            {
                                if (answers.Score77 > answers.Score78
                                    && userAnswers.Score77 > userAnswers.Score78)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score77 < answers.Score78
                                    && userAnswers.Score77 < userAnswers.Score78)
                                {
                                    updatePoints += 2;
                                }
                                if (answers.Score77 == answers.Score78
                                    && userAnswers.Score77 == userAnswers.Score78)
                                {
                                    updatePoints += 2;
                                }
                            }
                        }
                    }

                    if (updateInfo.NLFinalTable == i || updateInfo.NLPlayoffs == i)
                    {
                        var userAnswers = _context.NationalLeague.SingleOrDefault(u => u.User == userId);
                        if (updateInfo.NLFinalTable == i)
                        {
                            if (answers.NLTitle == userAnswers.Title) { updatePoints += 10; }
                        }
                        if (updateInfo.NLPlayoffs == i)
                        {
                            if (answers.NLPlayoffWinner == userAnswers.PlayoffWinner) { updatePoints += 7; }
                        }
                    }

                    if (updateInfo.PLFinalResults == i)
                    {
                        var userAnswers = _context.Tables.SingleOrDefault(u => u.User == userId);
                        if (answers.Place1 == userAnswers.Place1) { updatePoints += 10; }
                        if (answers.Place2 == userAnswers.Place2) { updatePoints += 5; }
                        if (answers.Place3 == userAnswers.Place3) { updatePoints += 5; }
                        if (answers.Place4 == userAnswers.Place4) { updatePoints += 5; }
                        if (answers.Place5 == userAnswers.Place5) { updatePoints += 5; }
                        if (answers.Place6 == userAnswers.Place6) { updatePoints += 5; }
                        if (answers.Place7 == userAnswers.Place7) { updatePoints += 5; }
                        if (answers.Place8 == userAnswers.Place8) { updatePoints += 5; }
                        if (answers.Place9 == userAnswers.Place9) { updatePoints += 5; }
                        if (answers.Place10 == userAnswers.Place10) { updatePoints += 5; }
                        if (answers.Place11 == userAnswers.Place11) { updatePoints += 5; }
                        if (answers.Place12 == userAnswers.Place12) { updatePoints += 5; }
                        if (answers.Place13 == userAnswers.Place13) { updatePoints += 5; }
                        if (answers.Place14 == userAnswers.Place14) { updatePoints += 5; }
                        if (answers.Place15 == userAnswers.Place15) { updatePoints += 5; }
                        if (answers.Place16 == userAnswers.Place16) { updatePoints += 5; }
                        if (answers.Place17 == userAnswers.Place17) { updatePoints += 5; }
                        if (answers.Place18 == userAnswers.Place18) { updatePoints += 5; }
                        if (answers.Place19 == userAnswers.Place19) { updatePoints += 5; }
                        if (answers.Place20 == userAnswers.Place20) { updatePoints += 5; }
                        if (answers.Place2 == userAnswers.Place1) { updatePoints += 2; }
                        if (answers.Place3 == userAnswers.Place2) { updatePoints += 2; }
                        if (answers.Place4 == userAnswers.Place3) { updatePoints += 2; }
                        if (answers.Place5 == userAnswers.Place4) { updatePoints += 2; }
                        if (answers.Place6 == userAnswers.Place5) { updatePoints += 2; }
                        if (answers.Place7 == userAnswers.Place6) { updatePoints += 2; }
                        if (answers.Place8 == userAnswers.Place7) { updatePoints += 2; }
                        if (answers.Place9 == userAnswers.Place8) { updatePoints += 2; }
                        if (answers.Place10 == userAnswers.Place9) { updatePoints += 2; }
                        if (answers.Place11 == userAnswers.Place10) { updatePoints += 2; }
                        if (answers.Place12 == userAnswers.Place11) { updatePoints += 2; }
                        if (answers.Place13 == userAnswers.Place12) { updatePoints += 2; }
                        if (answers.Place14 == userAnswers.Place13) { updatePoints += 2; }
                        if (answers.Place15 == userAnswers.Place14) { updatePoints += 2; }
                        if (answers.Place16 == userAnswers.Place15) { updatePoints += 2; }
                        if (answers.Place17 == userAnswers.Place16) { updatePoints += 2; }
                        if (answers.Place18 == userAnswers.Place17) { updatePoints += 2; }
                        if (answers.Place19 == userAnswers.Place18) { updatePoints += 2; }
                        if (answers.Place20 == userAnswers.Place19) { updatePoints += 2; }
                        if (answers.Place1 == userAnswers.Place2) { updatePoints += 2; }
                        if (answers.Place2 == userAnswers.Place3) { updatePoints += 2; }
                        if (answers.Place3 == userAnswers.Place4) { updatePoints += 2; }
                        if (answers.Place4 == userAnswers.Place5) { updatePoints += 2; }
                        if (answers.Place5 == userAnswers.Place6) { updatePoints += 2; }
                        if (answers.Place6 == userAnswers.Place7) { updatePoints += 2; }
                        if (answers.Place7 == userAnswers.Place8) { updatePoints += 2; }
                        if (answers.Place8 == userAnswers.Place9) { updatePoints += 2; }
                        if (answers.Place9 == userAnswers.Place10) { updatePoints += 2; }
                        if (answers.Place10 == userAnswers.Place11) { updatePoints += 2; }
                        if (answers.Place11 == userAnswers.Place12) { updatePoints += 2; }
                        if (answers.Place12 == userAnswers.Place13) { updatePoints += 2; }
                        if (answers.Place13 == userAnswers.Place14) { updatePoints += 2; }
                        if (answers.Place14 == userAnswers.Place15) { updatePoints += 2; }
                        if (answers.Place15 == userAnswers.Place16) { updatePoints += 2; }
                        if (answers.Place16 == userAnswers.Place17) { updatePoints += 2; }
                        if (answers.Place17 == userAnswers.Place18) { updatePoints += 2; }
                        if (answers.Place18 == userAnswers.Place19) { updatePoints += 2; }
                        if (answers.Place19 == userAnswers.Place20) { updatePoints += 2; }
                    }

                    // Add the update points to the previous points the user had (stored in tempPoints) and make this new value tempPoints
                    var updateStringB = new StringBuilder("Update");
                    if (i < 10)
                    {
                        updateStringB.Append("0");
                    }
                    updateStringB.Append(i);
                    var updateString = updateStringB.ToString();
                    userPoints[updateString] = tempPoints + updatePoints;
                    tempPoints = tempPoints + updatePoints;

                    // If this is the current update, then copy across the values to current update column
                    if (updateInfo.CurrentUpdate == i)
                    {
                        userPoints.CurrentScore = tempPoints;
                    }
                }
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult InsertUsersToPointsTable()
        {
            var userPoints = _context.UserPoints.Select(u => u.UFPId);
            var usersList = _userManager.Users;
            foreach (var singleuser in usersList)
            {
                var userName = singleuser.UserName;
                if (!userPoints.Contains(userName))
                {
                    var newUserPoints = new UserPoints
                    {
                        UFPId = userName
                    };
                    _context.UserPoints.Add(newUserPoints);
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult RemoveUserFromPointsTable(string userName)
        {
            UserPoints userInTable = _context.UserPoints.Single(u => u.UFPId == userName);
            _context.UserPoints.Remove(userInTable);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}