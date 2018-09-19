using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jAttrRouting.Controllers
{
    public class LagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}