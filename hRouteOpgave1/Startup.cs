﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hRouteOpgave1.Models.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace hRouteOpgave1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            AppSettings settings = new AppSettings();
            Configuration.Bind("Settings", settings);
            services.AddSingleton(settings);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            app.UseFileServer();

            app.UseMvc(i => {

                //i.MapRoute("default", "{controller=home}/{action=Index}");
                i.MapRoute("lager", "lager/{omr}/{year}", new { Controller = "Home", Action = "Lager" }, new { year = "[0-9][0-9]" });
                i.MapRoute("default", "{action=Index}", new { Controller = "Home" });
                

            });

        }
    }
}