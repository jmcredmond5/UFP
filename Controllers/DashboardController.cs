using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using UFPCore.Data;
using UFPCore.Models;
using UFPCore.Prediction_constants;

namespace UFPCore.Controllers
{
    [Authorize(Roles ="PaidUser,Admin")]
    public class DashboardController : Controller
    {
        private ApplicationDbContext _context;
        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Dashboard
        public ActionResult Index()
        {
            var viewModel = new DashboardViewModel();
            viewModel.UpdateInfo = _context.UpdateInfos.SingleOrDefault(u => u.Year == 2019);
            viewModel.Answers = _context.Answers.SingleOrDefault(a => a.Year == 2019);
            return View(viewModel);
        }

    }
}