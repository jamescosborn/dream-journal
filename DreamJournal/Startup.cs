﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DreamJournal.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamJournal
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json"); //this line replaces .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddEntityFrameworkMySql()
                    .AddDbContext<DreamJournalContext>(options =>
                                              options
                                                   .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default",
                                 template: "{controller=Home}/{action=Index}/{id?}");
            });



            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
