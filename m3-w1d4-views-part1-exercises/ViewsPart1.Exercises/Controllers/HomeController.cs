﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsPart1.Exercises.Controllers
{
    public class HomeController : Controller
    {
        //GET: Index
        // /
        // /Home
        // /Home/Index
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: FizzBuzz
        // /Home/FizzBuzz
        public ActionResult FizzBuzz()
        {
            return View("FizzBuzz");
        }

        // GET: Fibonacci
        // /Home/Fibonacci
        public ActionResult Fibonacci()
        {
            return View("Fibonacci");
        }

        // GET: Echo
        // /Home/Echo
        public ActionResult Echo()
        {
            return View("Echo");
        }
        // GET: Echo
        // /Home/Echo
        //public ActionResult MoreEchos()
        //{
        //    return View("MoreEchos");
        //}
        public ActionResult MoreEchos()
        {
            List<string> colorList = new List<string>()
            {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
        };

            // Return the View "Colors" and pass the colorList as the model
            return View("MoreEchos", colorList);
        }
        public ActionResult Fib2()
        {
            return View("Fib2");
        }
    }
}