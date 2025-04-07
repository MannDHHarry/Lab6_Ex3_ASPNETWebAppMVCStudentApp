using System.Web;
using System.Web.Mvc;

namespace Ex3_ASPNETWebAppMVCStudentApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
