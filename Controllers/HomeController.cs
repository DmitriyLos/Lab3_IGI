using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Lab3.Models;
using Lab3.ViewModels;
using Lab3.Services;


namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        private IMemoryCache _cache;
        public HomeController(IMemoryCache memoryCache) {
            _cache = memoryCache;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            HomeViewModel homeViewModel = _cache.Get<HomeViewModel>("operation");
            return View(homeViewModel);
        }

        public IActionResult About2()
        {
            HomeViewModel homeViewModel = TakeLast.GetHomeViewModel();
            return View("~/Views/Home/About.cshtml", homeViewModel);
        }

        [ResponseCache(CacheProfileName = "Caching")]
        public IActionResult About3()
        {

            HomeViewModel homeViewModel = TakeLast.GetHomeViewModel();
            return View("~/Views/Home/About.cshtml", homeViewModel);
        }

        [HttpGet]
        public IActionResult Car()
        {
            if (HttpContext.Session.Keys.Contains("model"))
            {
                ViewBag.Model = HttpContext.Session.GetString("model");
            }
            if (HttpContext.Session.Keys.Contains("power"))
            {
                ViewBag.Power = HttpContext.Session.GetString("power");
            }
            if (HttpContext.Session.Keys.Contains("colour"))
            {
                ViewBag.Colour = HttpContext.Session.GetString("colour");
            }
            if (HttpContext.Session.Keys.Contains("stateNumber"))
            {
                ViewBag.StateNumber = HttpContext.Session.GetString("stateNumber");
            }
            if (HttpContext.Session.Keys.Contains("yearOfIssue"))
            {
                ViewBag.YearOfIssue = HttpContext.Session.GetString("yearOfIssue");
            }
            if (HttpContext.Session.Keys.Contains("bodyNumber"))
            {
                ViewBag.BodyNumber = HttpContext.Session.GetString("bodyNumber");
            }
            if (HttpContext.Session.Keys.Contains("engineNumber"))
            {
                ViewBag.EngineNumber = HttpContext.Session.GetString("engineNumber");
            }
            return View("~/Views/Car/Index.cshtml");
        }

        [HttpGet]
        [ResponseCache(CacheProfileName = "Caching")]
        public IActionResult Home()
        {
            return View("~/Views/Home/Index.cshtml");
        }

        [HttpGet]
        [ResponseCache(CacheProfileName = "Caching")]
        public IActionResult Order()
        {
            return View("~/Views/Order/Index.cshtml");
        }

        [HttpGet]
        [ResponseCache(CacheProfileName = "Caching")]
        public IActionResult Owner()
        {
            return View("~/Views/Owner/Index.cshtml");
        }

        [HttpGet]
        public IActionResult Worker()
        {
            string FioWorker = "", DateOfEmployment = "", DateOfDismissal = "", Salary = "";
            if (HttpContext.Request.Cookies.ContainsKey("fioWorker")) {
                FioWorker = HttpContext.Request.Cookies["fioWorker"];
            }
            if (HttpContext.Request.Cookies.ContainsKey("dateOfEmployment"))
            {
                DateOfEmployment = HttpContext.Request.Cookies["dateOfEmployment"];
            }
            if (HttpContext.Request.Cookies.ContainsKey("dateOfDismissal"))
            {
                DateOfDismissal = HttpContext.Request.Cookies["dateOfDismissal"];
            }
            if (HttpContext.Request.Cookies.ContainsKey("salary"))
            {
                Salary = HttpContext.Request.Cookies["salary"];
            }
            ViewBag.FioWorker = FioWorker;
            ViewBag.DateOfEmployment = DateOfEmployment;
            ViewBag.DateOfDismissal = DateOfDismissal;
            ViewBag.Salary = Salary;
            return View("~/Views/Worker/Index.cshtml");
        }
       
       [HttpPost]
        public string Car(string Model, string StateNumber,
            string Colour, int Power)
        {
            HttpContext.Session.SetString("model", Model);
            HttpContext.Session.SetString("stateNumber", StateNumber);
            HttpContext.Session.SetString("colour", Colour);
            HttpContext.Session.SetString("power", Power.ToString());
            return "Автомобиль " + Model + " с гос. номером " + StateNumber + "\n" +
                "добавлен в базу. Цвет: " + Colour + ", мощность: " + Power;
        }

        [HttpPost]
        public string Order(int OrderID, string DateReceipt)
        {
            return "Заказ " + OrderID + " на дату " + DateReceipt + " добавлен";
        }
       
       [HttpPost]
        public string Worker(string FioWorker, decimal Salary)
        {
            HttpContext.Response.Cookies.Append("name", FioWorker);
            HttpContext.Response.Cookies.Append("post", Salary.ToString());
            return "Рабочий " + FioWorker + " с зарплатой " + Salary
                + " успешно зарегистрирован";
        }

        //[HttpPost]
        //public string Appoint(string name, string phone)
        //{
        //    return "Клиент " + name + " с номером " + phone
        //        + " успешно зарегистрирован";
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
