using Swashbuckle.Application;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace [NAMESPACE].App_Start
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
              name: "swagger_root",
              routeTemplate: "",
              defaults: null,
              constraints: null,
              handler: new RedirectHandler((message => message.RequestUri.ToString()), "swagger")
          );

            routes.MapRoute(
                name: "api[ENTITY]",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "[ENTITY]", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}