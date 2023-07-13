using DryIoc;
using DryIoc.WebApi;
//using DryIoc;
using EmployeeProject.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EmployeeProject
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var container = new Container();
            DependencyConfiguration.Register(container);
            container.WithWebApi(GlobalConfiguration.Configuration);
            //var container = new Container();
            //DependencyConfiguration.Register(container);
            //container.withWebApi
            //DependencyConfiguration.Register(container);
            //container.WithWebApi(GlobalConfiguration.Configuration);
        }
    }
}
