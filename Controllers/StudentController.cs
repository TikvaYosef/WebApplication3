using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowNameOfStudent()
        {
            ViewBag.title = "Tikva";
            return View();
        }
        public ActionResult ShowStudent()
        {
            
            return View();
        }
        public ActionResult ShowNamesOfStudents()
        {
            string[] namesOfStudent = new string[] { "tikva", "keren", "yafit", "eden", "lior", "aschalo" };
            ViewBag.array = namesOfStudent;
            return View() ;
        }
        public ActionResult ShowStudents()
        {
            return View();
        }
        public ActionResult JsonObject()
        {
            string[] array4= new string[] { "tikva" ,"keren","25" };
           
            return Json(array4,JsonRequestBehavior.AllowGet);
        }

    }
}