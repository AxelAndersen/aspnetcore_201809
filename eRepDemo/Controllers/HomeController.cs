using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eRepDemo.Models;
using eRepDemo.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

namespace eRepDemo.Controllers
{
    public class HomeController : Controller
    {

        private AppSettings appSetting;
        private ILogger logger;
        private IPersonRepository _rep;
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(AppSettings appSetting, ILogger<HomeController> logger, IPersonRepository rep, IStringLocalizer<HomeController> localizer)
        {
            this.appSetting = appSetting;
            this.logger = logger;
            this._rep = rep;
            this._localizer = localizer;

            //if (DateTime.Now.Millisecond % 2 == 0)
            //{
            //    this._rep = new PersonRepositoryDB();
            //}
            //else
            //{
            //    this._rep = new PersonRepositoryMock();
            //}
        }

        public IActionResult Index()
        {

            var persons = _rep.GetPersons();
            return View(persons);
        }

        public IActionResult ChangeCulture()
        {

            
            return View();
        }
        
    }
}