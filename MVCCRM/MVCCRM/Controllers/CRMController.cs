using Microsoft.AspNetCore.Mvc;
namespace MVCCRM.Controllers
{
    public class CRMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult contacts()
        {
            return View();
        }
        public IActionResult opportunities()
        {
            return View();
        }
        public IActionResult Leads()
        {
            return View();
        }
        public IActionResult Customers()
        {
            return View();
        }
    }
}
