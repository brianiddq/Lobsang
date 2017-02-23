using Lobsang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lobsang.Controllers
{
    public class LiftChairController : Controller
    {
        // GET: LiftChair
        public ActionResult Index()
        {
            return View();
        }

        // GET: LiftChair/Random
        public ActionResult Random()
        {
            var liftChair = new LiftChair() { Section = 0, RPM = 100 };
            return View(liftChair);
        }
    }
}