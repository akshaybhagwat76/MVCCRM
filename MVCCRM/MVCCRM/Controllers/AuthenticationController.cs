using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCRM.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Loginalt()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Registeralt()
        {
            return View();
        }
        public IActionResult RePassword()
        {
            return View();
        }
        public IActionResult RePasswordalt()
        {
            return View();
        }
        public IActionResult Lockscreen()
        {
            return View();
        }
        public IActionResult Lockscreenalt()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult alt404()
        {
            return View();
        }
        public IActionResult Error500()
        {
            return View();
        }
        public IActionResult alt500()
        {
            return View();
        }
    }
}
