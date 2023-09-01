using System.Web.Mvc;

namespace P21.Rules.Visual
{
    public class ErrorController : Controller
    {
        public ActionResult NotFound()
        {
            Response.StatusCode = (int)System.Net.HttpStatusCode.NotFound;
            Response.StatusDescription = "404 Not Found (controller)";

            return View();
        }
    }
}