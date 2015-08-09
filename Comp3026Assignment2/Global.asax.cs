using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

//reference the http library
using System.Web.Http;

namespace Comp3026Assignment2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public const string OWNER = "storeOwner@comp3026.com";

        protected void Application_Start()
        {
            //set our http routing
            Comp3026Assignment2.App_Start.WebApiConfig.Register(GlobalConfiguration.Configuration);

            //remove xml as an output option in all browsers
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
