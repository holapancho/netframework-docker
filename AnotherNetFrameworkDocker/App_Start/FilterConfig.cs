using System.Web;
using System.Web.Mvc;

namespace AnotherNetFrameworkDocker
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
