using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
// using UFPCore.Areas.Identity.Data;

[assembly: HostingStartup(typeof(UFPCore.Areas.Identity.IdentityHostingStartup))]
namespace UFPCore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                // services.AddDbContext<UFPCoreIdentityDbContext>(options =>
                //     options.UseSqlServer(
                //         context.Configuration.GetConnectionString("UFPCoreIdentityDbContextConnection")));

                // services.AddDefaultIdentity<IdentityUser>()
                //     .AddEntityFrameworkStores<UFPCoreIdentityDbContext>();
            });
        }
    }
}