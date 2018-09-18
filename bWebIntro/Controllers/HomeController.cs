using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bWebIntro.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bWebIntro.Controllers
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
            logger.LogInformation("In index");
            ViewBag.Kl = DateTime.Now.ToLongTimeString();
            ViewBag.Setting = appSetting.Setting2;

            return View();
        }
    }
}