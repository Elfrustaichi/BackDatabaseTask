using EternaWithDatabase.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EternaWithDatabase
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer(@"Server=Elfrustaichi\SQLEXPRESS;Database=EternaWithDatabase;Trusted_Connection=true");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default",
 
                    "{controller=home}/{action=index}/{id?}");

                endpoints.MapControllerRoute("About",
                    "about-us",
                    defaults: new {controller="Home",action="About"});

                endpoints.MapControllerRoute("Contact",
                    "contact-us",
                    defaults: new { controller = "Home", action = "Contact" });


            });
        }
    }
}
