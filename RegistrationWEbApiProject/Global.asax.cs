using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RegistrationWEbApiProject
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest()
        {
        //   // string[] allowSites = new string[] { "https://localhost:44367" };
        //   // var origin = HttpContext.Current.Request.Headers["Origin"];
        //  // if(origin!=null)
        //  //  {
        //     //   HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", origin);

        //  //  HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET,POST");

        //   // }

        }
    }
}
