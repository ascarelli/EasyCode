using Prodesp.Core.Backend.Application.WebApi;
using Prodesp.Core.Backend.Application.WebApi.App_Start;
using [NAMESPACE].App_Start;
using [NAMESPACE].CrossCutting.IoC;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(NinjectConfig<IoC>), "Start")]
namespace [NAMESPACE]
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            xml.UseXmlSerializer = true;

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Application_End()
        {

        }
    }
}
