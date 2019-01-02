using System;
using BiavlerWeb.Areas.Identity.Data;
using BiavlerWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BiavlerWeb.Areas.Identity.IdentityHostingStartup))]
namespace BiavlerWeb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<BiavlerWebContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("BiavlerWebContextConnection")));

                //services.AddDefaultIdentity<BiavlerWebUser>()
                //    .AddEntityFrameworkStores<BiavlerWebContext>();
            //});
        }
    }
}