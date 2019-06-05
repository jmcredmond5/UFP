using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UFPCore.Areas.Identity.Pages.Account;
using UFPCore.Data;

namespace UFPCore.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private ApplicationDbContext _context;
        private SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, 
                                RoleManager<IdentityRole> roleManager, 
                                ApplicationDbContext context,
                                SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
            _signInManager = signInManager;
        }

        //
        //Change user to Admin
        public async System.Threading.Tasks.Task<ActionResult> ToAdminAsync(string nextAction, string nextController)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            //UserAssignRole
            if (User.IsInRole("PaidUser"))
            {                
                await _userManager.RemoveFromRoleAsync(user, "PaidUser");
            }
            if (User.IsInRole("User"))
            {
                await _userManager.RemoveFromRoleAsync(user, "User");
            }
            await _userManager.AddToRoleAsync(user, "Admin");
            await _signInManager.SignInAsync(user, false);
            return RedirectToAction(nextAction, nextController, new { isAdmin = true });
        }

        //
        // Change user to PaidUser
        public async System.Threading.Tasks.Task<ActionResult> ToPaidUserAsync(string nextAction, string nextController)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            //UserAssignRole
            if (User.IsInRole("Admin"))
            {                
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            }
            if (User.IsInRole("User"))
            {
                await _userManager.RemoveFromRoleAsync(user, "User");
            }
            await _userManager.AddToRoleAsync(user, "PaidUser");
            await _signInManager.SignInAsync(user, false);
            return RedirectToAction(nextAction, nextController, new { isPaidUser = true });
        }

        //
        //Change user to User
        public async System.Threading.Tasks.Task<ActionResult> ToUserAsync(string nextAction, string nextController)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            //UserAssignRole
            if (User.IsInRole("PaidUser"))
            {                
                await _userManager.RemoveFromRoleAsync(user, "PaidUser");
            }
            if (User.IsInRole("Admin"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Admin");
            }
            await _userManager.AddToRoleAsync(user, "User");
            await _signInManager.SignInAsync(user, false);
            return RedirectToAction(nextAction, nextController, new { isAdmin = true });
        }

        public IActionResult ConfirmEmail()
        {
            return View();
        }
        public IActionResult PleaseConfirm(){
            return View();
        }
    }
}