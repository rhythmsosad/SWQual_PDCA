using PDCA.Areas.Admin.Models;
using PDCA.Models;
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

        [HttpPost]
        public ActionResult Search(PlanSearch condition)
        {
            _DatatableResponseModel response = new _DatatableResponseModel();

            PlanModel model = new PlanModel();
            model.Search(condition);

            return Json(model.Items);
        }
    }
}