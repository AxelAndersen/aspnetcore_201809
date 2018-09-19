using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fEFOpgave.Models;
using fEFOpgave.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace fEFOpgave.Controllers
{
    public class HomeController : Controller
    {

        private AppSettings appSetting;
        private ILogger logger;
        private readonly PersonRepository _rep;

        public HomeController(AppSettings appSetting, ILogger<HomeController> logger, PersonRepository rep)
        {
            this.appSetting = appSetting;
            this.logger = logger;
            this._rep = rep;
        }

        public IActionResult Index()
        {
            logger.LogInformation("In index");
            ViewBag.Kl = DateTime.Now.ToLongTimeString();
            ViewBag.Setting = appSetting.Setting2;

            return View(_rep.HentAlle());
        }
    }
}