using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab3.Models;

namespace lab3.Controllers
{
    public class MockupsController : Controller
    {
        private static List<Mockups> list = new List<Mockups>();
        private static int rightans = -1;

        public IActionResult Quiz(Mockups cla)
        {
            if (ModelState.IsValid) { rightans++; }
            list.Add(cla);
            if (Request.Method == "POST") { ViewBag.ans = rightans; list.RemoveAt(0); return View("~/Views/Mockups/Result.cshtml", list); }
            var question = new Mockups(true);

            return View(question);
        }

        public IActionResult Result()
        {
            ViewBag.ans = rightans;
            return View(list);
        }

    }
}