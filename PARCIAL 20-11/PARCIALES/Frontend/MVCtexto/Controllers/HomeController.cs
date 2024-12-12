using Microsoft.AspNetCore.Mvc;
using MVCtexto.Models;
using System.Diagnostics;

namespace MVCtexto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            ViewData["TextColor"] = "red";
            return View();
        }
    }
}
