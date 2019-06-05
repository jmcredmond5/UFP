using Microsoft.AspNetCore.Identity;

namespace UFPCore.Areas.Identity.Pages.Account
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string InvitedBy {get; set;}
    }
}