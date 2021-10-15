using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace S2_NCORE_FirstMVC.Web.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "carlos@hotmail.com" && password =="123456")
            {
                return RedirectToAction("Index","Home",new { area = "Marketing"});
            }

            return RedirectToAction("Login");
        }

    }
}
