using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace SignUpForm
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // This will inject an MVC system to the using project.
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // This will recognize and enable files inside of wwwroot (where static files are stored) when executing the app.
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                // Set up a routing middleware for mapping.
                routes.MapRoute(
                    name: "default",
                    // The main page will display the view (Student.cshtml) which is returned by the Student action method in HomeController.
                    template: "{controller=Home}/{action=Student}/{id?}");
            });
        }
    }
}
