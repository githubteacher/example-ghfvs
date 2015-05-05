using System.Web;
using System.Web.Mvc;

namespace GitHub_for_Visual_Studio
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
