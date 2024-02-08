using BlazorWeb.Data;
using BlazorWeb.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace BlazorWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<dbapiContext>(
               options => options.UseSqlServer(
                   "Server=DESKTOP-CJMJ3I2;Database=dbapi;Trusted_Connection=True;MultipleActiveResultSets=true"));

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddSingleton<UserService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}