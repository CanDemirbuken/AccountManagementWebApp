using AccountManagementWebApp.EntityLayer.Concrete;
using AccountManagementWebApp.WebUI.DTOs.AccountDTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AccountManagementWebApp.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserDTO registerUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var appUser = new AppUser()
            {
                FirstNane = registerUserDTO.Name,
                LastName = registerUserDTO.Surname,
                City = registerUserDTO.City,
                Email = registerUserDTO.Mail,
                UserName = registerUserDTO.Username
            };

            var result = await _userManager.CreateAsync(appUser, registerUserDTO.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Account", "Login");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserDTO loginUserDTO)
        {
            if (ModelState.IsValid)
            {
                string password = loginUserDTO.Password;
                var result = await _signInManager.PasswordSignInAsync(loginUserDTO.UserName, password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
