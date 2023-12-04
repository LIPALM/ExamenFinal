using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HangaresControle : ControllerBase
    {
        private readonly ILogger<HangaresControle> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public HangaresControle(
            ILogger<HangaresControle> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Hangares hangares)
        {
            _aplicacionContexto.Hangares.Add(hangares);
            _aplicacionContexto.SaveChanges();
            return Ok(hangares);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Hangares> Get()
        {
            return _aplicacionContexto.Hangares.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Hangares hangares)
        {
            _aplicacionContexto.Hangares.Update(hangares);
            _aplicacionContexto.SaveChanges();
            return Ok(hangares);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int hangaresID)
        {
            _aplicacionContexto.Hangares.Remove(
                _aplicacionContexto.Hangares.ToList()
                .Where(x=>x.idHangar == hangaresID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(hangaresID);
        }
    }
}