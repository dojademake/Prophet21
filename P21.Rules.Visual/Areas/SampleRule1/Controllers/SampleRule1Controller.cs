
using P21.Extensions.Web;
using System;
using System.Web;
using System.Web.Mvc;


namespace P21.Rules.Visual.Areas.SampleRule1.Controllers
{
    public class SampleRule1Controller : BaseRuleController
    {
        // GET: SampleRule1/SampleRule1
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult Return()
		{
			Rule.RuleResult.Success = true;

			//IMPORTANT - This is what returns the Visual Rule control back to the server
			//DO NOT REMOVE
			return RedirectToAction("Close", "Initialize", new { area = "" });
		}
    }

}