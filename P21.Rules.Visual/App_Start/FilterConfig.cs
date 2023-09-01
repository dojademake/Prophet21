using P21.Rules.Visual.Utilities;
using System.Web;
using System.Web.Mvc;

namespace P21.Rules.Visual
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomHandleErrorAttribute());
        }
    }
}
