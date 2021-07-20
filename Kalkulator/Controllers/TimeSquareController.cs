using Kalkulator.Models;
using Kalkulator.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Controllers
{
    public class TimeSquareController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            //_modelService.TimeSquared(model);
            //return View(model);

            return View();
        }


    }
}
