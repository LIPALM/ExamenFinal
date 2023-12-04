using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PilotosCrontole : ControllerBase
    {
        private readonly ILogger<PilotosCrontole> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public PilotosCrontole(
            ILogger<PilotosCrontole> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Pilotos piloto)
        {
            _aplicacionContexto.Pilotos.Add(piloto);
            _aplicacionContexto.SaveChanges();
            return Ok(piloto);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Pilotos> Get()
        {
            return _aplicacionContexto.Pilotos.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Pilotos piloto)
        {
            _aplicacionContexto.Pilotos.Update(piloto);
            _aplicacionContexto.SaveChanges();
            return Ok(piloto);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int pilotoID)
        {
            _aplicacionContexto.Pilotos.Remove(
                _aplicacionContexto.Pilotos.ToList()
                .Where(x=>x.idPiloto == pilotoID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(pilotoID);
        }
    }
}