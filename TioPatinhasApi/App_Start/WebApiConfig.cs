using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.ExceptionHandling;
using Newtonsoft.Json;
using Swashbuckle.Application;
using TioPatinhasApi.Recursos;
using TioPatinhasRecursos.Helpers;

namespace TioPatinhasApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable CORS
            config.EnableCors(new EnableCorsAttribute("*", "*", "*", "Authorization,Content-Disposition,Content-Type"));

            // Web API configuration and services
            config.Services.Replace(typeof(IExceptionHandler), new WebApiExceptionHandler());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "SwaggerUI",
                routeTemplate: null,
                defaults: null,
                constraints: null,
                handler: new RedirectHandler(SwaggerHelpers.DefaultRootUrlResolver, "swagger"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Web API formatters configuration
            var formatters = config.Formatters;
            var settings = formatters.JsonFormatter.SerializerSettings;
            formatters.Remove(formatters.XmlFormatter);
            settings.DateTimeZoneHandling = DateTimeZoneHandling.Local;
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        }
    }
}