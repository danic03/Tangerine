using System.Web.Mvc;

namespace Tangerine.Areas.Module02
{
    public class Module02AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Module02";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Module02_default",
                "Module02/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}