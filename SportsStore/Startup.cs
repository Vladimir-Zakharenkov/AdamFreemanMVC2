using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.WebEncoders;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace SportsStore
{
    public class Startup
    {

        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SportsStoreContext")));

            services.AddTransient<IProductRepository, EFProductRepository>();

            services.AddControllersWithViews();

            services.Configure<WebEncoderOptions>(options =>
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseRouting();


            //app.UseEndpoints(endpoints => endpoints.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Product}/{action=List}/{id?}"));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "pagination",
                    pattern: "Product/Page{productPage}",
                    defaults: new { controller = "Product", action = "List", });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=List}/{id?}");
            }
            );

            SeedData.EnsurePopulated(app);
        }
    }
}
