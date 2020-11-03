using Microsoft.AspNetCore.Mvc;
using StoreBuild.Application.Convertors;
using StoreBuild.Application.Services.User;
using StoreBuild.Application.ViewModels;

namespace StoreBuild.Web.Controllers
{
    public class AccountController : Controller
    {
        private UserService _userService;

        public AccountController(UserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        [Route("Account/Register")]
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        [Route("Account/Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_userService.IsExistMobile(FixedText.FixMobile(register.Mobile)))
            {
                ModelState.AddModelError("Mobile","شما قبلا در سایت ثبت نام کرده اید .");
                return View(register);
            }
            //TODO Add User
            return View();
        }
    }
}