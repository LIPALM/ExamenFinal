using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PilotoAvionesControle : ControllerBase
    {
        private readonly ILogger<PilotoAvionesControle> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public PilotoAvionesControle(
            ILogger<PilotoAvionesControle> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] PilotoAviones pilotoaviones)
        {
            _aplicacionContexto.PilotoAviones.Add(pilotoaviones);
            _aplicacionContexto.SaveChanges();
            return Ok(pilotoaviones);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]

        public IEnumerable<PilotoAviones> Get()
        {
            return _aplicacionContexto.PilotoAviones.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] PilotoAviones pilotoaviones)
        {
            _aplicacionContexto.PilotoAviones.Update(pilotoaviones);
            _aplicacionContexto.SaveChanges();
            return Ok(pilotoaviones);
                
        }

        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int pilotoavionesID)
        {
            _aplicacionContexto.PilotoAviones.Remove(
                _aplicacionContexto.PilotoAviones.ToList()
                .Where(x=>x.idRelaciones == pilotoavionesID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(pilotoavionesID);
        }
    }
}