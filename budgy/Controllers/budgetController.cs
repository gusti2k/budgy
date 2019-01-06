using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace budgy.Controllers
{
    public class budgetController : Controller
    {

        private budgy.Models.Budget b = new Models.Budget();
        // GET: budget
        public ActionResult Index()
        {
            return View();
        }

        private ActionResult Budget()
        {
            int resultat = 0;

            resultat = b.Hus + b.Mad;


            return null;
        }
    }
}