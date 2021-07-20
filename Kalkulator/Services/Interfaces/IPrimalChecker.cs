using Kalkulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Services.Interfaces
{
    public interface IPrimalChecker
    {
        public PrimalCheckerViewModel Check(PrimalCheckerViewModel model);

    }
}
