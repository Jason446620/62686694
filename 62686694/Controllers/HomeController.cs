﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _62686694.Models;

namespace _62686694.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public string getEnv() {
            string env = string.Empty;
            env = "ASPNETCORE_ENVIRONMENT = " + Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            env += "  &&   MaxRequestBodySizeValue = " + Program.MaxRequestBodySizeValue;
            return env;
        }
    }
}
