using System.Web;
using System.Web.Mvc;

namespace VnExpress_NgoThanhThai_Lab1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
