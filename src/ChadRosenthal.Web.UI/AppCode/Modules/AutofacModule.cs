using Autofac;
using ChadRosenthal.Application.Repository.Static;
using ChadRosenthal.Application.Services;
using ChadRosenthal.Application.Services.Interfaces.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChadRosenthal.Web.UI.AppCode.Modules
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NewsService>().As<INewsService>();
            builder.RegisterType<NewsArticleRepository>().As<INewsArticleRepository>();
            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>().SingleInstance();
        }
    }
}
