using System.Web.Http;
using Swashbuckle.Application;
using TioPatinhasRecursos.Helpers;

namespace TioPatinhasApi
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var globalHeader = new SwaggerHeaderParameter
            {
                Description = "API Token de autenticação",
                Key = "Authorization",
                Name = "Authorization"
            };

            config.EnableSwagger(c =>
            {
                c.RootUrl(SwaggerHelpers.DefaultRootUrlResolver);

                c.SingleApiVersion("v1", "Tio Patinhas API");

                globalHeader.Apply(c);
            })
            .EnableSwaggerUi(c =>
            {
                c.DisableValidator();

                c.EnableApiKeySupport("Authorization", "header");
            });
        }
    }
}