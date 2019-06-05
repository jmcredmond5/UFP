using Microsoft.AspNetCore.Identity;

namespace UFPCore.Models
{
    public class roleSeeder
    {
        private RoleManager<IdentityRole> _roleManager;
        
        public roleSeeder(RoleManager<IdentityRole> roleManager){
            _roleManager = roleManager;
        }
        
        public void addRole(string roleName){
            IdentityRole role = new IdentityRole();
            role.Name = roleName;
            IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
        }
    }
}