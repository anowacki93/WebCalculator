using Kalkulator.Context;
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
        private readonly CalcDbContext _context;
        public CalculateService(CalcDbContext context)
        {
            _context = context;
        }
        public double Addition(CalculatorViewModel model)
        {
            model.Operation = "Addition";
            model.Result = model.Value1 + model.Value2;
            _context.CalculatorViewModels.Add(model);
            _context.SaveChanges();
            return model.Result;
        }
        public double Divide(CalculatorViewModel model)
        {
            model.Operation = "Divide";
            model.Result = model.Value1 / model.Value2;
            _context.CalculatorViewModels.Add(model);
            _context.SaveChanges();
            return model.Result;
        }

        public double Modulo(CalculatorViewModel model)
        {
            model.Operation = "Modulo";
            model.Result = model.Value1 % model.Value2;
            _context.CalculatorViewModels.Add(model);
            _context.SaveChanges();
            return model.Result;
        }
        public double Multiply(CalculatorViewModel model)
        {
            model.Operation = "Multiply";
            model.Result = model.Value1 * model.Value2;
            _context.CalculatorViewModels.Add(model);
            _context.SaveChanges();
            return model.Result;
        }
        public double Sububstract(CalculatorViewModel model)
        {
            model.Operation = "Substract";
            model.Result = model.Value1 - model.Value2;
            _context.CalculatorViewModels.Add(model);
            _context.SaveChanges();
            return model.Result;
        }
        public IList<CalculatorViewModel> GetAll()
        {
            return _context.CalculatorViewModels.ToList();
        }
    }
}
