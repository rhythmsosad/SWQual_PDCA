using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDCA.Areas.Admin.Controllers
{
    public class PlanController : Controller
    {
        // GET: Admin/Plan
        public ActionResult Index()
        {
            return View();
        }
    }
}