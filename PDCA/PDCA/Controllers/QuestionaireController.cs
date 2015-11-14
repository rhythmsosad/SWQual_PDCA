using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDCA.Controllers
{
    public class QuestionaireController : Controller
    {
        // GET: Questionaire
        public ActionResult Index()
        {
            return View();
        }
    }
}