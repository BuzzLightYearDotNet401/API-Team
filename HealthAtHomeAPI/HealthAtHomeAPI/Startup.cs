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
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.Swagger;
using Microsoft.OpenApi.Models;

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

            //swagger
            IServiceCollection serviceCollection = services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo { Title = "Health At Home", Description = "test" });
            }) ;


            // registers our DbContext and the connection string is the path to our database server to where our database lives
            services.AddDbContext<HealthAtHomeAPIDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // BRING IN THE NEWTONSOFT LIBRARY, 
            // install-package microsoft.AspNetCore.Mvc.Newtonsoftjson
            services.AddControllers()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );




            // mappings of our interfaces and services
            services.AddTransient<IExerciseManager, ExerciseService>();
            services.AddTransient<IUserManager, UserService>();
            services.AddTransient<IRoutineNameManager, RoutineNameService>();
            services.AddTransient<IRatingManager, RatingService>();

            


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(x => {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "Health At Home v1");
            });

            // this sets up our routes and sets our controller to home and sets the action to our Index with the id being nullable 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
