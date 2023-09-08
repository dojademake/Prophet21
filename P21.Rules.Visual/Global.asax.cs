using P21.Rules.Visual.Utilities;
using P21Custom.Entity.Database;
using P21Custom.Entity.Services;
using P21Custom.Extensions.BusinessRule.BLL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;

namespace P21.Rules.Visual
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalFilters.Filters.Add(new HandleErrorAttribute());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // from https://stackoverflow.com/questions/48778587/mvc-routeconfig-catchall-url-not-working
            //ControllerBuilder.Current.SetControllerFactory(new NotFoundControllerFactory());

            Database.SetInitializer<P21DbContext>(null);

            // Create and configure the Unity container
            var container = new UnityContainer();

            // Register the custom logger implementation
            container.RegisterType<IRuleLogger, DebugRuleLogger>();

            // Set the Unity dependency resolver
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
