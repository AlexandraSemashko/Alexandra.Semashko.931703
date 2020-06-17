using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using lab2.Models;

namespace lab2.Controllers
{ 
    public class CalcController : Controller
    { 
        public IActionResult Index()
    {
        return View();
    }

    public IActionResult Manual(float x, float y, char operation)
    {
        if (Request.Method == "GET")
        {
            ViewData["Title"] = "Manual";
            return View("Getall");
        }
        else
        {
            Calc cl = new Calc();
            cl.x = x;
            cl.y = y;
            ViewBag.x = cl.x;
            ViewBag.y = cl.y;
            switch (operation)
            {
                case '+': ViewBag.res = cl.Add(); ViewBag.op = '+'; break;
                case '-': ViewBag.res = cl.Sub(); ViewBag.op = '-'; break;
                case '*': ViewBag.res = cl.Mult(); ViewBag.op = '*'; break;
                case '/': ViewBag.res = cl.Div(); ViewBag.op = '/'; break;
            }

            ViewData["Title"] = "Result";
            return View("Result1");
        }

    }


    [HttpGet]
    public IActionResult ManualWithSeparateHandlers()//get
    {
        ViewData["Title"] = "ManualWithSeparateHandlers";
        return View("Getall");
    }

    [HttpPost]
    public IActionResult ManualWithSeparateHandlers(float x, float y, char operation)//get
    {
        Calc cl = new Calc();
        cl.x = x;
        cl.y = y;
        ViewBag.x = cl.x;
        ViewBag.y = cl.y;
        switch (operation)
        {
            case '+': ViewBag.res = cl.Add(); ViewBag.op = '+'; break;
            case '-': ViewBag.res = cl.Sub(); ViewBag.op = '-'; break;
            case '*': ViewBag.res = cl.Mult(); ViewBag.op = '*'; break;
            case '/': ViewBag.res = cl.Div(); ViewBag.op = '/'; break;
        }

        ViewData["Title"] = "Result";
        return View("Result1");
    }

    [HttpGet]
    public IActionResult ModelBindingInParametrs()//get
    {
        ViewData["Title"] = "ModelBindingInParametrs";
        return View("Getall");
    }

    [HttpPost]
    public IActionResult ModelBindingInParametrs([Bind("x,y")]Calc cl, char operation)//get
    {

        switch (operation)
        {
            case '+': ViewBag.res = cl.Add(); break;
            case '-': ViewBag.res = cl.Sub(); break;
            case '*': ViewBag.res = cl.Mult(); break;
            case '/': ViewBag.res = cl.Div(); break;
        }

        ViewData["Title"] = "Result";
        return View("Result2");
    }

    [HttpGet]
    public IActionResult ModelBindingInSeparateModel()//get
    {
        ViewData["Title"] = "ModelBindingInSeparateModel";
        return View("Getall");
    }

    [HttpPost]
    public IActionResult ModelBindingInSeparateModel(Calc cl, char operation)//get
    {

        switch (operation)
        {
            case '+': ViewBag.res = cl.Add(); break;
            case '-': ViewBag.res = cl.Sub(); break;
            case '*': ViewBag.res = cl.Mult(); break;
            case '/': ViewBag.res = cl.Div(); break;
        }

        ViewData["Title"] = "Result";
        return View("Result2");
    }
}

}