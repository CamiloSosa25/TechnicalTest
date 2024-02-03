using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MediaCalculatorController(IMediaCalculator mediaCalculator) : ControllerBase
    {
        private readonly IMediaCalculator _mediaCalculator = mediaCalculator;

        [HttpGet]
        public ActionResult<double> GetMediaAritmetica([FromQuery] List<double> numeros)
        {
            if (numeros == null || numeros.Count == 0)
            {
                return BadRequest("La lista de números no puede estar vacía.");
            }
            var resultado = _mediaCalculator.GetMedia(numeros);
            return Ok(resultado);
        }
    }
}