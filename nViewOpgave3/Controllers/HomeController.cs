using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nViewOpgave3.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace nViewOpgave3.Controllers
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
    }
}