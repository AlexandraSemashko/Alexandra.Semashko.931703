using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MathsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel() //передает данные в представление
        {
            var ViewModel = new Maths();
            return View(ViewModel);//передача в представление "PassUsingModel"
        }

        public IActionResult PassUsingViewData()
        {
            ViewData["Class"] = new Maths();
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            ViewBag.Class = new Maths();
            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            ViewData["Title"] = "AccessServiceDirectly";
            return View();
        }

    }
}