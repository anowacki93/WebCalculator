using Kalkulator.Models;
using Kalkulator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Services
{
    public class CalculateService : ICalculate
    {
        public double Addition(CalculatorViewModel model)
        {
            model.Result = model.Value1 + model.Value2;
            return model.Result;
        }

        public double Divide(CalculatorViewModel model)
        {
            model.Result = model.Value1 / model.Value2;
            return model.Result;
        }

        public double Modulo(CalculatorViewModel model)
        {
            model.Result = model.Value1 % model.Value2;
            return model.Result;
        }

        public double Multiply(CalculatorViewModel model)
        {

            model.Result = model.Value1 * model.Value2;
            return model.Result;
        }

        public double Sububstract(CalculatorViewModel model)
        {
            model.Result = model.Value1 - model.Value2;
            return model.Result;
        }
    }
}
