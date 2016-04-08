using System.Web.Mvc;

namespace Tangerine.Areas.Module03
{
    public class Module03AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Module03";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Module03_default",
                "Module03/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}