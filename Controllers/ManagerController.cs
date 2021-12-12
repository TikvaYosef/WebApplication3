using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowNameOfManager()
        {
            ViewBag.title = "Tikva";
            return View();
        }
        public ActionResult ShowManager()
        {
            return View();
        }
        public ActionResult ShowNamesOfManagers()
        {
            string[] namesOfManagers = new string[] { "tikva", "keren", "yafit", "eden", "lior", "aschalo" };
            ViewBag.array = namesOfManagers;
            return View();
        }
        public ActionResult ShowManagers()
        {
            return View();
        }


    }
}