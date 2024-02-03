using Application.Services;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaArmonicaController(IMediaCalculator mediaArmonicaCalculator) : ControllerBase
    {
        private readonly IMediaCalculator _mediaArmonicaCalculator = mediaArmonicaCalculator;

        [HttpGet]
        public ActionResult<double> Get([FromQuery] List<double> numeros)
        {
            if (numeros == null || numeros.Count == 0)
            {
                return BadRequest("La lista de números no puede estar vacía.");
            }

            try
            {
                var resultado = _mediaArmonicaCalculator.GetMedia(numeros);
                return Ok(resultado);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
