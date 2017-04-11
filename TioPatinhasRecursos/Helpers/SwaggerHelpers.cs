using System;
using System.Net.Http;

namespace TioPatinhasRecursos.Helpers
{
    public class SwaggerHelpers
    {
        public static string DefaultRootUrlResolver(HttpRequestMessage request)
        {
            return request.RequestUri.GetLeftPart(UriPartial.Authority) + request.GetRequestContext().VirtualPathRoot.TrimEnd('/');
        }
    }
}
