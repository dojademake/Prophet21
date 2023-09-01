using System.Web.Mvc;

namespace P21.Rules.Visual.Areas.SampleRule1
{
    public class SampleRule1AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SampleRule1";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SampleRule1_default",
                "SampleRule1/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}