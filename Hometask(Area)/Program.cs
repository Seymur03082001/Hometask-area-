using Hometask_Area_.DAL;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hometask_Area_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL"));
            });
            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();
            app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Doshboard}/{action=Indxxxxxex}/{id?}");
            app.MapControllerRoute(name: "admin", pattern: "admin", defaults: new { Controller = "Doshboard", Action = "Index" });
            app.MapControllerRoute(name: "default", pattern: "{controller=home}/{action=team}");

            app.Run();
        }
    }
}