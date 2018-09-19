using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cronberg
{
    public class PersonFormViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {                   
            return View(new Cronberg.Person());
        }
    }
}
