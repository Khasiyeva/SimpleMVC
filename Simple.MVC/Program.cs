using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Simple.DAL.DAL;

namespace Simple.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
        });
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
                 name: "Areas",
                 pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );

            app.MapControllerRoute(
                 name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );


            app.Run();
        }
    }
}