using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDCA.Areas.Admin.Controllers
{
    public class QuestionaireController : Controller
    {
        // GET: Questionaire
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }
    }
}