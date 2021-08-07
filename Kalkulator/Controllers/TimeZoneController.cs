using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Controllers
{
    public class TimeZoneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
