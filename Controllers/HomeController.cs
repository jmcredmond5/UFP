using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using UFPCore.Models;
using System.Security.Claims;
using UFPCore.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using UFPCore.Configuration;
using UFPCore.Services.EmailService;
using UFPCore.Services;

namespace UFPCore.Controllers
{
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; set; }
        private ApplicationDbContext _context;
        private RoleManager<IdentityRole> _roleManager;
        private readonly IOptions<SmtpConfiguration> _emailConfig;
        private readonly IEmailSenderService _emailSenderService;
        public HomeController(IConfiguration config, 
            ApplicationDbContext context, 
            RoleManager<IdentityRole> roleManager,
            IOptions<SmtpConfiguration> emailConfig,
            IEmailSenderService emailSenderService)
        {
            _roleManager = roleManager;
            Configuration = config;
            _context = context;
            _emailConfig = emailConfig;
            _emailSenderService = emailSenderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            //var roleSeeder = new RoleSeeder(_roleManager);
            //await roleSeeder.RoleSeed();
            return View();
        }
        public ActionResult LeagueTable()
        {

            LeagueTableViewModel viewModel = new LeagueTableViewModel
            {
                TableData = new List<UserWithScore>()
            };
            var currentUpdate = _context.UpdateInfos.FirstOrDefault(u => u.Year == 2019).CurrentUpdate;
            var previousUpdateString = "";
            if(currentUpdate < 11)
            {
                previousUpdateString = "Update0" + (currentUpdate-1);
            } else
            {
                previousUpdateString = "Update" + (currentUpdate-1);
            }
            var usersList = _context.UserPoints.OrderByDescending(u => u.CurrentScore);
            if(currentUpdate > 1)
            {
                foreach (var user in usersList)
                {
                    viewModel.TableData.Add(new UserWithScore
                    {
                        UFPId = user.UFPId,
                        CurrentScore = user.CurrentScore,
                        LastUpdatePoints = (float)(user.GetType().GetProperty(previousUpdateString).GetValue(user))
                    });

                }
            }
            else
            {
                foreach (var user in usersList)
                {
                    viewModel.TableData.Add(new UserWithScore
                    {
                        UFPId = user.UFPId,
                        CurrentScore = user.CurrentScore,
                        LastUpdatePoints = 0
                    });
                }
            }
            return View(viewModel);
        }

        public ActionResult TandC()
        {
            return View();
        }
        public ActionResult GDPR()
        {
            return View();
        }
        public ActionResult SiteSecurity()
        {
            return View();
        }
         
        public IActionResult Contact()
        {
            
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(ContactForm contactForm)
        {
            if (ModelState.IsValid)
            {
                if (!await GoogleRecaptchaHelper.IsReCaptchaPassedAsync(Request.Form["g-recaptcha-response"],Configuration["GoogleReCaptcha:secret"]))
                {
                    return View();
                }

                string emailFrom = $"{contactForm.Email}";
                string emailSubject = "UFP Contact Form";
                string emailBody = $"{contactForm.Message}";
                string emailTo = $"{_emailConfig.Value.DefaultEmailTo}";
                var response = await _emailSenderService.SendEmailAsync(emailTo,emailFrom,emailSubject,emailBody, emailBody);

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Help()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
