using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tangerine.Areas.Template.Controllers
{
    public class AdminLTEController : Controller
    {
        //
        // GET: /Template/AdminLTE/
        [HttpGet]
        public ActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Dashboard2()
        {
            return View();
        }
	}
}