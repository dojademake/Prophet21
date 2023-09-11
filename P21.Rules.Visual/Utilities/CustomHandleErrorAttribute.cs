using P21Custom.Extensions.BusinessRule;
using System.Web.Mvc;

namespace P21.Rules.Visual.Utilities
{
    public class CustomHandleErrorAttribute : HandleErrorAttribute
    {
        public IRuleLogger Logger { get; set; }

        public override void OnException(ExceptionContext filterContext)
        {
            Logger = DependencyResolver.Current.GetService<IRuleLogger>();
            Logger?.LogError(filterContext.Exception.ToString());
            base.OnException(filterContext);
        }
    }
}