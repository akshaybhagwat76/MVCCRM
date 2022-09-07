using Microsoft.AspNetCore.Mvc;
namespace MVCCRM.Controllers
{
    public class EcommercesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ProductDetails()
        {
            return View();
        }
        public IActionResult cart()
        {
            return View();
        }
        public IActionResult checkout()
        {
            return View();
        }
    }
}
