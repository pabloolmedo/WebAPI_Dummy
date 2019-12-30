using System.Web;
using System.Web.Mvc;

namespace WebApi_Test_CRM_Dummy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
