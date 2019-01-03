﻿using Autofac;
using Autofac.Extensions.DependencyInjection;
using ChadRosenthal.Application.Domain;
using ChadRosenthal.Application.Repository.EFCore;
using ChadRosenthal.Web.UI.AppCode.Modules;
using ChadRosenthal.Web.UI.AppCode.Rules;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ChadRosenthal.Web.UI
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<CardholderUser, IdentityRole>(cfg =>
                {
                    cfg.User.RequireUniqueEmail = true;
                })
                .AddEntityFrameworkStores<ChadRosenthalContext>();

            services.AddDbContext<ChadRosenthalContext>(cfg =>
            {
                cfg.UseSqlServer(_configuration.GetConnectionString("ChadRosenthalConnectionString"));
            }
            );

            services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.AllowAreas = true;

                options.Conventions.AuthorizeAreaFolder("account", "/");

            });

            //Now register our services with Autofac container
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutofacModule());
            builder.Populate(services);
            var container = builder.Build();
            //Create the IServiceProvider based on the container.
            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            var options = new RewriteOptions().Add(new RedirectLowerCaseRule());
            app.UseRewriter(options);

            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseAuthentication();


            app.UseMvc();
        }
    }
}
