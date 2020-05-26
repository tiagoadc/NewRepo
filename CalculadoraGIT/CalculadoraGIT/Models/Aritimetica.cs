using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CalculadoraGIT.Models
{
    public class Aritimetica
    {
        public decimal N1 { get; set; }
        public decimal N2 { get; set; }

        public decimal Somar()
        {
            return N1 + N2;
        }
    }
    
}
