using LMSMASTERDETAILPATTERNFOREXAM.Models;
using Microsoft.EntityFrameworkCore;

namespace LMSMASTERDETAILPATTERNFOREXAM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<LibraryDB>(o =>

            o.UseSqlServer("server= DESKTOP-0HO4M5Q\\SQLEXPRESS; database = LMSOnASPNETCORE&EFCORE2INEXAM ; trusted_connection =true; trust server certificate =true;")

            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
