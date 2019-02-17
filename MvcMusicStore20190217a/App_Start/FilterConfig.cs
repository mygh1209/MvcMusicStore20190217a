using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore20190217a
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
