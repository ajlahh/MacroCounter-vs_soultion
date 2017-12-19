using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MacroCounter
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        { 
            // Web API configuration and services


            GlobalConfiguration.Configuration.MessageHandlers.Insert(0, new ServerCompressionHandler(new GZipCompressor(), new DeflateCompressor()));

            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
