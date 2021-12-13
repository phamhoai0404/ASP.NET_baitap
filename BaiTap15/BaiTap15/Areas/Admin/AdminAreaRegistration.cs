using System.Web.Mvc;

namespace BaiTap15.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Login", Controller = "Home", id = UrlParameter.Optional }
            );
            context.MapRoute(
               "TaiKhoans",
               "Admin/{controller}",
               new { controller = "TaiKhoans", action = "Index" }
           );
        }
    }
}