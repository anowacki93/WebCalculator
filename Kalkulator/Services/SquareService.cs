using Kalkulator.Models;
using Kalkulator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Services
{
    public class SquareService : ISquare
    {
        public int Square(SquareViewModel model)
        {

            foreach (var item in model.SquareArray)
            {
                model.SumValue += Convert.ToInt32(Math.Pow(item, 2));


            }
            return model.SumValue;
        }
    }
}
