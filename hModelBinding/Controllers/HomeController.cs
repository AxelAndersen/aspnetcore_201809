using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hModelBinding.Models;
using hModelBinding.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace hModelBinding.Controllers
{
    public class HomeController : Controller
    {

        private AppSettings appSetting;
        private ILogger logger;
        private readonly LandeRepository _rep;

        public HomeController(AppSettings appSetting, ILogger<HomeController> logger, LandeRepository rep)
        {
            this.appSetting = appSetting;
            this.logger = logger;
            _rep = rep;
        }

        [HttpGet]
        [ResponseCache(Duration = 30, Location = ResponseCacheLocation.Client)]
        public IActionResult Index()
        {
            Person p = new Person() { LandId = "DK", Alder = 1, Navn = "Axel" };

            ViewBag.Lande = _rep.HentLande();


            return View(p);
        }

        [HttpPost]        
        public IActionResult Index(Person p)
        {    
            if(ModelState.IsValid)
            {               
                ViewBag.Lande = _rep.HentLande();
            }
            else
            {
                return RedirectToAction("/");
            }
            
            return View(p);
        }
    }
}