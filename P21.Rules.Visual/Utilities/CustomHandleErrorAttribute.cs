using P21Custom.Extensions.BusinessRule.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;

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