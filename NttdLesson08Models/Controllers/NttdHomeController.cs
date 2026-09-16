using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NttdLesson08Models.Models;

namespace NttdLesson08Models.Controllers
{
    public class NttdHomeController : Controller
    {
        public IActionResult NttdIndex()
        {
            return View();
        }

        public IActionResult NttdPrivacy()
        {
            return View();
        }

        public IActionResult NttdAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
