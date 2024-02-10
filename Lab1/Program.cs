using Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using Employee_App.Models;
using Employee_App.Models.Address;
using Employee_App.Models.Employer;
using Employee_App.Models.Employee;

namespace Employee_App
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
                        var connectionString = builder.Configuration.GetConnectionString("AppDbContextConnection") ?? throw new InvalidOperationException("Connection string 'AppDbContextConnection' not found.");

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<Data.AppDbContext>();
           // builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
           builder.Services.AddTransient<IEmployerService, EmployerService>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddTransient<IAddressService,AddressService>();
            builder.Services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();


            builder.Services.AddMemoryCache();
            builder.Services.AddSession();


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

            app.UseAuthentication();;
            app.UseAuthorization();
            app.UseSession();
            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}