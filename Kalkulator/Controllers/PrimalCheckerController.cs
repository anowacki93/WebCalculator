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
    
    public class PrimalCheckerController : Controller
    {
        public int i = 0;
        private readonly IPrimalChecker _modelService;
        public PrimalCheckerController(IPrimalChecker modelService)
        {
            _modelService = modelService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            //var modeldata = _modelService.Check(model);
            return View();
        }
        [HttpPost]
        public IActionResult Index(PrimalCheckerViewModel model)
        {
            
            var modeldata =_modelService.Check(model);
            return View(modeldata);
        }
        
        [HttpGet]
        public IActionResult DoNumbers()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DoNumbers(PrimalCheckerViewModel model,string command)
        {
            
            if (command == "DoNumber")
            {
                return Redirect("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
