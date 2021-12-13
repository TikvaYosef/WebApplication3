using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

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
            return View();
        }
        public ActionResult ShowStudents()
        {
            return View();
        }
        public ActionResult JsonObject()
        {
            string[] array4 = new string[] { "tikva", "keren", "25" };

            return Json(array4, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ObjectS()
        {
            Student student1 = new Student("tikva", "yosef", 1996, 12);
            ViewBag.student = student1;
            return View();
        }
        public ActionResult ObjectS2()
        {
            return View(Ob1());
        }
        static Student Ob1()
        {
            Student student1 = new Student("keren", "hailu", 1998, 12);
            return  student1;


        }

        public ActionResult Objects4()
        {
            return View(Ob());
        }

        static List<Student> Ob()
        {
            Student student2 = new Student("shay", "balayna", 2000, 10);
            Student student3 = new Student("keren", "haillu", 1998, 13);
            Student student4 = new Student("eden", "testma", 1996, 12);
            Student student5 = new Student("yafit", "samuel", 1997, 11);
            List<Student> list1 = new List<Student>();
            list1.Add(student2);
            list1.Add(student3);
            list1.Add(student4);
            list1.Add(student5);
            return list1;
        }

    }
}