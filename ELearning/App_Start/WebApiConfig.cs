using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ELearning.App_Start
{

        public static class WebApiConfig
        {
            public static void Register(HttpConfiguration config)
            {
                config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "AppsApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );
            }
        }
    

}