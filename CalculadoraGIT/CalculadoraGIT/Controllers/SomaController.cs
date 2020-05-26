using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraGIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraGIT.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SomaController : Controller
    {
        // api/Soma
        [HttpPost]
        public Retorno Post([FromBody] Aritimetica obj)
        {
            return new Retorno(obj.somar());
        }
    }
}