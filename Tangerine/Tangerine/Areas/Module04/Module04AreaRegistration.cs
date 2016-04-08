using System.Web.Mvc;

namespace Tangerine.Areas.Module04
{
    public class Module04AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Module04";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Module04_default",
                "Module04/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}