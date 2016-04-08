using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Tangerine.Controllers
{
    public class BaseController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            ViewBag.ApplicationTitle = WebConfigurationManager.AppSettings["ApplicationTitle"];
        }
	}
}