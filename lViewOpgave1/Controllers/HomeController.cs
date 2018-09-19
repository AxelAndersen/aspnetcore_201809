using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cronberg;
using lViewOpgave1.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace lViewOpgave1.Controllers
{
    public class HomeController : Controller
    {

        private AppSettings appSetting;
        private ILogger logger;
        private ILandeRepository _rep;

        public HomeController(AppSettings appSetting, ILogger<HomeController> logger, ILandeRepository rep)
        {
            this.appSetting = appSetting;
            this.logger = logger;
            this._rep = rep;
        }

        public IActionResult Index()
        {
            var lande = _rep.HentLande();
            return View(lande);
        }
    }
}