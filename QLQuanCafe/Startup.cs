using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Application.Services;
using Application.Interfaces;
using Domain.Repositories;

namespace QLQuanCafe
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<QLQuanCafeContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<QLQuanCafeContext>();
            services.AddControllersWithViews();

            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));

            services.AddScoped<IIngredientRepository, IngredientRepository>();
            services.AddScoped<IIngredientService, IngredientService>();

            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();

            services.AddScoped<IBillRepository, BillRepository>();
            services.AddScoped<IBillService, BillService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{controller=Ingredient}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{controller=Customer}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{controller=Bill}/{action=Index}/{id?}"
                );
                endpoints.MapRazorPages();
            });
        }
    }
}
