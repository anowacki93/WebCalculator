using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kalkulator.Models
{
    public class CalculatorViewModel
    {
        public int Id { get; set; }
        [Required]
        //[RegularExpression("some regex", ErrorMessage = "Tylko Liczby")]
        public double Value1
        {
            get;
            set;
        }
        [Required]
        //[RegularExpression("some regex", ErrorMessage = "Tylko Liczby")]
        public double Value2
        {
            get;
            set;
        }
        public double Result
        {
            get;
            set;
        }
        public string Operation
        {
            get;set;
        }
    }
}
