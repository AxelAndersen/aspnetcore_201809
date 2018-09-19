using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mViewOpgave2.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cronberg;

namespace mViewOpgave2.Controllers
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

        [HttpGet]
        public IActionResult Index()
        {
            LandeRepository rep = new LandeRepository();
            var lande = rep.HentLande();

            PersonRepository pRep = new PersonRepository();
            var person = pRep.HentPerson();
            return View(person);
        }

        [HttpPost]
        public IActionResult Index(Person p)
        {

            return Content($"{p.Navn} er blevet opdateret!");
        }
    }
}