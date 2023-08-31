using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace P21.Rules.Visual
{
    //public class NotFoundControllerFactory : IControllerFactory
    //{
    //    public IController CreateController(RequestContext requestContext, string controllerName)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void ReleaseController(IController controller)
    //    {
    //        throw new NotImplementedException();
    //    }

    // from https://stackoverflow.com/questions/48778587/mvc-routeconfig-catchall-url-not-working
    public class NotFoundControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            // If controller not found it will be null, so we want to take control
            // of the request and send it to the ErrorController.NotFound method.
            if (controllerType == null)
            {
                requestContext.RouteData.Values["action"] = "NotFound";
                requestContext.RouteData.Values["controller"] = "Error";
                return base.GetControllerInstance(requestContext, typeof(ErrorController));
            }

            return base.GetControllerInstance(requestContext, controllerType);
        }
    }
}