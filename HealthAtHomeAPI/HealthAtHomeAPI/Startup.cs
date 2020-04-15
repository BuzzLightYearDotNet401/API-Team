using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthAtHomeAPI.Data;
using HealthAtHomeAPI.Models.Interfaces;
using HealthAtHomeAPI.Models.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HealthAtHomeAPI
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        /// <summary>
        /// Helps us build a configuration to better protect our user secrets like our connection strings or API keys and enables the secrets.json file.
        /// </summary>
        public Startup()
        {
            var builder = new ConfigurationBuilder()
            .AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // this adds our middleware
            services.AddMvc();

            // registers our DbContext and the connection string is the path to our database server to where our database lives
            services.AddDbContext<HealthAtHomeAPIDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // mappings
            services.AddTransient<IExerciseManager, ExerciseService>();
            services.AddTransient<IUserManager, UserService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // this sets up our routes and sets our controller to home and sets the action to our Index with the id being nullable 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
