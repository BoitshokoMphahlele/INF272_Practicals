using System.Web;
using System.Web.Mvc;

namespace u24634400_INF272_Prac2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
