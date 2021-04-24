using Kalkulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Services.Interfaces
{
    public interface ICalculate
    {
        public double Addition(CalculatorViewModel model);
        public double Sububstract(CalculatorViewModel model);
        public double Multiply(CalculatorViewModel model);
        public double Divide(CalculatorViewModel model);
        public double Modulo(CalculatorViewModel model);

    }
}
