using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//reference the http library
using System.Web.Http;

namespace Comp3026Assignment2.App_Start
{
    class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "VApi",
                routeTemplate: "api/product/{id}",
                defaults: new { controller = "VApi", id = RouteParameter.Optional });
        }
    }
}
