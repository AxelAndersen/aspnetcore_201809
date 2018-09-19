using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kAttrRouting2.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace kAttrRouting2.Controllers
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

        [Route("~/")]
        public IActionResult Index()
        {
            logger.LogInformation("In index");
            ViewBag.Kl = DateTime.Now.ToLongTimeString();
            ViewBag.Setting = appSetting.Setting2;

            return View();
        }

        [HttpGet("Lager/{year:int:min(2019):max(2230)}", Name = "Lager")]
        public IActionResult Lager2(int year)
        {            
            return Content("Lager år: " + year);
        }


        [Route("{*url}")]
        public IActionResult CatchAll(string url)
        {
            return Content("CatchAll, url = " + url);
        }
    }
}