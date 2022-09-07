using Microsoft.AspNetCore.Mvc;
namespace MVCCRM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult chat()
        {
            return View();
        }
        public IActionResult ContactList()
        {
            return View();
        }
        public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult Invoice()
        {
            return View();
        }
    }
}
