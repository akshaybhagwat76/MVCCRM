using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCRM.Controllers
{
    public class MapsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GoogleMaps()
        {
            return View();
        }
        public IActionResult leaflet()
        {
            return View();
        }
        public IActionResult vector()
        {
            return View();
        }
    }
}
