using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Trixnet.web.Models;
using Microsoft.EntityFrameworkCore;

using Trixnet.web.Services;

namespace Trixnet.web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           /* var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("Services/options.json");
            var config = builder.Build();
            var appConfig = new OptionsClass();
            config.GetSection("App").Bind(appConfig);
            ViewBag.Link = appConfig.link.linkValue;*/
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
             services.AddDbContext<ConnectionStringClass>(options => options.UseSqlServer("Server=TRIXBURINDUS44\\SQLEXPRESS;Database=Trixnet;User Id=webmaster;Password=Trixell123!"));
            //services.AddDbContext<ConnectionStringClass>(options => options.UseSqlServer("Server=trixsql05;Database=Trixnet;User Id=user-sa;Password=I&J8g=$0TB"));
            services.AddOrchardCms();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
           
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseOrchardCore();

        }
    }
}
