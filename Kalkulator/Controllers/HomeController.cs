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
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CalculatorViewModel model, string command)
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
        public IActionResult Show(string? command)
        {
            var modelData = _modelService.GetAll();
            if (command == "Addition")
            {
                modelData=_modelService.GetAll().Where(x => x.Operation == "Addition").ToList();

            }
            if (command == "Substract")
            {
                modelData= _modelService.GetAll().Where(x => x.Operation == "Substract").ToList();
            }
            if (command == "Multiply")
            {
                modelData= _modelService.GetAll().Where(x => x.Operation == "Multiply").ToList();
            }
            if (command == "Divide")
            {
                modelData= _modelService.GetAll().Where(x => x.Operation == "Divide").ToList();
            }
            if (command == "Modulo")
            {
                modelData= _modelService.GetAll().Where(x => x.Operation == "Modulo").ToList();
            }
            if (command == "All")
            {
                modelData = _modelService.GetAll();
            }


            return View(modelData);
        }
        public IActionResult ShowByOperation(string operation)
        {
            var modelData = _modelService.GetAll();
            return View(modelData.Where(x=>x.Operation== operation));
        }

    }
}
