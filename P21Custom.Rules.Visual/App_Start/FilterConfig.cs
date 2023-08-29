using System.Web;
using System.Web.Mvc;

namespace P21Custom.Rules.Visual
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
