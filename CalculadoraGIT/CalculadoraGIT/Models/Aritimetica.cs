using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraGIT.Models
{
    public class Aritimetica
    {
        public decimal n1 { get; set; }
        public decimal n2 { get; set; }

        public decimal somar()
        {
            return n1 + n2;
        }
    }
    
}
