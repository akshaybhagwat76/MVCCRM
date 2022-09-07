using Microsoft.AspNetCore.Mvc;
namespace MVCCRM.Controllers
{
    public class DashboardController : Controller
    {
       
        public string Index()
        {
            return "Hello world";
          //  return View("reports","Analytics");
        }
        public ActionResult Reports()
        {
              return View("reports","Analytics");
        }
    }
}
