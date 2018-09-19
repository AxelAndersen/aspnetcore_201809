using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gControllerOpgave.Models;
using gControllerOpgave.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace gControllerOpgave.Controllers
{
    public class HomeController : Controller
    {

        private AppSettings appSetting;
        private ILogger logger;

        public HomeController(AppSettings appSetting, ILogger<HomeController> logger)
        {
            this.appSetting = appSetting;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View(new Person() { Id = 1, Name = "Hans" });
        }

        public IActionResult Index3()
        {
            return View("Test");
        }

        public IActionResult Index4()
        {

            return Json(new Person() { Id = 1, Name = "Hans" });
        }

        public IActionResult Index5()
        {

            return View();
        }
    }
}