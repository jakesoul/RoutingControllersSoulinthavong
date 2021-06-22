﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoutingControllersSoulinthavong.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingControllersSoulinthavong.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/")]
        public IActionResult Index() //default routing
        {
            return View();
        }

        [Route("About")] //attribute routing applied
        public IActionResult About()
        {
            return Content("Home controller, About action");
        }

        public IActionResult Privacy()
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
