using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Newtonsoft.Json;

namespace LottResultsApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();    GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling =
               ReferenceLoopHandling.Ignore;

            AutofacBoot.Init();

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
