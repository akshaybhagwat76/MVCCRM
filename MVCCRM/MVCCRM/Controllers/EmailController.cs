using Microsoft.AspNetCore.Mvc;
namespace MVCCRM.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Inbox()
        {
            return View();
        }
        public IActionResult ReadEmail()
        {
            return View();
        }
    }
}
