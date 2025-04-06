using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Project01MVC
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // dependancy injection
            services.AddMvc(); // Add Controller , Add Views , Add Razor pages , Api
            //services.AddControllers(); // Support Api Controllers [built in services to the container]
            //services.AddControllersWithViews(); // Add Controllers , Add Views , Support  api Controllers  
            //services.AddRazorPages(); // Add views , Add Razor pages

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
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});

                //endpoints.MapPost("/Hamada", async context =>
                //{
                //    await context.Response.WriteAsync("Hello Hamada!");
                //});

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id:int?}/{name:alpha?}"
                    // defaults : new {Controllers = "Movies" , action = "GetMovies"}
                    // constraints : new {id = new IntRouteConstraint()}
                    );
            });
        }
    }
}
