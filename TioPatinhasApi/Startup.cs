using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup("TioPatinhas", typeof(TioPatinhasApi.Startup))]

namespace TioPatinhasApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            SimpleInjectorWebApiInitializer.Initialize(config);

            SwaggerConfig.Register(config);

            WebApiConfig.Register(config);

            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            app.UseWebApi(config);
        }
    }
}
