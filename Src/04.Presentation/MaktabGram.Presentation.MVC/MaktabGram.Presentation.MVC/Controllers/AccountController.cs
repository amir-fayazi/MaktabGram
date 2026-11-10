using MaktabGram.Presentation.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MaktabGram.Presentation.MVC.Controllers
{
    public class AccountController : Controller

    {
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginUser(LoginViewModel model)
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }
    }
}
