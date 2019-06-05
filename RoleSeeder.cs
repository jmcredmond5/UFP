using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UFPCore
{
    public class RoleSeeder : IRoleSeeder
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleSeeder(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task RoleSeed()
        {
            if (_roleManager.Roles.Count() < 1)
            {
                await _roleManager.CreateAsync(new IdentityRole() { Name = "User" });
                await _roleManager.CreateAsync(new IdentityRole() { Name = "PaidUser" });
                await _roleManager.CreateAsync(new IdentityRole() { Name = "Admin" });
            }
        }
    }
}
