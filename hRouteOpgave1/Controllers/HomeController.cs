using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hRouteOpgave1.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hRouteOpgave1.Controllers
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

        [HttpGet("lager")]
        public IActionResult Index()
        {
            logger.LogInformation("In index");
            ViewBag.Kl = DateTime.Now.ToLongTimeString();
            ViewBag.Setting = appSetting.Setting2;

            return View();
        }

        public IActionResult Salg()
        {
            
            return Content("Salg");
        }

        public IActionResult Lager(string omr, int year)
        {

            return Content($"Lagerområde {omr} i år {year}");
        }
    }
}