using MaktabGram.Domain.Core.UserAgg.Dtos;
using MaktabGram.Presentation.MVC.Models;
using MaktabGram.Services.UserAgg;
using Microsoft.AspNetCore.Mvc;

namespace MaktabGram.Presentation.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService userService;

        public AccountController()
        {
            userService = new UserService();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            var loginResult = userService.Login(model.Mobile, model.Password);

            if (loginResult.IsSuccess)
            {

            }
            else
            {
                ViewBag.LoginError = loginResult.Message;
            }

            return View(model);
        }

        [HttpGet] // برای دریافت صفحه
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost] //  برای گرفتن دیتا از کاربر و پاس دادن به اکشن داخل کنترولر
        public ActionResult Register(RegisterViewModel model)
        {
            var userModel = new RegisterUserInputDto
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Mobile = model.Mobile,
                Username = model.Username,
                Password = model.Password,
            };

            var registerResult = userService.Register(userModel);

            if(registerResult.IsSuccess)
            {
                //.....
            }
            else
            {
                ViewBag.RegisterErorr = registerResult.Message; 
            }

            return View();
        }
    }
}
