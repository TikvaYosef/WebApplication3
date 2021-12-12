﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowNameOfTeacher()
        {
            ViewBag.title = "tikva";
            return View();
        }
        public ActionResult ShowTeacher()
        {
            return View();
        }
        public ActionResult ShowNamesOfTeachers()
        {
            string[] namesOfTeachers = new string[] { "tikva", "keren", "yafit", "eden", "lior", "aschalo" };
            ViewBag.array = namesOfTeachers;
            return View();
        }
        public ActionResult ShowTachers()
        {
            return View();
        }
        public ActionResult RandomNum()
        {
            
            Random random = new Random();
            int[] arrayOfNum = new int[10];
            ViewBag.array = arrayOfNum;
            for (int i = 0; i < ViewBag.array.Length; i++)
            {
                ViewBag.array[i] = random.Next(0, 50);
            }
            return View();
        }

        public ActionResult RandomName()
        {
            string[] arrayOfLname = new string[] { "levi", "cohen", "yosef", "hailu", "tzagay", "balay", "tasama", "samuel", "ayano", "mekonen" };
            ViewBag.array = arrayOfLname;
            return View();
        }
    }
}