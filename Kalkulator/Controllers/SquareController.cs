using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kalkulator.Context;
using Kalkulator.Models;
using Kalkulator.Services.Interfaces;

namespace Kalkulator.Controllers
{
    public class SquareController : Controller
    {
        private readonly ISquare _modelService;
        int i = 1;
        public SquareController(ISquare modelService)
        {
            _modelService = modelService;
        }


        [HttpGet]
        public IActionResult Index(SquareViewModel model)
        {
            model.ArraySize = i;
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(SquareViewModel model, string command)
        {


            if (command == "change array size")
            {
                return Redirect("Squared");
            }
            else
            {
                return View(model);
            }

        }
        [HttpGet]
        public IActionResult Squared(SquareViewModel model)
        {

            return View(model);
        }
        [HttpPost]
        public IActionResult Squared(SquareViewModel model, string command)
        {

            if (command == "do")
            {
                _modelService.Square(model);

            }
            return View(model);
        }
    }
}
