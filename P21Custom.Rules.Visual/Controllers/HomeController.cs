using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P21.Rules.Visual.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Web hosting and protocol values listed below.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Resources and documentation.";

            return View();
        }
    }
}