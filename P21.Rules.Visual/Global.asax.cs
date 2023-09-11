using P21.Rules.Visual.Utilities;
using P21Custom.Entity.Database;
using P21Custom.Extensions.BusinessRule;
using P21Custom.Extensions.BusinessRule.BLL;
using System.Data.Entity;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using Unity.AspNet.Mvc;
using Unity.Interception.Utilities;

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

        //protected void Application_Error(object sender, EventArgs e)
        //{
        //    Exception exception = Server.GetLastError();

        //    // Log the exception using your chosen logging framework
        //    //var logger = new RuleLogger();
        //    //logger.LogCritical($"An unhandled exception was captured in the {MethodBase.GetCurrentMethod().Name} method.", exception);
        //    //var logger = log4net.LogManager.GetLogger(typeof(Global));
        //    //logger.Error("An unhandled exception occurred", exception);

        //    // Redirect to a specific error ASPX page if available
        //    string errorPage = "~/Error/Index"; // Default error page path

        //    if (exception is HttpException httpException)
        //    {
        //        int statusCode = httpException.GetHttpCode();
        //        string statusCodePage = $"~/Error_{statusCode}.aspx"; // Error page for the specific status code

        //        // Check if the status code-specific error page exists at the root
        //        if (System.IO.File.Exists(Server.MapPath("~" + statusCodePage)))
        //        {
        //            errorPage = statusCodePage; // Use the status code-specific error page
        //        }
        //    }

        //    // Redirect to the specified error page
        //    Server.ClearError(); // Clear the error
        //    Response.Redirect(errorPage);
        //}
    }
}