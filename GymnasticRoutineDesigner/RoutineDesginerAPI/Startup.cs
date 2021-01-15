using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAcces.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RoutineDesginerAPI.Extension;
using RoutineDesginerAPI.Hubs;
using DataAcces.Interfaces;

namespace RoutineDesginerAPI
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
            services.AddTransient<IApparatusContext, ApparatusContext>();
            services.AddTransient<IElementContext, ElementContext>();
            services.AddTransient<IRoutineContext, RoutineContext>();
            services.AddTransient<ISkillGroupContext, SkillGroupContext>();
            services.AddTransient<ISkillLevelContext, SkillLevelContext>();

            services.ConfigureCors();
            services.AddControllers();

            services.AddSignalR();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors("CorsDevelopment");

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {   
                endpoints.MapHub<NotificationHub>("/notification");
                endpoints.MapControllers();
            });
        }
    }
}
