using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using UFPCore.Models.Payment;
using Stripe;
using Microsoft.AspNetCore.Identity;
using UFPCore.Models;
using UFPCore.Models.Predictions;
using UFPCore.Data;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using UFPCore.Configuration;

namespace UFPCore.Controllers
{
    //[RequireHttps]
    
    public class PaymentController : Controller
    {
        public ApplicationDbContext _context;
        private IOptions<StripeConfigurationKeys> _stripeOptions;
        public IConfiguration Configuration { get; set; }

        public PaymentController(ApplicationDbContext context, IConfiguration config,
            IOptions<StripeConfigurationKeys> stripeOptions)
        {
            _stripeOptions = stripeOptions;
            _context = context;
            Configuration = config;
        }

        // GET: Payment
        [Authorize(Roles = "User,Admin")]
        public ActionResult Index()
        {
            string stripePublicKey = _stripeOptions.Value.PublicKey;
            
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);
            
            if (completions == null)
            {
                completions = new Completions();
                completions.User = userID;
                completions.ScoresCom = false;
                completions.FirstsCom = false;
                completions.FinalCom = false;
                completions.EoSCom = false;
            }

            var viewModel = new IndexViewModel();
            viewModel.Completions = completions;
            viewModel.StripePublicKey = stripePublicKey;
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        [Authorize(Roles = "User,Admin")]
        public ActionResult Charge(ChargeViewModel chargeViewModel)
        {
            string stripePublicKey = _stripeOptions.Value.PublicKey;

            var model = new IndexViewModel() { StripePublicKey = stripePublicKey };
            // var userName = User.Identity.GetUserName();
            var userID =  User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var completions = _context.Completions.SingleOrDefault(c => c.User == userID);

            if (completions == null)
            {
                completions = new Completions();
                completions.User = userID;
                completions.ScoresCom = false;
                completions.FirstsCom = false;
                completions.FinalCom = false;
                completions.EoSCom = false;
            }
            model.Completions = completions;


            var token = chargeViewModel.StripeToken;
            var chargeOptions = new ChargeCreateOptions()
            {
                Amount = 1000,
                Currency = "gbp",
                SourceId = token,
                Description = "FergalTest",
                ReceiptEmail = chargeViewModel.StripeEmail
            };

            var chargeService = new ChargeService();
            try
            {
                Charge charge = chargeService.Create(chargeOptions);
            }
            catch (StripeException stripeException)
            {
                Debug.WriteLine(stripeException.Message);
                ModelState.AddModelError(string.Empty, stripeException.Message);
                return View("Index", model);
            }
            
            return (RedirectToAction("Confirmation"));
        }

        public ActionResult Confirmation(bool? isPaidUser)
        {
            if(isPaidUser == null)
            {
                return RedirectToAction("ToPaidUserAsync", "Account", new { nextAction = "Confirmation", nextController = "Payment" });
            }
            return View();
        }
    }
}