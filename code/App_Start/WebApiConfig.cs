using System.Web.Http;
using Ucodia.SimpleAuth.Handlers;

namespace Ucodia.SimpleAuth
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Message handlers
            config.MessageHandlers.Add(new RequireHttpsMessageHandler());
        }
    }
}
