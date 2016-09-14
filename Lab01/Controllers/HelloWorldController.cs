using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public String Hello(string name, int age)
        {
            return "Xin chào bạn " + name + ", " + age + "tuổi.";
        }
    }
}