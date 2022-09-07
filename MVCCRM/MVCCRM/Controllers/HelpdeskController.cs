using Microsoft.AspNetCore.Mvc;
namespace MVCCRM.Controllers
{
    public class HelpdeskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tickets()
        {
            return View();
        }
        public IActionResult reports()
        {
            return View();
        }
        public IActionResult agents()
        {
            return View();
        }
    }
}
