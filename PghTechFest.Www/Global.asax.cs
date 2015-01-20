using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using LowercaseRoutesMVC;
using PghTechFest.Www.App_Start;
using PghTechFest.Www.Models;

namespace PghTechFest.Www
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            System.Data.Entity.Database.SetInitializer(new SeedData());

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        private static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRouteLowercase("Default", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}