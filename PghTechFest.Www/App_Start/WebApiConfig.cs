using System.Data.Entity.Migrations;
using System.Net.Http.Headers;
using System.Web.Http;
using PghTechFest.Www.Migrations;

namespace PghTechFest.Www.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var migrator = new DbMigrator(new Configuration());
            migrator.Update();
        }
    }
}