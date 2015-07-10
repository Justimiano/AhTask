using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AhTask.Web.Controllers
{
    public class TechController : Controller
    {
        // GET: Tech
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TeamFoundationServer()
        {
            return View();
        }

        public ActionResult TeamDevelopmentSitecore()
        {
            return View();
        }

        
        public ActionResult OctopusDeploy()
        {
            return View();
        }


        public ActionResult WindowsAzure()
        {
            return View();
        }

        public ActionResult Sitecore()
        {
            return View();
        }

        public ActionResult GlassMapper()
        {
            return View();
        }

        public ActionResult TeamCity()
        {
            return View();
        }

    }
}