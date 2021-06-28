using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bigshool.Controllers
{
    public class CoursesController : Controller
    {
        // GET: CoursesController
        public ActionResult Create()
        {
            return View();
        }
    }
}