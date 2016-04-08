using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tangerine.Controllers
{
    public class SiteController : BaseController
    {
        // GET: Site
        public ActionResult Index()
        {
            return View();
        }
    }
}