using Microsoft.AspNetCore.Mvc;
namespace MVCCRM.Controllers
{
    public class AnalyticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult reports()
        {
            return View();
        }
        public IActionResult customer()
        {
            return View();
        }
    }
}
