using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab01.Models;

namespace Lab01.Controllers
{
    public class DashboardController : Controller
    {


        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin()
        {
            return View();
        }
    }
}