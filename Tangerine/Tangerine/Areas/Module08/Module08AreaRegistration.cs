using System.Web.Mvc;

namespace Tangerine.Areas.Module08
{
    public class Module08AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Module08";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Module08_default",
                "Module08/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}