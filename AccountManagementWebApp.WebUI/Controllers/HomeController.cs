using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AccountManagementWebApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
