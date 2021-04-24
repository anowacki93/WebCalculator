using Kalkulator.Models;
using Kalkulator.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICalculate _modelService;
        public HomeController(ICalculate modelService)
        {
            _modelService = modelService;
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(CalculatorViewModel model, string command)
        {
            if (command == "add")
            {
                _modelService.Addition(model);
            }
            if (command == "sub")
            {
                _modelService.Sububstract(model);
            }
            if (command == "mul")
            {
                _modelService.Multiply(model);
            }
            if (command == "div")
            {
                _modelService.Divide(model);
            }
            if (command == "mod")
            {
                _modelService.Modulo(model);
            }
            return View(model);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

    }
}
