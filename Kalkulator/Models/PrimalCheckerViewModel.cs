using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Models
{
    public class PrimalCheckerViewModel
    {
        public int Value1
        {
            get;
            set;
        }
        public List<int> PrimalList { get; set; }
        public int Amount { get; set; }
        public string Time { get; set; }
    }
}
