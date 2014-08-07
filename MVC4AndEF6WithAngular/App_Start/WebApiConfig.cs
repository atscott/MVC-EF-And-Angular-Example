using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MVC4AndEF6WithAngular
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "api",
                routeTemplate: "api/{controller}/{id}/{action}",
                defaults: new
                {
                    id = RouteParameter.Optional,
                    action = "default"
                }
            );

            //config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}