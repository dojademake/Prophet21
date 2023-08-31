using P21Custom.Entity.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.SessionState;

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
        }

        private class NotFoundControllerFactory : IControllerFactory
        {
            public IController CreateController(RequestContext requestContext, string controllerName)
            {
                throw new NotImplementedException();
            }

            public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
            {
                throw new NotImplementedException();
            }

            public void ReleaseController(IController controller)
            {
                throw new NotImplementedException();
            }
        }
    }
}
