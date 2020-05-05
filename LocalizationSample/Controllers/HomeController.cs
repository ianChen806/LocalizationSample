using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LocalizationSample.Models;
using LocalizationSample.Resources;
using Microsoft.Extensions.Localization;

namespace LocalizationSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public HomeController(ILogger<HomeController> logger,
                              IStringLocalizer<SharedResources> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Index()
        {
            ViewBag.Account = _localizer["Account"];
            ViewBag.Password = _localizer["Password"];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}