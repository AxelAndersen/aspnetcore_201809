using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jAttrRouting.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace jAttrRouting.Controllers
{
    [Route("list")]
    public class HomeController : Controller
    {

        private AppSettings appSetting;
        private ILogger logger;

        public HomeController(AppSettings appSetting, ILogger<HomeController> logger)
        {
            this.appSetting = appSetting;
            this.logger = logger;
        }

        [Route("lager")]
        public IActionResult ssss()
        {

            return Json("lager");
        }
    }
}