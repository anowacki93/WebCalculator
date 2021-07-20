using Kalkulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Services.Interfaces
{
    public interface ISquare
    {
        public int Square(SquareViewModel model);
    }
}
