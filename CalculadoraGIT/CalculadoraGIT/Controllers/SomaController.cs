using CalculadoraGIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraGIT.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class SomaController : Controller
    {
        // POST: api/Somaersdfghfdfg
        [HttpPost]
        public Retorno Post([FromBody] Aritimetica obj)
        {
            return new Retorno(obj.Somar());
        }
    }
}