﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraGIT.Models
{
    public class Retorno
    {
        public decimal Valor { get; set; }

        public Retorno(decimal valor)
        {
            this.Valor = valor;
        }
    }
}
