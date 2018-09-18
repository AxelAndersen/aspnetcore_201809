using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using bModelOpgave.Models;
using bModelOpgave.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace bModelOpgave.Controllers
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
            logger.LogInformation("In index");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("de");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");

            PersonRepositoryMock rep = new PersonRepositoryMock();
            Person person =  rep.HentPerson();

            return View(person);
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            if (ModelState.IsValid)
            {
                logger.LogInformation("Posted person");

                return View(person);
            }
            else
            {               
                return View(person);
            }
        }
    }
}