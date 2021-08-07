using Kalkulator.Models;
using Kalkulator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Services
{
    public class PrimalCheckerService : IPrimalChecker
    {
        public PrimalCheckerViewModel Check(PrimalCheckerViewModel model)
        {
            model.PrimalList = new List<int>();
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i <= model.Value1; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2||i==1)
                {
                    model.PrimalList.Add(i);
                }
            }
            model.Amount = model.PrimalList.Count();
            stopwatch.Stop();
            model.Time = stopwatch.ElapsedMilliseconds.ToString()+"ms";
            return model;
        }
    }
}
