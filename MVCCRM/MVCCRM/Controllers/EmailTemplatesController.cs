using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCRM.Controllers
{
    public class EmailTemplatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BasicActionEmail()
        {
            return View();
        }
        public IActionResult AlertEmail()
        {
            return View();
        }
        public IActionResult BillingEmail()
        {
            return View();
        }
    }
}
