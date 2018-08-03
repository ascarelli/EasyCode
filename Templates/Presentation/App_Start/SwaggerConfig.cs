using System.Web.Http;
using WebActivatorEx;
using [NAMESPACE];
using Swashbuckle.Application;
using static [NAMESPACE].App_Start.FilterConfig;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace [NAMESPACE]
{
    public static class SwaggerConfig
    {

        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "[ENTITY] WebApi");
                    c.SchemaId(x => x.FullName);
                    c.OperationFilter<AddRequiredHeaderParameter>();
                })
                .EnableSwaggerUi(c =>
                {
                    c.DisableValidator();
                });
        }
    }
}
