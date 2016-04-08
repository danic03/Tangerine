using System.Web.Mvc;

namespace Tangerine.Areas.Module05
{
    public class Module05AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Module05";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Module05_default",
                "Module05/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}