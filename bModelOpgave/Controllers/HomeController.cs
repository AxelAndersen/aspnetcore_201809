using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using bModelOpgave.Models;
using bModelOpgave.Models.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
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

            PersonRepositoryMock rep = new PersonRepositoryMock();
            Person person =  rep.HentPerson();

            return View(person);
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            CultureInfo culture = new CultureInfo(person.UserLanguage);
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {               
                return View(person);
            }
        }
    }
}