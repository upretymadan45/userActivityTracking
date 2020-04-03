using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tracking.Filters;
using tracking.Models;

namespace tracking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[ServiceFilter(typeof(UserFilterAttribute))]

        public IActionResult Privacy(string name)
        {
            return View();
        }

        public IActionResult New(){
            return View();
        }

        [HttpPost]
        [Authorize]
        //[ServiceFilter(typeof(UserFilterAttribute))]
        public IActionResult New(Employee employee)
        {
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
