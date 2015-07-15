using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AhTask.Web.Areas.Sitecore.Controllers
{
    public class DeveloperController : Controller
    {
        // GET: Sitecore/Developer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SitecoreRocks()
        {
            return View();
        }

        public ActionResult Presentation()
        {
            return View();
        }

        public ActionResult Components()
        {
            return View();
        }
    }
}